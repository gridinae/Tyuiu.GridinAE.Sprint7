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
    public partial class FormRTFViewer : Form
    {
        public FormRTFViewer()
        {
            InitializeComponent();
        }

        private readonly string filePath = AppDomain.CurrentDomain.BaseDirectory + @"\Manual.rtf";

        private void FormRTFViewer_Load(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Невозможно открыть мануал: файл {filePath} не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            richTextBoxManual_GAE.LoadFile(filePath);
        }
    }
}
