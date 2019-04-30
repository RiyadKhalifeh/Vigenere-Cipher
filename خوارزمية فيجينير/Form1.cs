using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace خوارزمية_فيجينير
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //string alphabets = " أبتثجحخدذرزسشصضطظعغفقكلمنهوي0123456789";
        

        public static int Mod(int a, int n)
        {
            return a - (int)Math.Floor((double)a / n) * n;
        } 

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxKey.Clear();
            textBoxPlain.Clear();
            textBoxCipher.Clear();
            textBoxDecipher.Clear();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxKey.Text == "" || textBoxPlain.Text == "")
                MessageBox.Show("أحد الحقول المطلوبة فارغ", "خطأ");
            else
            {
                bool KeyAccept = true;
                textBoxCipher.Clear();
                string Key = textBoxKey.Text.ToUpper();
                string Plaintext = textBoxPlain.Text;
                for (int i = 0; i < Key.Length; i++)
                    if (!alphabets.Contains(Key[i]))
                    {
                        MessageBox.Show("المفتاح يجب أن لا يحوي على فراغات أو أحرف غير إنجليزية", "خطأ في المفتاح");
                        KeyAccept = false;
                        break;
                    }
                if (KeyAccept)
                {
                    while (Plaintext.Length > Key.Length)
                        Key += Key;

                    int Index = 0;
                    for (int i = 0; i < textBoxPlain.Text.Length; i++)
                    {
                        if (alphabets.Contains(Plaintext[i]))
                            textBoxCipher.Text += alphabets[Mod(alphabets.IndexOf(Plaintext[i]) + alphabets.IndexOf(Key[i - Index]), alphabets.Length)];
                        else
                            if (alphabets.Contains(char.ToUpper(Plaintext[i])))
                                textBoxCipher.Text += char.ToLower(alphabets[Mod(alphabets.IndexOf(char.ToUpper(Plaintext[i])) + alphabets.IndexOf(Key[i - Index]), alphabets.Length)]);
                            else
                            {
                                textBoxCipher.Text += Plaintext[i];
                                Index++;
                            }
                    }
                }
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxKey.Text == "" || textBoxCipher.Text == "")
                MessageBox.Show("أحد الحقول المطلوبة فارغ", "خطأ");
            else
            {
                bool KeyAccept = true;
                textBoxDecipher.Clear();
                string Key = textBoxKey.Text.ToUpper();
                string CipherText = textBoxCipher.Text;
                for (int i = 0; i < Key.Length; i++)
                    if (!alphabets.Contains(Key[i]))
                    {
                        MessageBox.Show("المفتاح يجب أن لا يحوي على فراغات أو أحرف غير إنجليزية", "خطأ في المفتاح");
                        KeyAccept = false;
                        break;
                    }
                if (KeyAccept)
                {
                    while (CipherText.Length > Key.Length)
                        Key += Key;

                    int Index = 0;
                    for (int i = 0; i < textBoxPlain.Text.Length; i++)
                    {
                        if (alphabets.Contains(CipherText[i]))
                            textBoxDecipher.Text += alphabets[Mod(alphabets.IndexOf(CipherText[i]) - alphabets.IndexOf(Key[i - Index]), alphabets.Length)];
                        else
                            if (alphabets.Contains(char.ToUpper(CipherText[i])))
                                textBoxDecipher.Text += char.ToLower(alphabets[Mod(alphabets.IndexOf(char.ToUpper(CipherText[i])) - alphabets.IndexOf(Key[i - Index]), alphabets.Length)]);
                            else
                            {
                                textBoxDecipher.Text += CipherText[i];
                                Index++;
                            }
                    }
                }
            }

        }
        private void textBoxKey_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.A || e.KeyCode > Keys.Z) && (e.KeyCode != Keys.Back))
                e.SuppressKeyPress = true;
            if (e.Control == true && e.KeyCode == Keys.V)
                e.SuppressKeyPress = true;
        }

        private void textBoxKey_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                textBoxKey.ContextMenu = new ContextMenu();
        }

        private void textBoxKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(Convert.ToString(e.KeyChar));
        }

    }
}
