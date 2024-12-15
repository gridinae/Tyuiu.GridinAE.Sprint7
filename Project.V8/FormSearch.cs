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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void buttonCancel_GAE_Click(object sender, EventArgs e) => Close();

        private void FormSearch_Load(object sender, EventArgs e)
        {
            comboBoxSearchType_GAE.Text = "По авт. номеру";
        }

        private void buttonClearSearchString_GAE_Click(object sender, EventArgs e) => textBoxSearchString_GAE.Text = string.Empty;

    }
}
