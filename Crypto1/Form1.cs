using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto1
{
    public partial class Form1 : Form
    {
         Crypt cry;
        public Form1()
        {
            InitializeComponent();
            cry = new Crypt();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (TrycemusMethod.Checked)
            {
                encryptedText.Text = cry.cryptTrisemus(keyText.Text, sourceText.Text);
            }
            if (VigenerMethod.Checked)
            {
                encryptedText.Text = cry.cryptVigener(keyText.Text, sourceText.Text);
            }
        }

        private void decyptButton_Click(object sender, EventArgs e)
        {
            if (TrycemusMethod.Checked)
            {
                decryptedText.Text = cry.decryptTrisemus(encryptedText.Text);
            }
            if (VigenerMethod.Checked)
            {
                decryptedText.Text = cry.decryptVigener(keyText.Text, encryptedText.Text);
            }
        }




    }
}
