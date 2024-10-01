namespace المحاضرة_الرابعة_الكود_الثاني
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.addA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deletA = new System.Windows.Forms.Button();
            this.showA = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sumA = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(303, 29);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 20);
            this.number1.TabIndex = 0;
            this.number1.TextChanged += new System.EventHandler(this.number1_TextChanged);
            this.number1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number1_KeyPress);
            this.number1.Leave += new System.EventHandler(this.number1_Leave);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(74, 29);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 20);
            this.number2.TabIndex = 1;
            // 
            // addA
            // 
            this.addA.Location = new System.Drawing.Point(201, 56);
            this.addA.Name = "addA";
            this.addA.Size = new System.Drawing.Size(75, 23);
            this.addA.TabIndex = 2;
            this.addA.Text = "اضافة عنصر للمصفوفة";
            this.addA.UseVisualStyleBackColor = true;
            this.addA.Click += new System.EventHandler(this.addA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ادخل عدد العناصر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ادخل العنصر";
            // 
            // deletA
            // 
            this.deletA.Location = new System.Drawing.Point(328, 105);
            this.deletA.Name = "deletA";
            this.deletA.Size = new System.Drawing.Size(75, 23);
            this.deletA.TabIndex = 5;
            this.deletA.Text = "حذف العنصر";
            this.deletA.UseVisualStyleBackColor = true;
            this.deletA.Click += new System.EventHandler(this.deletA_Click);
            this.deletA.MouseEnter += new System.EventHandler(this.deletA_MouseEnter);
            this.deletA.MouseHover += new System.EventHandler(this.deletA_MouseHover);
            // 
            // showA
            // 
            this.showA.Location = new System.Drawing.Point(74, 105);
            this.showA.Name = "showA";
            this.showA.Size = new System.Drawing.Size(75, 23);
            this.showA.TabIndex = 6;
            this.showA.Text = "عرض العناصر";
            this.showA.UseVisualStyleBackColor = true;
            this.showA.Click += new System.EventHandler(this.showA_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(178, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // sumA
            // 
            this.sumA.Location = new System.Drawing.Point(328, 302);
            this.sumA.Name = "sumA";
            this.sumA.Size = new System.Drawing.Size(75, 23);
            this.sumA.TabIndex = 9;
            this.sumA.Text = "المجموع";
            this.sumA.UseVisualStyleBackColor = true;
            this.sumA.Click += new System.EventHandler(this.sumA_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(211, 302);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "clos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.sumA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.showA);
            this.Controls.Add(this.deletA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addA);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Button addA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deletA;
        private System.Windows.Forms.Button showA;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sumA;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}

