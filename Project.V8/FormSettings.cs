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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void buttonCancel_GAE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonChangeSelectionBgColor_GAE_Click(object sender, EventArgs e)
        {
            if (colorDialogBg_GAE.ShowDialog() == DialogResult.OK)
                panelSelectionBgColor_GAE.BackColor = colorDialogBg_GAE.Color;
        }

        private void buttonChangeSelectionFgColor_GAE_Click(object sender, EventArgs e)
        {
            if (colorDialogFg_GAE.ShowDialog() == DialogResult.OK)
                panelSelectionFgColor_GAE.BackColor = colorDialogFg_GAE.Color;
        }


        private void FormSettings_Load(object sender, EventArgs e)
        {
            colorDialogBg_GAE.Color = panelSelectionBgColor_GAE.BackColor;
            colorDialogFg_GAE.Color = panelSelectionFgColor_GAE.BackColor;
        }

        public Font Font
        {
            get { return fontDialog_GAE.Font; }
            set
            {
                fontDialog_GAE.Font = value;
                labelFont_GAE.Text = "Шрифт: " + fontDialog_GAE.Font.Name +
                                     ", " + Math.Round(fontDialog_GAE.Font.Size).ToString() + " пт.";
                if (value.Style != FontStyle.Regular)
                    labelFont_GAE.Text += $", {value.Style}";
            }
        }

        private void buttonChangeFont_GAE_Click(object sender, EventArgs e)
        {
            if (fontDialog_GAE.ShowDialog() == DialogResult.OK)
                Font = fontDialog_GAE.Font;
        }

        private void buttonReset_GAE_Click(object sender, EventArgs e)
        {
            Font = new Font("Segoe UI", 9);
            colorDialogFg_GAE.Color = panelSelectionFgColor_GAE.BackColor = SystemColors.HighlightText;
            colorDialogBg_GAE.Color = panelSelectionBgColor_GAE.BackColor = SystemColors.Highlight;
        }
    }
}
