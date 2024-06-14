namespace ATBMTT
{
    partial class Elgamal
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            richTextBox2 = new RichTextBox();
            label11 = new Label();
            richTextBox1 = new RichTextBox();
            label10 = new Label();
            button3 = new Button();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            button7 = new Button();
            richTextBox3 = new RichTextBox();
            label13 = new Label();
            button6 = new Button();
            textBox8 = new TextBox();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 324);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tạo khóa";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(291, 267);
            button2.Name = "button2";
            button2.Size = new Size(163, 45);
            button2.TabIndex = 11;
            button2.Text = "Tạo khóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 267);
            button1.Name = "button1";
            button1.Size = new Size(244, 45);
            button1.TabIndex = 10;
            button1.Text = "Sinh khóa ngẫu nhiên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(192, 216);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(224, 34);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 222);
            label6.Name = "label6";
            label6.Size = new Size(131, 28);
            label6.TabIndex = 8;
            label6.Text = "Số nguyên a:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(192, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(224, 34);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 34);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 34);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 186);
            label5.Name = "label5";
            label5.Size = new Size(161, 28);
            label5.TabIndex = 4;
            label5.Text = "Khóa bí mật (a)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 146);
            label4.Name = "label4";
            label4.Size = new Size(118, 28);
            label4.TabIndex = 3;
            label4.Text = "Số (beta) β:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 100);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 2;
            label3.Text = "Số (alpha) α:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 58);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 1;
            label2.Text = "Số nguyên tố p:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 18);
            label1.Name = "label1";
            label1.Size = new Size(238, 28);
            label1.TabIndex = 0;
            label1.Text = "Khóa công khai (p, α, b)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(richTextBox2);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(520, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(859, 708);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thực hiện ký";
            // 
            // button5
            // 
            button5.Location = new Point(472, 569);
            button5.Name = "button5";
            button5.Size = new Size(270, 41);
            button5.TabIndex = 21;
            button5.Text = "Reset";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(67, 569);
            button4.Name = "button4";
            button4.Size = new Size(270, 41);
            button4.TabIndex = 20;
            button4.Text = "Ký lên văn bản";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(16, 467);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(815, 72);
            richTextBox2.TabIndex = 19;
            richTextBox2.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 419);
            label11.Name = "label11";
            label11.Size = new Size(180, 28);
            label11.TabIndex = 18;
            label11.Text = "Tệp chữ ký gửi đi:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(16, 219);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(815, 184);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 171);
            label10.Name = "label10";
            label10.Size = new Size(141, 28);
            label10.TabIndex = 16;
            label10.Text = "Nội dung tệp:";
            // 
            // button3
            // 
            button3.Location = new Point(645, 118);
            button3.Name = "button3";
            button3.Size = new Size(186, 38);
            button3.TabIndex = 15;
            button3.Text = "Chọn tệp";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(16, 122);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(595, 34);
            textBox7.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 83);
            label9.Name = "label9";
            label9.Size = new Size(175, 28);
            label9.TabIndex = 12;
            label9.Text = "Chọn tệp cần ký: ";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(573, 34);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(270, 34);
            textBox6.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(497, 37);
            label8.Name = "label8";
            label8.Size = new Size(56, 28);
            label8.TabIndex = 12;
            label8.Text = "Số y:";
            label8.Click += label8_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(182, 34);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(270, 34);
            textBox5.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 40);
            label7.Name = "label7";
            label7.Size = new Size(168, 28);
            label7.TabIndex = 11;
            label7.Text = "Số ngẫu nhiên k:";
            label7.Click += label7_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(richTextBox3);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(label12);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 355);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(502, 365);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kiểm tra chữ ký";
            // 
            // button7
            // 
            button7.Location = new Point(114, 318);
            button7.Name = "button7";
            button7.Size = new Size(270, 41);
            button7.TabIndex = 22;
            button7.Text = "Kiểm tra";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(6, 132);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(479, 180);
            richTextBox3.TabIndex = 22;
            richTextBox3.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 101);
            label13.Name = "label13";
            label13.Size = new Size(141, 28);
            label13.TabIndex = 22;
            label13.Text = "Nội dung tệp:";
            // 
            // button6
            // 
            button6.Location = new Point(390, 60);
            button6.Name = "button6";
            button6.Size = new Size(106, 38);
            button6.TabIndex = 22;
            button6.Text = "Chọn tệp";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(6, 64);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(378, 34);
            textBox8.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 30);
            label12.Name = "label12";
            label12.Size = new Size(232, 28);
            label12.TabIndex = 22;
            label12.Text = "Chọn tệp cần kiểm tra: ";
            // 
            // Elgamal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 745);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Elgamal";
            Text = "Chữ ký ELgamal";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Button button1;
        private TextBox textBox4;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox5;
        private Button button2;
        private Label label9;
        private Label label10;
        private Button button3;
        private TextBox textBox7;
        private Button button5;
        private Button button4;
        private RichTextBox richTextBox2;
        private Label label11;
        private RichTextBox richTextBox1;
        private GroupBox groupBox3;
        private Button button6;
        private TextBox textBox8;
        private Label label12;
        private Button button7;
        private RichTextBox richTextBox3;
        private Label label13;
    }
}
