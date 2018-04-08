namespace CrypToolClone
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
            this.tabcPlayfair = new System.Windows.Forms.TabControl();
            this.tabPlayfair = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbKeyPlayfair = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbPlayfair6x6 = new System.Windows.Forms.RadioButton();
            this.rbPlayfair5x5 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDecryptPlayfair = new System.Windows.Forms.Button();
            this.btnEncryptPlayfair = new System.Windows.Forms.Button();
            this.tbOutputPlayfair = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInputPlayfair = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tlpPlayfair = new System.Windows.Forms.TableLayoutPanel();
            this.tabVigenre = new System.Windows.Forms.TabPage();
            this.tabHill = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tlpNumber = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAlphabet = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbHill5x5 = new System.Windows.Forms.RadioButton();
            this.rbHill4x4 = new System.Windows.Forms.RadioButton();
            this.rbHill3x3 = new System.Windows.Forms.RadioButton();
            this.rbHill2x2 = new System.Windows.Forms.RadioButton();
            this.rbHill1x1 = new System.Windows.Forms.RadioButton();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.labelCachnhap = new System.Windows.Forms.Label();
            this.numericFirst = new System.Windows.Forms.NumericUpDown();
            this.labelz = new System.Windows.Forms.Label();
            this.panelCachnhap = new System.Windows.Forms.Panel();
            this.rbHillNumber = new System.Windows.Forms.RadioButton();
            this.rbHillAlphabet = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDecryptHill = new System.Windows.Forms.Button();
            this.btnEncryptHill = new System.Windows.Forms.Button();
            this.tbOutputHill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInputHill = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabcPlayfair.SuspendLayout();
            this.tabPlayfair.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabHill.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFirst)).BeginInit();
            this.panelCachnhap.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcPlayfair
            // 
            this.tabcPlayfair.Controls.Add(this.tabPlayfair);
            this.tabcPlayfair.Controls.Add(this.tabVigenre);
            this.tabcPlayfair.Controls.Add(this.tabHill);
            this.tabcPlayfair.Location = new System.Drawing.Point(18, 43);
            this.tabcPlayfair.Name = "tabcPlayfair";
            this.tabcPlayfair.SelectedIndex = 0;
            this.tabcPlayfair.Size = new System.Drawing.Size(1012, 876);
            this.tabcPlayfair.TabIndex = 0;
            this.tabcPlayfair.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPlayfair
            // 
            this.tabPlayfair.Controls.Add(this.panel3);
            this.tabPlayfair.Controls.Add(this.panel1);
            this.tabPlayfair.Controls.Add(this.groupBox1);
            this.tabPlayfair.Location = new System.Drawing.Point(8, 39);
            this.tabPlayfair.Name = "tabPlayfair";
            this.tabPlayfair.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayfair.Size = new System.Drawing.Size(996, 829);
            this.tabPlayfair.TabIndex = 0;
            this.tabPlayfair.Text = "Playfair";
            this.tabPlayfair.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.tbKeyPlayfair);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(31, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 388);
            this.panel3.TabIndex = 62;
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(332, 17);
            this.textBox2.MaxLength = 1;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 31);
            this.textBox2.TabIndex = 62;
            this.textBox2.Text = "X";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbKeyPlayfair
            // 
            this.tbKeyPlayfair.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbKeyPlayfair.Location = new System.Drawing.Point(22, 304);
            this.tbKeyPlayfair.Name = "tbKeyPlayfair";
            this.tbKeyPlayfair.Size = new System.Drawing.Size(378, 31);
            this.tbKeyPlayfair.TabIndex = 7;
            this.tbKeyPlayfair.TextChanged += new System.EventHandler(this.tbKeyPlayfair_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 17);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(301, 29);
            this.checkBox1.TabIndex = 61;
            this.checkBox1.Text = "Separate duplicate letters :";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Playfair key :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbPlayfair6x6);
            this.panel2.Controls.Add(this.rbPlayfair5x5);
            this.panel2.Location = new System.Drawing.Point(22, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 104);
            this.panel2.TabIndex = 60;
            // 
            // rbPlayfair6x6
            // 
            this.rbPlayfair6x6.AutoSize = true;
            this.rbPlayfair6x6.Location = new System.Drawing.Point(22, 56);
            this.rbPlayfair6x6.Margin = new System.Windows.Forms.Padding(6);
            this.rbPlayfair6x6.Name = "rbPlayfair6x6";
            this.rbPlayfair6x6.Size = new System.Drawing.Size(142, 29);
            this.rbPlayfair6x6.TabIndex = 56;
            this.rbPlayfair6x6.TabStop = true;
            this.rbPlayfair6x6.Text = "6x6 matrix";
            this.rbPlayfair6x6.UseVisualStyleBackColor = true;
            // 
            // rbPlayfair5x5
            // 
            this.rbPlayfair5x5.AutoSize = true;
            this.rbPlayfair5x5.Checked = true;
            this.rbPlayfair5x5.Location = new System.Drawing.Point(22, 10);
            this.rbPlayfair5x5.Margin = new System.Windows.Forms.Padding(6);
            this.rbPlayfair5x5.Name = "rbPlayfair5x5";
            this.rbPlayfair5x5.Size = new System.Drawing.Size(142, 29);
            this.rbPlayfair5x5.TabIndex = 55;
            this.rbPlayfair5x5.TabStop = true;
            this.rbPlayfair5x5.Text = "5x5 matrix";
            this.rbPlayfair5x5.UseVisualStyleBackColor = true;
            this.rbPlayfair5x5.CheckedChanged += new System.EventHandler(this.rbPlayfair5x5_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDecryptPlayfair);
            this.panel1.Controls.Add(this.btnEncryptPlayfair);
            this.panel1.Controls.Add(this.tbOutputPlayfair);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbInputPlayfair);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 395);
            this.panel1.TabIndex = 3;
            // 
            // btnDecryptPlayfair
            // 
            this.btnDecryptPlayfair.Location = new System.Drawing.Point(478, 172);
            this.btnDecryptPlayfair.Name = "btnDecryptPlayfair";
            this.btnDecryptPlayfair.Size = new System.Drawing.Size(155, 47);
            this.btnDecryptPlayfair.TabIndex = 6;
            this.btnDecryptPlayfair.Text = "Decrypt";
            this.btnDecryptPlayfair.UseVisualStyleBackColor = true;
            this.btnDecryptPlayfair.Click += new System.EventHandler(this.btnDecryptPlayfair_Click);
            // 
            // btnEncryptPlayfair
            // 
            this.btnEncryptPlayfair.Location = new System.Drawing.Point(171, 172);
            this.btnEncryptPlayfair.Name = "btnEncryptPlayfair";
            this.btnEncryptPlayfair.Size = new System.Drawing.Size(155, 47);
            this.btnEncryptPlayfair.TabIndex = 5;
            this.btnEncryptPlayfair.Text = "Encrypt";
            this.btnEncryptPlayfair.UseVisualStyleBackColor = true;
            this.btnEncryptPlayfair.Click += new System.EventHandler(this.btnEncryptPlayfair_Click);
            // 
            // tbOutputPlayfair
            // 
            this.tbOutputPlayfair.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbOutputPlayfair.Location = new System.Drawing.Point(23, 266);
            this.tbOutputPlayfair.Multiline = true;
            this.tbOutputPlayfair.Name = "tbOutputPlayfair";
            this.tbOutputPlayfair.Size = new System.Drawing.Size(942, 97);
            this.tbOutputPlayfair.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output :";
            // 
            // tbInputPlayfair
            // 
            this.tbInputPlayfair.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbInputPlayfair.Location = new System.Drawing.Point(23, 58);
            this.tbInputPlayfair.Multiline = true;
            this.tbInputPlayfair.Name = "tbInputPlayfair";
            this.tbInputPlayfair.Size = new System.Drawing.Size(942, 97);
            this.tbInputPlayfair.TabIndex = 1;
            this.tbInputPlayfair.TextChanged += new System.EventHandler(this.tbInputPlayfair_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tlpPlayfair);
            this.groupBox1.Location = new System.Drawing.Point(518, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key matrix";
            // 
            // tlpPlayfair
            // 
            this.tlpPlayfair.ColumnCount = 6;
            this.tlpPlayfair.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPlayfair.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPlayfair.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPlayfair.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPlayfair.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPlayfair.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPlayfair.Location = new System.Drawing.Point(27, 36);
            this.tlpPlayfair.Margin = new System.Windows.Forms.Padding(6);
            this.tlpPlayfair.Name = "tlpPlayfair";
            this.tlpPlayfair.RowCount = 6;
            this.tlpPlayfair.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlayfair.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlayfair.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlayfair.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlayfair.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlayfair.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlayfair.Size = new System.Drawing.Size(419, 342);
            this.tlpPlayfair.TabIndex = 0;
            // 
            // tabVigenre
            // 
            this.tabVigenre.Location = new System.Drawing.Point(8, 39);
            this.tabVigenre.Name = "tabVigenre";
            this.tabVigenre.Padding = new System.Windows.Forms.Padding(3);
            this.tabVigenre.Size = new System.Drawing.Size(996, 829);
            this.tabVigenre.TabIndex = 1;
            this.tabVigenre.Text = "Vigenre";
            this.tabVigenre.UseVisualStyleBackColor = true;
            // 
            // tabHill
            // 
            this.tabHill.Controls.Add(this.groupBox3);
            this.tabHill.Controls.Add(this.groupBox2);
            this.tabHill.Controls.Add(this.buttonRandom);
            this.tabHill.Controls.Add(this.labelCachnhap);
            this.tabHill.Controls.Add(this.numericFirst);
            this.tabHill.Controls.Add(this.labelz);
            this.tabHill.Controls.Add(this.panelCachnhap);
            this.tabHill.Controls.Add(this.panel4);
            this.tabHill.Location = new System.Drawing.Point(8, 39);
            this.tabHill.Name = "tabHill";
            this.tabHill.Size = new System.Drawing.Size(996, 829);
            this.tabHill.TabIndex = 2;
            this.tabHill.Text = "Hill";
            this.tabHill.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tlpNumber);
            this.groupBox3.Controls.Add(this.tlpAlphabet);
            this.groupBox3.Location = new System.Drawing.Point(11, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(773, 319);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Key matrix";
            // 
            // tlpNumber
            // 
            this.tlpNumber.ColumnCount = 6;
            this.tlpNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpNumber.Location = new System.Drawing.Point(397, 25);
            this.tlpNumber.Margin = new System.Windows.Forms.Padding(6);
            this.tlpNumber.Name = "tlpNumber";
            this.tlpNumber.RowCount = 6;
            this.tlpNumber.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNumber.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNumber.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNumber.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNumber.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNumber.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNumber.Size = new System.Drawing.Size(367, 277);
            this.tlpNumber.TabIndex = 1;
            // 
            // tlpAlphabet
            // 
            this.tlpAlphabet.ColumnCount = 6;
            this.tlpAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAlphabet.Location = new System.Drawing.Point(9, 25);
            this.tlpAlphabet.Margin = new System.Windows.Forms.Padding(6);
            this.tlpAlphabet.Name = "tlpAlphabet";
            this.tlpAlphabet.RowCount = 6;
            this.tlpAlphabet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAlphabet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAlphabet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAlphabet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAlphabet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAlphabet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAlphabet.Size = new System.Drawing.Size(367, 277);
            this.tlpAlphabet.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbHill5x5);
            this.groupBox2.Controls.Add(this.rbHill4x4);
            this.groupBox2.Controls.Add(this.rbHill3x3);
            this.groupBox2.Controls.Add(this.rbHill2x2);
            this.groupBox2.Controls.Add(this.rbHill1x1);
            this.groupBox2.Location = new System.Drawing.Point(805, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 263);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size of Matrix";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbHill5x5
            // 
            this.rbHill5x5.AutoSize = true;
            this.rbHill5x5.Location = new System.Drawing.Point(40, 212);
            this.rbHill5x5.Name = "rbHill5x5";
            this.rbHill5x5.Size = new System.Drawing.Size(90, 29);
            this.rbHill5x5.TabIndex = 69;
            this.rbHill5x5.Text = "5 x 5";
            this.rbHill5x5.UseVisualStyleBackColor = true;
            this.rbHill5x5.CheckedChanged += new System.EventHandler(this.rbHill_CheckedChanged);
            // 
            // rbHill4x4
            // 
            this.rbHill4x4.AutoSize = true;
            this.rbHill4x4.Location = new System.Drawing.Point(40, 167);
            this.rbHill4x4.Name = "rbHill4x4";
            this.rbHill4x4.Size = new System.Drawing.Size(90, 29);
            this.rbHill4x4.TabIndex = 68;
            this.rbHill4x4.Text = "4 x 4";
            this.rbHill4x4.UseVisualStyleBackColor = true;
            this.rbHill4x4.CheckedChanged += new System.EventHandler(this.rbHill_CheckedChanged);
            // 
            // rbHill3x3
            // 
            this.rbHill3x3.AutoSize = true;
            this.rbHill3x3.Location = new System.Drawing.Point(40, 124);
            this.rbHill3x3.Name = "rbHill3x3";
            this.rbHill3x3.Size = new System.Drawing.Size(90, 29);
            this.rbHill3x3.TabIndex = 67;
            this.rbHill3x3.Text = "3 x 3";
            this.rbHill3x3.UseVisualStyleBackColor = true;
            this.rbHill3x3.CheckedChanged += new System.EventHandler(this.rbHill_CheckedChanged);
            // 
            // rbHill2x2
            // 
            this.rbHill2x2.AutoSize = true;
            this.rbHill2x2.Location = new System.Drawing.Point(40, 84);
            this.rbHill2x2.Name = "rbHill2x2";
            this.rbHill2x2.Size = new System.Drawing.Size(90, 29);
            this.rbHill2x2.TabIndex = 66;
            this.rbHill2x2.Text = "2 x 2";
            this.rbHill2x2.UseVisualStyleBackColor = true;
            this.rbHill2x2.CheckedChanged += new System.EventHandler(this.rbHill_CheckedChanged);
            // 
            // rbHill1x1
            // 
            this.rbHill1x1.AutoSize = true;
            this.rbHill1x1.Checked = true;
            this.rbHill1x1.Location = new System.Drawing.Point(40, 44);
            this.rbHill1x1.Name = "rbHill1x1";
            this.rbHill1x1.Size = new System.Drawing.Size(90, 29);
            this.rbHill1x1.TabIndex = 65;
            this.rbHill1x1.TabStop = true;
            this.rbHill1x1.Text = "1 x 1";
            this.rbHill1x1.UseVisualStyleBackColor = true;
            this.rbHill1x1.CheckedChanged += new System.EventHandler(this.rbHill_CheckedChanged);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(557, 413);
            this.buttonRandom.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(150, 44);
            this.buttonRandom.TabIndex = 64;
            this.buttonRandom.Text = "Random key";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // labelCachnhap
            // 
            this.labelCachnhap.AutoSize = true;
            this.labelCachnhap.Location = new System.Drawing.Point(30, 314);
            this.labelCachnhap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCachnhap.Name = "labelCachnhap";
            this.labelCachnhap.Size = new System.Drawing.Size(0, 25);
            this.labelCachnhap.TabIndex = 48;
            // 
            // numericFirst
            // 
            this.numericFirst.Location = new System.Drawing.Point(421, 421);
            this.numericFirst.Margin = new System.Windows.Forms.Padding(6);
            this.numericFirst.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFirst.Name = "numericFirst";
            this.numericFirst.Size = new System.Drawing.Size(62, 31);
            this.numericFirst.TabIndex = 51;
            this.numericFirst.ValueChanged += new System.EventHandler(this.numericFirst_ValueChanged);
            // 
            // labelz
            // 
            this.labelz.AutoSize = true;
            this.labelz.Location = new System.Drawing.Point(48, 423);
            this.labelz.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelz.Name = "labelz";
            this.labelz.Size = new System.Drawing.Size(361, 25);
            this.labelz.TabIndex = 50;
            this.labelz.Text = "Value of the first Alphabet charactor:";
            // 
            // panelCachnhap
            // 
            this.panelCachnhap.Controls.Add(this.rbHillNumber);
            this.panelCachnhap.Controls.Add(this.rbHillAlphabet);
            this.panelCachnhap.Location = new System.Drawing.Point(27, 334);
            this.panelCachnhap.Margin = new System.Windows.Forms.Padding(6);
            this.panelCachnhap.Name = "panelCachnhap";
            this.panelCachnhap.Size = new System.Drawing.Size(764, 44);
            this.panelCachnhap.TabIndex = 49;
            // 
            // rbHillNumber
            // 
            this.rbHillNumber.AutoSize = true;
            this.rbHillNumber.Location = new System.Drawing.Point(394, 6);
            this.rbHillNumber.Margin = new System.Windows.Forms.Padding(6);
            this.rbHillNumber.Name = "rbHillNumber";
            this.rbHillNumber.Size = new System.Drawing.Size(187, 29);
            this.rbHillNumber.TabIndex = 2;
            this.rbHillNumber.Text = "Number values";
            this.rbHillNumber.UseVisualStyleBackColor = true;
            // 
            // rbHillAlphabet
            // 
            this.rbHillAlphabet.AutoSize = true;
            this.rbHillAlphabet.Checked = true;
            this.rbHillAlphabet.Location = new System.Drawing.Point(18, 9);
            this.rbHillAlphabet.Margin = new System.Windows.Forms.Padding(6);
            this.rbHillAlphabet.Name = "rbHillAlphabet";
            this.rbHillAlphabet.Size = new System.Drawing.Size(228, 29);
            this.rbHillAlphabet.TabIndex = 1;
            this.rbHillAlphabet.TabStop = true;
            this.rbHillAlphabet.Text = "Alphabet Charactor";
            this.rbHillAlphabet.UseVisualStyleBackColor = true;
            this.rbHillAlphabet.CheckedChanged += new System.EventHandler(this.rbHillAlphabet_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnDecryptHill);
            this.panel4.Controls.Add(this.btnEncryptHill);
            this.panel4.Controls.Add(this.tbOutputHill);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.tbInputHill);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(11, 480);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(982, 339);
            this.panel4.TabIndex = 4;
            // 
            // btnDecryptHill
            // 
            this.btnDecryptHill.Location = new System.Drawing.Point(478, 154);
            this.btnDecryptHill.Name = "btnDecryptHill";
            this.btnDecryptHill.Size = new System.Drawing.Size(155, 47);
            this.btnDecryptHill.TabIndex = 6;
            this.btnDecryptHill.Text = "Decrypt";
            this.btnDecryptHill.UseVisualStyleBackColor = true;
            this.btnDecryptHill.Click += new System.EventHandler(this.btnDecryptHill_Click);
            // 
            // btnEncryptHill
            // 
            this.btnEncryptHill.Location = new System.Drawing.Point(161, 154);
            this.btnEncryptHill.Name = "btnEncryptHill";
            this.btnEncryptHill.Size = new System.Drawing.Size(155, 47);
            this.btnEncryptHill.TabIndex = 5;
            this.btnEncryptHill.Text = "Encrypt";
            this.btnEncryptHill.UseVisualStyleBackColor = true;
            this.btnEncryptHill.Click += new System.EventHandler(this.EncryptHill_Click);
            // 
            // tbOutputHill
            // 
            this.tbOutputHill.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbOutputHill.Location = new System.Drawing.Point(14, 240);
            this.tbOutputHill.Multiline = true;
            this.tbOutputHill.Name = "tbOutputHill";
            this.tbOutputHill.Size = new System.Drawing.Size(948, 92);
            this.tbOutputHill.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Output :";
            // 
            // tbInputHill
            // 
            this.tbInputHill.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbInputHill.Location = new System.Drawing.Point(14, 50);
            this.tbInputHill.Multiline = true;
            this.tbInputHill.Name = "tbInputHill";
            this.tbInputHill.Size = new System.Drawing.Size(948, 84);
            this.tbInputHill.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Input :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.openToolStripMenuItem.Text = "Import";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1042, 1129);
            this.Controls.Add(this.tabcPlayfair);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CryptTool -v Clone";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabcPlayfair.ResumeLayout(false);
            this.tabPlayfair.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabHill.ResumeLayout(false);
            this.tabHill.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFirst)).EndInit();
            this.panelCachnhap.ResumeLayout(false);
            this.panelCachnhap.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabcPlayfair;
        private System.Windows.Forms.TabPage tabPlayfair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDecryptPlayfair;
        private System.Windows.Forms.Button btnEncryptPlayfair;
        private System.Windows.Forms.TextBox tbOutputPlayfair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInputPlayfair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabVigenre;
        private System.Windows.Forms.TabPage tabHill;
        private System.Windows.Forms.TableLayoutPanel tlpPlayfair;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbKeyPlayfair;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbPlayfair6x6;
        private System.Windows.Forms.RadioButton rbPlayfair5x5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbHill5x5;
        private System.Windows.Forms.RadioButton rbHill4x4;
        private System.Windows.Forms.RadioButton rbHill3x3;
        private System.Windows.Forms.RadioButton rbHill2x2;
        private System.Windows.Forms.RadioButton rbHill1x1;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Label labelCachnhap;
        private System.Windows.Forms.NumericUpDown numericFirst;
        private System.Windows.Forms.Label labelz;
        private System.Windows.Forms.Panel panelCachnhap;
        private System.Windows.Forms.RadioButton rbHillNumber;
        private System.Windows.Forms.RadioButton rbHillAlphabet;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDecryptHill;
        private System.Windows.Forms.Button btnEncryptHill;
        private System.Windows.Forms.TextBox tbOutputHill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInputHill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tlpNumber;
        private System.Windows.Forms.TableLayoutPanel tlpAlphabet;
    }
}

