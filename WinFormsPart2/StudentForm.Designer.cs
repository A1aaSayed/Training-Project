namespace WinFormsPart2
{
    partial class StudentForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label7 = new Label();
            groupBox1 = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Maroon;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(54, 46);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(196, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 34);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(196, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(293, 34);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Maroon;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(54, 103);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Maroon;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(54, 157);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 4;
            label3.Text = "Birth Date";
            label3.Click += label3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(196, 159);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(293, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(196, 283);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(293, 34);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Maroon;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(54, 286);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 6;
            label4.Text = "Phone";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(196, 341);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(293, 34);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Maroon;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(54, 344);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 8;
            label5.Text = "Address";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Maroon;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(54, 403);
            label6.Name = "label6";
            label6.Size = new Size(79, 28);
            label6.TabIndex = 10;
            label6.Text = "Picture";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gainsboro;
            pictureBox1.Location = new Point(196, 403);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(196, 553);
            button1.Name = "button1";
            button1.Size = new Size(293, 29);
            button1.TabIndex = 12;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Maroon;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(55, 212);
            label7.Name = "label7";
            label7.Size = new Size(80, 28);
            label7.TabIndex = 13;
            label7.Text = "Gender";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(196, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 60);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.ForeColor = SystemColors.ButtonHighlight;
            checkBox2.Location = new Point(154, 23);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(81, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Female";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(24, 23);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(65, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Male";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOliveGreen;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(54, 614);
            button2.Name = "button2";
            button2.Size = new Size(171, 50);
            button2.TabIndex = 15;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(318, 614);
            button3.Name = "button3";
            button3.Size = new Size(171, 50);
            button3.TabIndex = 16;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(549, 685);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonShadow;
            Name = "StudentForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label7;
        private GroupBox groupBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button2;
        private Button button3;
    }
}