using Project.V8.Lib;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace Project.V8;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    private int _itemCount;
    private int ItemCount
    {
        get { return _itemCount; }
        set
        {
            _itemCount = value;
            toolStripStatusLabelItemCount.Text = "Число записей: " + _itemCount.ToString();
        }
    }
    private void dataGridViewMain_GAE_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) => ItemCount += e.RowCount;
    private void dataGridViewMain_GAE_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => ItemCount -= e.RowCount;

    private string filePath = AppDomain.CurrentDomain.BaseDirectory + @"\Data.csv";

    private void ReloadTable()
    {
        string[][] data = DataService.ReadCsv(filePath);

        dataGridViewMain_GAE.Rows.Clear();

        for (int i = 0; i < data.Length; i++)
        {
            dataGridViewMain_GAE.Rows.Add();
            for (int j = 0; j < data[i].Length; j++)
            {
                dataGridViewMain_GAE.Rows[i].Cells[j].Value = data[i][j];
            }
        }

        dataGridViewMain_GAE.Sort(dataGridViewMain_GAE.Columns["Number"], ListSortDirection.Ascending);
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        ReloadTable();
    }

    private void buttonAdd_GAE_Click(object sender, EventArgs e)
    {
        string line = "";
        FormAddRecord formAddRecord = new();
        if (formAddRecord.ShowDialog() == DialogResult.OK)
        {
            if ((formAddRecord.textBoxNumber_GAE.Text +
                formAddRecord.textBoxDriverName_GAE.Text +
                formAddRecord.textBoxDriverPhone_GAE.Text).Contains(','))
            {
                MessageBox.Show("Ошибка");
                return;
            }
            line += formAddRecord.textBoxNumber_GAE.Text;
            line += "," + formAddRecord.comboBoxRegion_GAE.Text;
            line += "," + formAddRecord.comboBoxBrand_GAE.Text;
            line += "," + formAddRecord.comboBoxColor_GAE.Text;
            line += "," + formAddRecord.textBoxDriverName_GAE.Text;
            line += "," + formAddRecord.textBoxDriverPhone_GAE.Text;

            DataService.AppendCsv(filePath, line);
            ReloadTable();
        }

    }

    private void buttonRemove_GAE_Click(object sender, EventArgs e)
    {
        var msgBoxResult = MessageBox.Show("Удалить выделенные записи? Это действие нельзя отменить", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (msgBoxResult == DialogResult.Yes)
        {
            for (int i = 0; i < dataGridViewMain_GAE.SelectedRows.Count; i++)
            {
                string line = "";
                line += dataGridViewMain_GAE.SelectedRows[i].Cells[0].Value;
                line += "," + dataGridViewMain_GAE.SelectedRows[i].Cells[1].Value;
                line += "," + dataGridViewMain_GAE.SelectedRows[i].Cells[2].Value;
                line += "," + dataGridViewMain_GAE.SelectedRows[i].Cells[3].Value;
                line += "," + dataGridViewMain_GAE.SelectedRows[i].Cells[4].Value;
                line += "," + dataGridViewMain_GAE.SelectedRows[i].Cells[5].Value;
                DataService.DeleteLineInCsv(filePath, line);
            }
            ReloadTable();
        }

    }
}
