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
    public partial class FormFilter : Form
    {
        public FormFilter()
        {
            InitializeComponent();
        }

        private void buttonCancel_GAE_Click(object sender, EventArgs e) => Close();

        private void FormFilter_Load(object sender, EventArgs e)
        {

        }

        private void buttonResetFilter_GAE_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxBrand_GAE.Items.Count; i++)
                checkedListBoxBrand_GAE.SetItemChecked(i, true);
            for (int i = 0; i < checkedListBoxColor_GAE.Items.Count; i++)
                checkedListBoxColor_GAE.SetItemChecked(i, true);
            for (int i = 0; i < checkedListBoxRegion_GAE.Items.Count; i++)
                checkedListBoxRegion_GAE.SetItemChecked(i, true);
        }
    }
}
