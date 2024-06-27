namespace Lab22
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            dispose_fl = true;
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox1 = new ComboBox();
            this.comboBox2 = new ComboBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.menuStrip = new MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            Controls.Add(this.menuStrip);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 425);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += buttonMenuClicked;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "Start all";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += buttonStartClicked;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 0;
            this.button3.Text = "Stop all";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += buttonStopClicked;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 50);
            this.button4.Name = "button3";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 0;
            this.button4.Text = "Start 1st";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += buttonStart1Clicked;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 80);
            this.button5.Name = "button3";
            this.button5.Size = new System.Drawing.Size(100, 30);
            this.button5.TabIndex = 0;
            this.button5.Text = "Stop 1st";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += buttonStop1Clicked;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 200);
            this.button6.Name = "button3";
            this.button6.Size = new System.Drawing.Size(100, 30);
            this.button6.TabIndex = 0;
            this.button6.Text = "Start 2nd";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += buttonStart2Clicked;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 230);
            this.button7.Name = "button3";
            this.button7.Size = new System.Drawing.Size(100, 30);
            this.button7.TabIndex = 0;
            this.button7.Text = "Stop 2nd";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += buttonStop2Clicked;
            //
            // label1
            //
            label1.Text = "Priority: ";
            label1.AutoSize = true;
            label1.Location = new Point(0, 110);
            //
            // label2
            //
            label2.Text = "Priority: ";
            label2.AutoSize = true;
            label2.Location = new Point(0, 260);
            //
            // comboBox1
            //
            comboBox1.Items.Add("Normal");
            comboBox1.Items.Add("Above");
            comboBox1.Items.Add("Below");
            comboBox1.Size = new Size(100, 30);
            comboBox1.Location = new Point(0, 140);
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += buttonChangePriority1Clicked;
            //
            // comboBox2
            //
            comboBox2.Items.Add("Normal");
            comboBox2.Items.Add("Above");
            comboBox2.Items.Add("Below");
            comboBox2.Size = new Size(100, 30);
            comboBox2.Location = new Point(0, 290);
            comboBox2.SelectedIndex = 0;
            comboBox2.SelectedIndexChanged += buttonChangePriority2Clicked;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(50, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 425);
            this.panel2.TabIndex = 1;
            //
            // menuStrip
            //
            ToolStripMenuItem start = new ToolStripMenuItem("Start");
            start.DropDownItems.Add("1st thread");
            start.DropDownItems[0].Click += buttonStart1Clicked;
            start.DropDownItems.Add("2nd thread");
            start.DropDownItems[1].Click += buttonStart2Clicked;
            start.DropDownItems.Add("all");
            start.DropDownItems[2].Click += buttonStartClicked;
            menuStrip.Items.Add(start);

            ToolStripMenuItem stop = new ToolStripMenuItem("Stop");
            stop.DropDownItems.Add("1st thread");
            stop.DropDownItems[0].Click += buttonStop1Clicked;
            stop.DropDownItems.Add("2nd thread");
            stop.DropDownItems[1].Click += buttonStop2Clicked;
            stop.DropDownItems.Add("all");
            stop.DropDownItems[2].Click += buttonStopClicked;
            menuStrip.Items.Add(stop);

            //ToolStripMenuItem priority = new ToolStripMenuItem("Priority");
            //priority.DropDownItems.Add("1st thread");
            //priority.DropDownItems[0].Click += buttonChangePriority1Clicked;
            //priority.DropDownItems.Add("2nd thread");
            //priority.DropDownItems[0].Click += buttonChangePriority1Clicked;
            //menuStrip.Items.Add(priority);

            //ToolStripMenuItem about = new ToolStripMenuItem("Help");
            //about.DropDownItems.Add("help");
            //about.DropDownItems.Add("about");
            //menuStrip.Items.Add(about);
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Panel panel2;
        private MenuStrip menuStrip;
    }
}