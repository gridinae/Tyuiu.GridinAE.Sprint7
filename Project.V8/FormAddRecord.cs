using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V8
{
    public partial class FormAddRecord : Form
    {
        public FormAddRecord()
        {
            InitializeComponent();
        }

        private void buttonCancel_GAE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_GAE_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDriverPhone_GAE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void FormAddRecord_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNumber_GAE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumber_GAE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void textBoxNumber_GAE_TextChanged_1(object sender, EventArgs e)
        {


        }
    }
}
