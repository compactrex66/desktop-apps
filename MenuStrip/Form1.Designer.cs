namespace MenuStrip
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.obliczeniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.energiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potencjalnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kinetycznaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruchJednostajnyProstoliniowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prędkośćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drogaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obliczeniaToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(258, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // obliczeniaToolStripMenuItem
            // 
            this.obliczeniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.energiaToolStripMenuItem,
            this.ruchJednostajnyProstoliniowyToolStripMenuItem});
            this.obliczeniaToolStripMenuItem.Name = "obliczeniaToolStripMenuItem";
            this.obliczeniaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.obliczeniaToolStripMenuItem.Text = "Obliczenia";
            // 
            // energiaToolStripMenuItem
            // 
            this.energiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.potencjalnaToolStripMenuItem,
            this.kinetycznaToolStripMenuItem});
            this.energiaToolStripMenuItem.Name = "energiaToolStripMenuItem";
            this.energiaToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.energiaToolStripMenuItem.Text = "Energia";
            // 
            // potencjalnaToolStripMenuItem
            // 
            this.potencjalnaToolStripMenuItem.Name = "potencjalnaToolStripMenuItem";
            this.potencjalnaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.potencjalnaToolStripMenuItem.Text = "Potencjalna";
            this.potencjalnaToolStripMenuItem.Click += new System.EventHandler(this.potencjalnaToolStripMenuItem_Click);
            // 
            // kinetycznaToolStripMenuItem
            // 
            this.kinetycznaToolStripMenuItem.Name = "kinetycznaToolStripMenuItem";
            this.kinetycznaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.kinetycznaToolStripMenuItem.Text = "Kinetyczna";
            this.kinetycznaToolStripMenuItem.Click += new System.EventHandler(this.kinetycznaToolStripMenuItem_Click);
            // 
            // ruchJednostajnyProstoliniowyToolStripMenuItem
            // 
            this.ruchJednostajnyProstoliniowyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prędkośćToolStripMenuItem,
            this.drogaToolStripMenuItem,
            this.czasToolStripMenuItem});
            this.ruchJednostajnyProstoliniowyToolStripMenuItem.Name = "ruchJednostajnyProstoliniowyToolStripMenuItem";
            this.ruchJednostajnyProstoliniowyToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.ruchJednostajnyProstoliniowyToolStripMenuItem.Text = "Ruch jednostajny prostoliniowy";
            // 
            // prędkośćToolStripMenuItem
            // 
            this.prędkośćToolStripMenuItem.Name = "prędkośćToolStripMenuItem";
            this.prędkośćToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.prędkośćToolStripMenuItem.Text = "Prędkość";
            this.prędkośćToolStripMenuItem.Click += new System.EventHandler(this.prędkośćToolStripMenuItem_Click);
            // 
            // drogaToolStripMenuItem
            // 
            this.drogaToolStripMenuItem.Name = "drogaToolStripMenuItem";
            this.drogaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.drogaToolStripMenuItem.Text = "Droga";
            this.drogaToolStripMenuItem.Click += new System.EventHandler(this.drogaToolStripMenuItem_Click);
            // 
            // czasToolStripMenuItem
            // 
            this.czasToolStripMenuItem.Name = "czasToolStripMenuItem";
            this.czasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.czasToolStripMenuItem.Text = "Czas";
            this.czasToolStripMenuItem.Click += new System.EventHandler(this.czasToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masa";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wysokość";
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 325);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(245, 50);
            this.textBox3.TabIndex = 6;
            this.textBox3.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Energia kinetyczna";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(127, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Energia potencjalna";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(7, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 50);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Pęd",
            "Prędkość",
            "Energia kinetyczna",
            "Energia Potencjalna",
            "Częstotliwość",
            "Siła"});
            this.listBox1.Location = new System.Drawing.Point(7, 129);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(245, 43);
            this.listBox1.TabIndex = 10;
            this.listBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 110);
            this.label3.MaximumSize = new System.Drawing.Size(250, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "J",
            "m/s",
            "f",
            "N",
            "Hz",
            "W",
            "F"});
            this.comboBox1.Location = new System.Drawing.Point(134, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Która to jednostka siły: ";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Zaznacz prawdziwe informacje";
            this.label5.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(7, 222);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(246, 31);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Im większa prędkość ciała tym większa energia potencjalna";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(7, 259);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(246, 31);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Im wyżej od podłoża znajduje się ciało tym większa energia potencjalna";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 381);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Fizyka";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obliczeniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem energiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potencjalnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kinetycznaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruchJednostajnyProstoliniowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prędkośćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drogaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

