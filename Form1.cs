using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrypToolClone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabPlayfair.Focus())
            {
                ResetPlayfair();
            }else if (tabHill.Focus())
            {
                ResetMatrixHill();
            }
            else if (tabVigenre.Focus())
            {
                ResetVigenra();
            }

        }

        private void ResetVigenra()
        {
            tbKeyVigenre.Clear();
            tbInputVigenre.Clear();
            tbOutputVigenre.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                if (tabPlayfair.Focus())
                    tbInputPlayfair.Text = sr.ReadToEnd();
                else if (tabHill.Focus())
                    tbInputHill.Text = sr.ReadToEnd();
                else if (tabVigenre.Focus())
                    tbInputVigenre.Text = sr.ReadToEnd();
                sr.Close();
                fs.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.DefaultExt = "txt";
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                if (tabPlayfair.Focus())
                    sw.Write("Plaintext : " + tbInputPlayfair.Text + "\r\n" + "Key:" + tbKeyPlayfair.Text + "\r\n" + "Ciphertext : " + tbOutputPlayfair.Text);
                else if (tabHill.Focus())
                    sw.Write("Plaintext : " + tbInputHill.Text + "\r\n" + "Key:" +"\r\n"+ hill.Print() + "\r\n" + "Value of the first Alphabet charactor: "+numericFirst.Value+"\r\n"+ "Ciphertext : " + tbOutputHill.Text);
                else if (tabVigenre.Focus())
                    sw.Write("Plaintext : " + tbInputVigenre.Text + "\r\n" + "Key:" + tbKeyVigenre.Text + "\r\n" + "Ciphertext : " + tbOutputVigenre.Text);

                sw.Close();
                fs.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        #region Playfair
        Playfair playfair = new Playfair();
     

        private void rbPlayfair5x5_CheckedChanged(object sender, EventArgs e)
        {
            tbKeyPlayfair.Clear();
            tlpPlayfair.Visible = false;
            if (rbPlayfair5x5.Checked)
            {
                SetMatrixPlayfair(5);

            }
            else
                SetMatrixPlayfair(6);
            tlpPlayfair.Visible = true;
            if (tbOutputPlayfair.TextLength > 0)
                tbOutputPlayfair.Clear();
        }
        private void tbInputPlayfair_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetMatrixPlayfair(5);
            SetMatrixHill();
        }
        private void btnEncryptPlayfair_Click(object sender, EventArgs e)
        {
            tbInputPlayfair.Text = tbInputPlayfair.Text.Replace(" ", "");
            if (playfair.N == 5)
                tbInputPlayfair.Text = tbInputPlayfair.Text.Replace("J", "I");

            if (checkBox1.Checked)
            {
                for (int i = 0; i < tbInputPlayfair.TextLength - 1; i = i + 2)
                {
                    if (tbInputPlayfair.Text[i] == tbInputPlayfair.Text[i + 1])
                    {
                        tbInputPlayfair.Text = tbInputPlayfair.Text.Insert(i + 1, textBox2.Text);
                    }
                }
            }
            if (tbInputPlayfair.Text.Length % 2 != 0)
                tbInputPlayfair.Text += "X";
            tbOutputPlayfair.Text = playfair.Encrypt(tbInputPlayfair.Text);

            for (int i = 0; i < tbInputPlayfair.TextLength - 1; i = i + 2)
                tbInputPlayfair.Text = tbInputPlayfair.Text.Insert(i++ + 2, " ");

            for (int i = 0; i < tbOutputPlayfair.TextLength - 1; i = i + 2)
                tbOutputPlayfair.Text = tbOutputPlayfair.Text.Insert(i++ + 2, " ");
        }
        private void btnDecryptPlayfair_Click(object sender, EventArgs e)
        {
            tbInputPlayfair.Text = tbInputPlayfair.Text.Replace(" ", "");
            if (playfair.N == 5)
                tbInputPlayfair.Text = tbInputPlayfair.Text.Replace("J", "I");

            if (checkBox1.Checked)
            {
                for (int i = 0; i < tbInputPlayfair.TextLength - 1; i = i + 2)
                {
                    if (tbInputPlayfair.Text[i] == tbInputPlayfair.Text[i + 1])
                    {
                        tbInputPlayfair.Text = tbInputPlayfair.Text.Insert(i + 1, textBox2.Text);
                    }
                }
            }
            if (tbInputPlayfair.Text.Length % 2 != 0)
                tbInputPlayfair.Text += "X";
            tbOutputPlayfair.Text = playfair.Decrypt(tbInputPlayfair.Text);

            for (int i = 0; i < tbInputPlayfair.TextLength - 1; i = i + 2)
                tbInputPlayfair.Text = tbInputPlayfair.Text.Insert(i++ + 2, " ");

            for (int i = 0; i < tbOutputPlayfair.TextLength - 1; i = i + 2)
                tbOutputPlayfair.Text = tbOutputPlayfair.Text.Insert(i++ + 2, " ");

        }
        //Default
        public void SetMatrixPlayfair(int n)
        {

            tlpPlayfair.Controls.Clear();
            playfair.N = n;
            playfair.setKey(playfair.getSrc());
            for (int j = 0; j < 6; j++)
                for (int i = 0; i < 6; i++)
                {
                    TextBox tb = new System.Windows.Forms.TextBox();
                    tb.Size = new System.Drawing.Size(25, 25);
                    tb.MaxLength = 1;
                    tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
                    tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    if (n == 5 && (i == 5 || j == 5))
                        tb.Text = "";
                    else
                        tb.Text = playfair.getkey()[j, i];
                    tb.BorderStyle = BorderStyle.Fixed3D;
                    tb.ReadOnly = true;
                    tlpPlayfair.Controls.Add(tb, i, j);

                }
        }
        private void tbKeyPlayfair_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[A-Z]*$");
            if (playfair.N == 6)
                regex = new Regex("^[A-Z0-9]*$");
            if (!regex.IsMatch(tbKeyPlayfair.Text))
            {
                MessageBox.Show("Key invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            playfair.CreateKey(tbKeyPlayfair.Text);
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                {
                    if (playfair.N == 5 && (i == 5 || j == 5))
                        tlpPlayfair.GetControlFromPosition(j, i).Text = "";
                    else
                        tlpPlayfair.GetControlFromPosition(j, i).Text = playfair.getkey()[i, j];
                }
            if (tbOutputPlayfair.TextLength > 0)
                tbOutputPlayfair.Clear();
        }
        private void ResetPlayfair()
        {
            checkBox1.Checked = false;
            rbPlayfair5x5.Checked = true;
            tbInputPlayfair.Clear();
            tbOutputPlayfair.Clear();
            tbKeyPlayfair.Clear();
        }
        #endregion
        #region Hill
        private int sizeMatrixHill = 1;
        private Hill hill = new Hill();
        private int[,] matriHill;
        private void rbHill_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHill1x1.Checked)
            {
                sizeMatrixHill = 1;
                UpdateMatrixHill();
            }
            else if (rbHill2x2.Checked)
            {
                sizeMatrixHill = 2;
                UpdateMatrixHill();
            }
            else if (rbHill3x3.Checked)
            {
                sizeMatrixHill = 3;
                UpdateMatrixHill();
            }
            else if (rbHill4x4.Checked)
            {
                sizeMatrixHill = 4;
                UpdateMatrixHill();
            }
            else if (rbHill5x5.Checked)
            {
                sizeMatrixHill = 5;
                UpdateMatrixHill();
            }
        }

        protected void TextAlphabetChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[A-Z]*$");
            if (!regex.IsMatch((sender as TextBox).Text))
            {
                MessageBox.Show("Key invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbHillAlphabet.Checked)
            {
                TableLayoutPanelCellPosition pos = tlpAlphabet.GetPositionFromControl((sender as Control));
                tlpNumber.GetControlFromPosition(pos.Column, pos.Row).Text = Hill.ConvertCharToNumber((sender as TextBox).Text, (int)numericFirst.Value);
            }
        }
        protected void TextNumberChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch((sender as TextBox).Text))
            {
                MessageBox.Show("Key invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rbHillNumber.Checked)
            {

                TableLayoutPanelCellPosition pos = tlpNumber.GetPositionFromControl((sender as Control));
                if ((sender as TextBox).Text.Equals("") || (sender as TextBox).Text.Equals(" "))
                    return;

                tlpAlphabet.GetControlFromPosition(pos.Column, pos.Row).Text = Hill.ConverNumberToChar((sender as TextBox).Text, (int)numericFirst.Value);
            }
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPlayfair.Focus())
                ResetPlayfair();
            if (tabHill.Focus())
                ResetMatrixHill();

        }

        private void ResetMatrixHill()
        {
            rbHillNumber.Checked = true ;
            rbHillAlphabet.Checked = true;
            tbInputHill.Clear();
            numericFirst.Value = 0;
        }
        private void UpdateMatrixHill()
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    TextBox currentTb = tlpAlphabet.GetControlFromPosition(j, i) as TextBox;
                    TextBox currentTb1 = tlpNumber.GetControlFromPosition(j, i) as TextBox;
                    //region matrix current
                    if (i < sizeMatrixHill && j < sizeMatrixHill)
                    {
                        if (rbHillAlphabet.Checked)
                        {
                            currentTb.ReadOnly = false;
                            currentTb.BackColor = Color.White;
                            currentTb1.BackColor = Color.FromArgb(255, 240, 240, 240);

                            currentTb1.ReadOnly = true;
                        }
                        else
                        {
                            currentTb1.ReadOnly = false;
                            currentTb1.BackColor = Color.White;
                            currentTb.BackColor = Color.FromArgb(255, 240, 240, 240);

                            currentTb.ReadOnly = true;
                        }

                    }
                    else
                    {
                        currentTb.BackColor = Color.FromArgb(255, 240, 240, 240);
                        currentTb1.BackColor = Color.FromArgb(255, 240, 240, 240);

                        currentTb.ReadOnly = true;

                        currentTb1.ReadOnly = true;

                        //tlpNumber.GetControlFromPosition(j, i).Text = a[i, j].ToString();
                    }
                    currentTb.Text = "";
                    currentTb1.Text = "";
                }
        }
        public void SetMatrixHill()
        {
            int n = 1;
            tlpAlphabet.Visible = false;
            tlpNumber.Visible = false;
            tlpAlphabet.Controls.Clear();
            tlpNumber.Controls.Clear();
            for (int j = 0; j < 5; j++)
                for (int i = 0; i < 5; i++)
                {
                    TextBox tb = new System.Windows.Forms.TextBox();
                    tb.Size = new System.Drawing.Size(20, 20);
                    tb.MaxLength = 1;
                    tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
                    tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    tb.Text = "";
                    tb.BorderStyle = BorderStyle.Fixed3D;

                    tb.TextChanged += new EventHandler(TextAlphabetChanged);

                    if (rbHillAlphabet.Checked && i < n && j < n)
                    {
                        tb.ReadOnly = false;
                        tb.BackColor = Color.White;
                    }
                    else
                        tb.ReadOnly = true;
                    tlpAlphabet.Controls.Add(tb, i, j);
                }
            for (int j = 0; j < 5; j++)
                for (int i = 0; i < 5; i++)
                {
                    TextBox tb = new System.Windows.Forms.TextBox();
                    tb.Size = new System.Drawing.Size(20, 20);
                    tb.MaxLength = 2;
                    tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
                    tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    if (rbHillNumber.Checked && i < n && j < n)
                    {
                        tb.ReadOnly = false;
                        tb.BackColor = Color.White;
                    }
                    else
                        tb.ReadOnly = true;
                    tb.TextChanged += new EventHandler(TextNumberChanged);
                    tb.BorderStyle = BorderStyle.Fixed3D;
                    tlpNumber.Controls.Add(tb, i, j);

                }
            tlpAlphabet.Visible = true;
            tlpNumber.Visible = true;
        }
        #endregion

        private void rbHillAlphabet_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMatrixHill();
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            rbHillNumber.Checked = true;
            Random RanDom = new Random();
            int k = (int)numericFirst.Value;
            int n = sizeMatrixHill;
            matriHill = new int[sizeMatrixHill, sizeMatrixHill];
            do
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        matriHill[i, j] = RanDom.Next(k, k + 25 + 1);
                    }
                hill.setMatrix(matriHill);

            } while (hill.Inverse() == null);

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    tlpNumber.GetControlFromPosition(j, i).Text = matriHill[i, j].ToString();
                }

        }

        private void numericFirst_ValueChanged(object sender, EventArgs e)
        {
            UpdateMatrixHill();
        }

        private void EncryptHill_Click(object sender, EventArgs e)
        {
            tbInputHill.Text = tbInputHill.Text.Replace(" ", "");
            if (tbInputHill.Text == "")
            {
                MessageBox.Show("Empty input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbInputHill.Focus();
                return;
            }
            matriHill = new int[sizeMatrixHill, sizeMatrixHill];
            for (int i = 0; i < sizeMatrixHill; i++)
                for (int j = 0; j < sizeMatrixHill; j++)
                {
                    if (tlpNumber.GetControlFromPosition(j, i).Text == "")
                    {
                        MessageBox.Show("Key invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    matriHill[i, j] = Int32.Parse(tlpNumber.GetControlFromPosition(j, i).Text);
                }
            hill.setMatrix(matriHill);

            if (tbInputHill.Text.Length % sizeMatrixHill != 0)
                tbInputHill.Text += "X";
            if (hill.Inverse() == null)
            {
                MessageBox.Show("Key invalid, matrix is not invertible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbOutputHill.Text = hill.Encrypt(tbInputHill.Text,(int) numericFirst.Value);
        }

        private void btnDecryptHill_Click(object sender, EventArgs e)
        {
            if (tbInputHill.Text == "")
            {
                MessageBox.Show("Empty input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbInputHill.Focus();
                return;
            }
            for (int i = 0; i < sizeMatrixHill; i++)
                for (int j = 0; j < sizeMatrixHill; j++)
                {
                    if (tlpNumber.GetControlFromPosition(j, i).Text == "")
                    {
                        MessageBox.Show("Key invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    matriHill[i, j] = Int32.Parse(tlpNumber.GetControlFromPosition(j, i).Text);
                }
            hill.setMatrix(matriHill);
            if (hill.Inverse() == null)
            {
                MessageBox.Show("Key invalid, matrix is not invertible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbOutputHill.Text = hill.Decrypt(tbInputHill.Text, (int)numericFirst.Value);
        }

        private void tbKeyVigenre_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[A-Z]*$");
            if (!regex.IsMatch(tbKeyVigenre.Text))
            {
                MessageBox.Show("Key invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        Vigenere vigenere = new Vigenere();
        private void tbInputVigenre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEncryptVigenre_Click(object sender, EventArgs e)
        {
            tbOutputVigenre.Clear();
            Regex regex = new Regex("^[A-Za-z]*$");
            if (!regex.IsMatch(tbInputVigenre.Text))
            {
                MessageBox.Show("Input invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbOutputVigenre.Text = vigenere.Encrypt(tbInputVigenre.Text, tbKeyVigenre.Text);
        }

        private void btnDecryptVigenre_Click(object sender, EventArgs e)
        {
            tbOutputVigenre.Clear();
            Regex regex = new Regex("^[A-Za-z]*$");
            if (!regex.IsMatch(tbInputVigenre.Text))
            {
                MessageBox.Show("Input invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
   
            tbOutputVigenre.Text = vigenere.Decrypt(tbInputVigenre.Text, tbKeyVigenre.Text);
        }
    }
}

