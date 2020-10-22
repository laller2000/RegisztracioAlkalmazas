namespace RegisztracioAlkalmazas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radioButton1_F = new System.Windows.Forms.RadioButton();
            this.radioButton2_N = new System.Windows.Forms.RadioButton();
            this.listBox1_Kedvenchobbi = new System.Windows.Forms.ListBox();
            this.button_Hozzaad = new System.Windows.Forms.Button();
            this.button2_Mentes = new System.Windows.Forms.Button();
            this.button3_Beolvas = new System.Windows.Forms.Button();
            this.textBox1_Nev = new System.Windows.Forms.TextBox();
            this.textBox2_Szuldatum = new System.Windows.Forms.TextBox();
            this.textBox3_ujhobbi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szül.dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kedvenc hobbi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "új hobbi:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Szövegfájl (*.txt)|*.txt|Minden (*.*)|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "Szövegfájl (*.txt)|*.txt|Minden (*.*)|*.*";
            // 
            // radioButton1_F
            // 
            this.radioButton1_F.AutoSize = true;
            this.radioButton1_F.Location = new System.Drawing.Point(345, 107);
            this.radioButton1_F.Name = "radioButton1_F";
            this.radioButton1_F.Size = new System.Drawing.Size(37, 21);
            this.radioButton1_F.TabIndex = 5;
            this.radioButton1_F.TabStop = true;
            this.radioButton1_F.Text = "F";
            this.radioButton1_F.UseVisualStyleBackColor = true;
            // 
            // radioButton2_N
            // 
            this.radioButton2_N.AutoSize = true;
            this.radioButton2_N.Location = new System.Drawing.Point(406, 107);
            this.radioButton2_N.Name = "radioButton2_N";
            this.radioButton2_N.Size = new System.Drawing.Size(39, 21);
            this.radioButton2_N.TabIndex = 6;
            this.radioButton2_N.TabStop = true;
            this.radioButton2_N.Text = "N";
            this.radioButton2_N.UseVisualStyleBackColor = true;
            // 
            // listBox1_Kedvenchobbi
            // 
            this.listBox1_Kedvenchobbi.FormattingEnabled = true;
            this.listBox1_Kedvenchobbi.ItemHeight = 16;
            this.listBox1_Kedvenchobbi.Items.AddRange(new object[] {
            "Uszás",
            "Horgászat",
            "Futás"});
            this.listBox1_Kedvenchobbi.Location = new System.Drawing.Point(472, 48);
            this.listBox1_Kedvenchobbi.Name = "listBox1_Kedvenchobbi";
            this.listBox1_Kedvenchobbi.Size = new System.Drawing.Size(120, 84);
            this.listBox1_Kedvenchobbi.TabIndex = 7;
            // 
            // button_Hozzaad
            // 
            this.button_Hozzaad.Location = new System.Drawing.Point(509, 203);
            this.button_Hozzaad.Name = "button_Hozzaad";
            this.button_Hozzaad.Size = new System.Drawing.Size(75, 23);
            this.button_Hozzaad.TabIndex = 8;
            this.button_Hozzaad.Text = "Hozzáad";
            this.button_Hozzaad.UseVisualStyleBackColor = true;
            this.button_Hozzaad.Click += new System.EventHandler(this.button_Hozzaad_Click);
            // 
            // button2_Mentes
            // 
            this.button2_Mentes.Location = new System.Drawing.Point(448, 349);
            this.button2_Mentes.Name = "button2_Mentes";
            this.button2_Mentes.Size = new System.Drawing.Size(75, 23);
            this.button2_Mentes.TabIndex = 9;
            this.button2_Mentes.Text = "Mentés";
            this.button2_Mentes.UseVisualStyleBackColor = true;
            this.button2_Mentes.Click += new System.EventHandler(this.button2_Mentes_Click);
            // 
            // button3_Beolvas
            // 
            this.button3_Beolvas.Location = new System.Drawing.Point(548, 349);
            this.button3_Beolvas.Name = "button3_Beolvas";
            this.button3_Beolvas.Size = new System.Drawing.Size(75, 23);
            this.button3_Beolvas.TabIndex = 10;
            this.button3_Beolvas.Text = "Beolvas";
            this.button3_Beolvas.UseVisualStyleBackColor = true;
            this.button3_Beolvas.Click += new System.EventHandler(this.button3_Beolvas_Click);
            // 
            // textBox1_Nev
            // 
            this.textBox1_Nev.Location = new System.Drawing.Point(345, 29);
            this.textBox1_Nev.Name = "textBox1_Nev";
            this.textBox1_Nev.Size = new System.Drawing.Size(100, 22);
            this.textBox1_Nev.TabIndex = 11;
            // 
            // textBox2_Szuldatum
            // 
            this.textBox2_Szuldatum.Location = new System.Drawing.Point(345, 66);
            this.textBox2_Szuldatum.Name = "textBox2_Szuldatum";
            this.textBox2_Szuldatum.Size = new System.Drawing.Size(100, 22);
            this.textBox2_Szuldatum.TabIndex = 12;
            // 
            // textBox3_ujhobbi
            // 
            this.textBox3_ujhobbi.Location = new System.Drawing.Point(503, 154);
            this.textBox3_ujhobbi.Name = "textBox3_ujhobbi";
            this.textBox3_ujhobbi.Size = new System.Drawing.Size(100, 22);
            this.textBox3_ujhobbi.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 380);
            this.Controls.Add(this.textBox3_ujhobbi);
            this.Controls.Add(this.textBox2_Szuldatum);
            this.Controls.Add(this.textBox1_Nev);
            this.Controls.Add(this.button3_Beolvas);
            this.Controls.Add(this.button2_Mentes);
            this.Controls.Add(this.button_Hozzaad);
            this.Controls.Add(this.listBox1_Kedvenchobbi);
            this.Controls.Add(this.radioButton2_N);
            this.Controls.Add(this.radioButton1_F);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RegisztracioAlkalmazas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton radioButton1_F;
        private System.Windows.Forms.RadioButton radioButton2_N;
        private System.Windows.Forms.ListBox listBox1_Kedvenchobbi;
        private System.Windows.Forms.Button button_Hozzaad;
        private System.Windows.Forms.Button button2_Mentes;
        private System.Windows.Forms.Button button3_Beolvas;
        private System.Windows.Forms.TextBox textBox1_Nev;
        private System.Windows.Forms.TextBox textBox2_Szuldatum;
        private System.Windows.Forms.TextBox textBox3_ujhobbi;
    }
}

