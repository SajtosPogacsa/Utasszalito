namespace UtasszalitokGUI
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            torloTbx = new TextBox();
            statTbx = new TextBox();
            button1 = new Button();
            label3 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Torlónyomás:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 0;
            label2.Text = "Statikus nyomás:";
            // 
            // torloTbx
            // 
            torloTbx.Location = new Point(121, 9);
            torloTbx.Name = "torloTbx";
            torloTbx.Size = new Size(100, 23);
            torloTbx.TabIndex = 1;
            // 
            // statTbx
            // 
            statTbx.Location = new Point(121, 38);
            statTbx.Name = "statTbx";
            statTbx.Size = new Size(100, 23);
            statTbx.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(243, 8);
            button1.Name = "button1";
            button1.Size = new Size(66, 53);
            button1.TabIndex = 2;
            button1.Text = "Számol";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "Eredmények";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 112);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(297, 274);
            listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 401);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(statTbx);
            Controls.Add(torloTbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Mach-szám kalkulátor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox torloTbx;
        private TextBox statTbx;
        private Button button1;
        private Label label3;
        private ListBox listBox1;
    }
}
