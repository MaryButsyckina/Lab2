using Lab1;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;

namespace Lab22
{
    public partial class Form1 : Form
    {
        public Thread thread1;
        public Thread thread2;
        public CancellationTokenSource cancelTokenSource1;
        public CancellationToken token1;
        public CancellationTokenSource cancelTokenSource2;
        public CancellationToken token2;
        public bool dispose_fl = false;

        List<FurniturePc> furnitureList1;
        List<FurniturePc> furnitureList2;
        FurniturePc furniture1;
        FurniturePc furniture2;

        public string ph1;
        public string ph2;

        public Form1()
        {
            InitializeComponent();

            furnitureList1 = new List<FurniturePc>();
            furnitureList2 = new List<FurniturePc>();

            ph1 = "Table.jpeg";
            ph2 = "Chair.jpeg";

            Random rnd = new Random();
            int x1 = rnd.Next(5, 10);
            int x2 = rnd.Next(5, 10);
            //int x1 = 1, x2 = 2;

            for (int i = 0; i < x1; i++)
            {
                PictureBox pcb = new PictureBox();
                pcb.Image = Image.FromFile(ph1);
                pcb.SizeMode = PictureBoxSizeMode.StretchImage;
                pcb.Size = new Size(100, 50);
                pcb.Location = new Point(rnd.Next(0, 400), rnd.Next(0, 350));
                panel2.Controls.Add(pcb);

                furnitureList1.Add(new FurniturePc());
                furnitureList1[i].SetPicturePath(ph1);
                furnitureList1[i].SetVx(i + 1);
                furnitureList1[i].SetVy(0);
                furnitureList1[i].SetPictureBox(pcb);
            }

            for (int i = 0; i < x2; i++)
            {
                PictureBox pcb = new PictureBox();
                pcb.Image = Image.FromFile(ph2);
                pcb.SizeMode = PictureBoxSizeMode.StretchImage;
                pcb.Size = new Size(100, 50);
                pcb.Location = new Point(rnd.Next(0, 400), rnd.Next(0, 350));
                panel2.Controls.Add(pcb);

                furnitureList2.Add(new FurniturePc());
                furnitureList2[i].SetPicturePath(ph1);
                furnitureList2[i].SetVx(i + 1);
                furnitureList2[i].SetVy(i + 1);
                furnitureList2[i].SetPictureBox(pcb);
            }            

            cancelTokenSource1 = new CancellationTokenSource();
            token1 = cancelTokenSource1.Token;
            cancelTokenSource2 = new CancellationTokenSource();
            token2 = cancelTokenSource2.Token;
            thread1 = new Thread(new ParameterizedThreadStart(MoveV));
            thread2 = new Thread(new ParameterizedThreadStart(MoveR));

            cancelTokenSource1.Cancel();
            thread1.Start(furnitureList1);
            cancelTokenSource2.Cancel();
            thread2.Start(furnitureList2);
        }

