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

    private enum SearchOrFilterType
    {
        ByAutoNumber,
        ByRegion,
        ByBrand,
        ByColor,
        ByDriverName,
        ByDriverPhoneNumber,
        None
    }

    private SearchOrFilterType searchOrFilterType = SearchOrFilterType.None;
    private string searchOrFilterString = "";


    private void ReloadTable()
    {
        var selectedRows = dataGridViewMain_GAE.SelectedRows;

        string[][] data = DataService.ReadCsv(filePath);

        dataGridViewMain_GAE.Rows.Clear();

        for (int i = 0; i < data.Length; i++)
        {

            if (searchOrFilterType != SearchOrFilterType.None && data[i][(int)searchOrFilterType] != searchOrFilterString)
                continue;
            dataGridViewMain_GAE.Rows.Add();
            for (int j = 0; j < data[i].Length; j++)
            {
                dataGridViewMain_GAE.Rows[i].Cells[j].Value = data[i][j];
            }
        }

        dataGridViewMain_GAE.Sort(dataGridViewMain_GAE.Columns["Number"], ListSortDirection.Ascending);
        foreach (DataGridViewRow row in dataGridViewMain_GAE.Rows)
        {
            if (selectedRows.Contains(row))
                row.Selected = true;
        }
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        ReloadTable();
    }



    //TODO: Переписать три функции ниже (вынести функционал в отдельные методы)

    private void buttonAdd_GAE_Click(object sender, EventArgs e)
    {
        string line = "";
        FormAddRecord formAddRecord = new();
        if (formAddRecord.ShowDialog() == DialogResult.OK)
        {
            if ((formAddRecord.textBoxNumber_GAE.Text +
                formAddRecord.textBoxDriverName_GAE.Text +
                formAddRecord.textBoxDriverPhone_GAE.Text).Contains(',')
                || formAddRecord.textBoxNumber_GAE.Text == ""
                || formAddRecord.textBoxDriverName_GAE.Text == ""
                || formAddRecord.textBoxDriverPhone_GAE.Text == ""
                || formAddRecord.comboBoxRegion_GAE.Text == ""
                || formAddRecord.comboBoxBrand_GAE.Text == ""
                || formAddRecord.comboBoxColor_GAE.Text == "")
            {
                MessageBox.Show("Невозможно добавить запись. Проверьте правильность заполненных полей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DataService.IsCarNumberPresentInCsv(filePath, formAddRecord.textBoxNumber_GAE.Text))
            {
                MessageBox.Show("Невозможно добавить запись, так как запись с таким автомобильным номером уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        var msgBoxResult = MessageBox.Show("Удалить выделенные записи? Это действие нельзя отменить.", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

    private void buttonEdit_GAE_Click(object sender, EventArgs e)
    {
        if (dataGridViewMain_GAE.SelectedRows.Count == 0)
            return;
        string line = "";
        FormAddRecord formEditRecord = new();
        formEditRecord.Text = "Редактировать запись";
        formEditRecord.textBoxNumber_GAE.Text = dataGridViewMain_GAE.SelectedRows[0].Cells[0].Value.ToString();
        formEditRecord.comboBoxRegion_GAE.Text = dataGridViewMain_GAE.SelectedRows[0].Cells[1].Value.ToString();
        formEditRecord.comboBoxBrand_GAE.Text = dataGridViewMain_GAE.SelectedRows[0].Cells[2].Value.ToString();
        formEditRecord.comboBoxColor_GAE.Text = dataGridViewMain_GAE.SelectedRows[0].Cells[3].Value.ToString();
        formEditRecord.textBoxDriverName_GAE.Text = dataGridViewMain_GAE.SelectedRows[0].Cells[4].Value.ToString();
        formEditRecord.textBoxDriverPhone_GAE.Text = dataGridViewMain_GAE.SelectedRows[0].Cells[5].Value.ToString();

        if (formEditRecord.ShowDialog() == DialogResult.OK)
        {
            if ((formEditRecord.textBoxNumber_GAE.Text +
                formEditRecord.textBoxDriverName_GAE.Text +
                formEditRecord.textBoxDriverPhone_GAE.Text).Contains(',')
                || formEditRecord.textBoxNumber_GAE.Text == ""
                || formEditRecord.textBoxDriverName_GAE.Text == ""
                || formEditRecord.textBoxDriverPhone_GAE.Text == ""
                || formEditRecord.comboBoxRegion_GAE.Text == ""
                || formEditRecord.comboBoxBrand_GAE.Text == ""
                || formEditRecord.comboBoxColor_GAE.Text == "")
            {
                MessageBox.Show("Невозможно добавить запись. Проверьте правильность заполненных полей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка на изменение автомобильного номера на уже существующий
            if (DataService.IsCarNumberPresentInCsv(filePath, formEditRecord.textBoxNumber_GAE.Text) && dataGridViewMain_GAE.SelectedRows[0].Cells[0].Value.ToString() != formEditRecord.textBoxNumber_GAE.Text)
            {
                MessageBox.Show("Невозможно редактировать запись, так как запись с таким автомобильным номером уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            line += formEditRecord.textBoxNumber_GAE.Text;
            line += "," + formEditRecord.comboBoxRegion_GAE.Text;
            line += "," + formEditRecord.comboBoxBrand_GAE.Text;
            line += "," + formEditRecord.comboBoxColor_GAE.Text;
            line += "," + formEditRecord.textBoxDriverName_GAE.Text;
            line += "," + formEditRecord.textBoxDriverPhone_GAE.Text;

            string line2 = "";
            line2 += dataGridViewMain_GAE.SelectedRows[0].Cells[0].Value;
            line2 += "," + dataGridViewMain_GAE.SelectedRows[0].Cells[1].Value;
            line2 += "," + dataGridViewMain_GAE.SelectedRows[0].Cells[2].Value;
            line2 += "," + dataGridViewMain_GAE.SelectedRows[0].Cells[3].Value;
            line2 += "," + dataGridViewMain_GAE.SelectedRows[0].Cells[4].Value;
            line2 += "," + dataGridViewMain_GAE.SelectedRows[0].Cells[5].Value;
            DataService.DeleteLineInCsv(filePath, line2);
            DataService.AppendCsv(filePath, line);
            ReloadTable();
        }
    }

    private void buttonHelp_GAE_Click(object sender, EventArgs e) => new FormAbout().ShowDialog();
}
