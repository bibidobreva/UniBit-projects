using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSP_640_IMZ_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.buttonOk.Enabled = false;

            this.textBoxAdress.Tag = false;
            this.textBoxAge.Tag = false;
            this.textBoxName.Tag = false;
            this.textBoxProfession.Tag = false;

            this.textBoxName.Validating += new CancelEventHandler(texBoxEmpty_Validating);
            this.textBoxAdress.Validating += new CancelEventHandler(texBoxEmpty_Validating);
            this.textBoxProfession.Validating += new CancelEventHandler(textBoxProffesion_Validating);
            this.textBoxAge.Validating += new CancelEventHandler(this.texBoxEmpty_Validating);
            this.textBoxAge.Validating += new CancelEventHandler(this.textBoxAge_Validating);
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string output;
            output = "Име " + this.textBoxName.Text + "\r\n";
            output += "Адрес " + this.textBoxAdress.Text + "\r\n";
            output += "Професия " + this.textBoxProfession.Text + "\r\n";
            output += "Възраст " + this.textBoxAge.Text;
            this.textBoxOutput.Text = output;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string output;
            output = "Помощна информация: \r\n\r\n";
            output += "Име = Вашето име \r\n";
            output += "Адрес = Вашия адрес \r\n ";
            output += "Професия = Единствената правилна форма е 'Програмист'\r\n";
            output += "Възраст = възраст";
            this.textBoxOutput.Text = output;
        }
        private void ValidateOK()
        {
            this.buttonOk.Enabled = (
                    (bool)(this.textBoxAdress.Tag) &&
                    (bool)(this.textBoxAge.Tag) &&
                    (bool)(this.textBoxName.Tag) &&
                    (bool)(this.textBoxProfession.Tag)
                );
        }
        private void texBoxEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateOK();
        }
        private void textBoxProffesion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.CompareTo("Програмист") == 0 || tb.Text.Length == 0)
            {
                tb.Tag = true;
                tb.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }
            ValidateOK();
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(((tb.Text.Length==0)&&(e.KeyChar==48))||((e.KeyChar<48||e.KeyChar>57)&&e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void textBoxAge_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 0)
            {
                if (Int16.Parse(tb.Text.ToString()) < 18)
                {
                    tb.Tag = false;
                    tb.BackColor = Color.Red;
                }
                else
                {
                    tb.Tag = true;
                    tb.BackColor = SystemColors.Window;
                }
                ValidateOK();
            }
        }
        private void textBoxAge_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 0)
            {
                if (Int16.Parse(tb.Text.ToString()) < 18)
                {
                    tb.Tag = false;
                    tb.BackColor = Color.Red;
                }
                else
                {
                    tb.Tag = true;
                    tb.BackColor = SystemColors.Window;
                }
                ValidateOK();
            }
        }
        private void textBoxAge_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(tb.Text.Length==0&&tb!= textBoxProfession)
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }
            else
            {
                tb.Tag = true;
                tb.BackColor = SystemColors.Window;
            }
            ValidateOK();
        }
    }
}