        void MoveV(object? pb_list)
        {
            List<FurniturePc> fs = (List<FurniturePc>)pb_list;

            while (true)
            {
                if (dispose_fl) break;
                if (token1.IsCancellationRequested) continue;
                else
                {
                    int i = 1;
                    foreach (FurniturePc f in fs)
                    {
                        int x = f.GetPicture().Location.X;
                        int y = f.GetPicture().Location.Y;
                        if (x > panel2.Size.Width - 100 || y > panel2.Size.Height - 50||
                            x < 0 || y < 0) 
                        {
                            f.SetVx(f.GetVx() * -1); f.SetVy(f.GetVy() * -1);
                        }
                        int vy = f.GetVy();
                        int vx = f.GetVx();
                        Action action = () => f.GetPicture().Location = new Point(x + vx, y + vy);
                        try { Invoke(action); }
                        catch (System.ObjectDisposedException e)
                        { break; }
                    }
                    Thread.Sleep(50);
                }
            }
        }
        void MoveR(object? pb_list)
        {
            List<FurniturePc> fs = (List<FurniturePc>)pb_list;

            int change_v = 0;
            Random rnd = new Random();

            while (true)
            {
                if (dispose_fl) break;
                if (token2.IsCancellationRequested) continue;
                else
                {
                    int i = 1;
                    foreach (FurniturePc f in fs)
                    {
                        int x = f.GetPicture().Location.X;
                        int y = f.GetPicture().Location.Y;
                        if (x > panel2.Size.Width - 100 || y > panel2.Size.Height - 50 ||
                            x < 0 || y < 0)
                        {
                            f.SetVx(f.GetVx() * -1); f.SetVy(f.GetVy() * -1);
                        }
                        else if (change_v == 50)
                        {
                            f.SetVx(rnd.Next(-10, 10));
                            f.SetVy(rnd.Next(-10, 10));
                        }
                        int vy = f.GetVy();
                        int vx = f.GetVx();
                        Action action = () => f.GetPicture().Location = new Point(x + vx, y + vy);
                        try { Invoke(action); }
                        catch (System.ObjectDisposedException e)
                        { break; }
                    }
                    if (change_v == 50) change_v = 0;
                    change_v++;
                    Thread.Sleep(50);
                }
            }
        }
        private void buttonMenuClicked(object sender, EventArgs e)
        {
            if (panel1.Size.Width > 50) 
            {
                panel1.Size = new Size(50, 425);
                panel2.Size = new Size(750, 450);
                panel2.Location = new Point(50, 25);
                this.panel1.Controls.Remove(this.button2);
                this.panel1.Controls.Remove(this.button3);
                this.panel1.Controls.Remove(this.button5);
                this.panel1.Controls.Remove(this.button4);
                this.panel1.Controls.Remove(this.button6);
                this.panel1.Controls.Remove(this.button7);
                this.panel1.Controls.Remove(this.label1);
                this.panel1.Controls.Remove(this.label2);
                this.panel1.Controls.Remove(this.comboBox1);
                this.panel1.Controls.Remove(this.comboBox2);
            }
            else
            {
                panel1.Size = new Size(110, 425);
                panel2.Size = new Size(690, 425);
                panel2.Location = new Point(110, 25);
                this.panel1.Controls.Add(this.button2);
                this.panel1.Controls.Add(this.button3);
                this.panel1.Controls.Add(this.button4);
                this.panel1.Controls.Add(this.button5);
                this.panel1.Controls.Add(this.button6);
                this.panel1.Controls.Add(this.button7);
                this.panel1.Controls.Add(this.label1);
                this.panel1.Controls.Add(this.label2);
                this.panel1.Controls.Add(this.comboBox1);
                this.panel1.Controls.Add(this.comboBox2);
            }
        }
        private void buttonStartClicked(object sender, EventArgs e)
        {
            cancelTokenSource1 = new CancellationTokenSource();
            token1 = cancelTokenSource1.Token;

            cancelTokenSource2 = new CancellationTokenSource();
            token2 = cancelTokenSource2.Token;
        }
        private void buttonStart1Clicked(object sender, EventArgs e)
        {
            cancelTokenSource1 = new CancellationTokenSource();
            token1 = cancelTokenSource1.Token;
        }
        private void buttonStart2Clicked(object sender, EventArgs e)
        {
            cancelTokenSource2 = new CancellationTokenSource();
            token2 = cancelTokenSource1.Token;
        }
        private void buttonStopClicked(object sender, EventArgs e) 
        {
            cancelTokenSource1.Cancel();
            cancelTokenSource2.Cancel();
        }
        private void buttonStop1Clicked(object sender, EventArgs e)
        {
            cancelTokenSource1.Cancel();
        }
        private void buttonStop2Clicked(object sender, EventArgs e)
        {
            cancelTokenSource2.Cancel();
        }
        private void buttonChangePriority1Clicked(object sender, EventArgs e)
        {
            string priority = ((ComboBox)sender).SelectedItem.ToString();
            if (priority == "Normal") thread1.Priority = ThreadPriority.Normal;
            else if (priority == "Above") thread1.Priority = ThreadPriority.AboveNormal;
            else thread1.Priority = ThreadPriority.BelowNormal;
        }
        private void buttonChangePriority2Clicked(object sender, EventArgs e)
        {
            string priority = ((ComboBox)sender).SelectedItem.ToString();
            if (priority == "Normal") thread2.Priority = ThreadPriority.Normal;
            else if (priority == "Above") thread2.Priority = ThreadPriority.AboveNormal;
            else thread2.Priority = ThreadPriority.BelowNormal;
        }
    }
}