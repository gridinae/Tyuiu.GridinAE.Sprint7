using Project.V8.Lib;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Project.V8;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    private int itemCount;
    private int ItemCount
    {
        get { return itemCount; }
        set
        {
            itemCount = value;
            toolStripStatusLabelItemCount.Text = "Число записей: " + itemCount.ToString();
        }
    }
    private void dataGridViewMain_GAE_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) => ItemCount += e.RowCount;
    private void dataGridViewMain_GAE_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => ItemCount -= e.RowCount;

    private readonly string filePath = AppDomain.CurrentDomain.BaseDirectory + @"\Data.csv";

    private List<string> filterRegion = ["Москва", "Тюмень", "Тверь", "Екатеринбург", "Санкт-Петербург", "Новосибирск"];
    private List<string> filterBrand = ["Volvo", "Audi", "Nissan", "BMW", "Mercedes", "Opel", "Lada"];
    private List<string> filterColor = ["Черный", "Белый", "Серый", "Синий", "Фиолетовый", "Красный", "Розовый", "Желтый", "Зеленый", "Коричневый"];
    
    private void ReloadTable()
    {
        var selectedRows = dataGridViewMain_GAE.SelectedRows;

        string[][] data = DataService.ReadCsv(filePath);
        List<string[]> filteredData = new();
        foreach (string[] record in data)
            if (filterRegion.Contains(record[1]) && filterBrand.Contains(record[2]) && filterColor.Contains(record[3]))
                filteredData.Add(record);

        dataGridViewMain_GAE.Rows.Clear();

        for (int i = 0; i < filteredData.Count; i++)
        {

            dataGridViewMain_GAE.Rows.Add();
            for (int j = 0; j < filteredData[i].Length; j++)
            {
                dataGridViewMain_GAE.Rows[i].Cells[j].Value = filteredData[i][j];
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


    private string CheckValidityOfFormAddRecord(FormAddRecord formAddRecord)
    {
        string errorText = "";
        if (formAddRecord.textBoxNumber_GAE.Text.Contains(','))
            errorText = "Невозможно добавить запись. Поле \"Автомобильный номер\" содержит запрещенный символ \",\".";
        else if (formAddRecord.textBoxDriverName_GAE.Text.Contains(','))
            errorText = "Невозможно добавить запись. Поле \"ФИО Водителя\" содержит запрещенный символ \",\".";
        else if (formAddRecord.textBoxNumber_GAE.Text == "")
            errorText = "Невозможно добавить запись. Поле \"Автомобильный номер\" не заполнено.";
        else if (formAddRecord.textBoxDriverName_GAE.Text == "")
            errorText = "Невозможно добавить запись. Поле \"ФИО Водителя\" не заполнено.";
        else if (formAddRecord.textBoxDriverPhone_GAE.Text == "")
            errorText = "Невозможно добавить запись. Поле \"Телефон Водителя\" не заполнено.";
        else if (formAddRecord.comboBoxRegion_GAE.Text == "")
            errorText = "Невозможно добавить запись, так как не выбран регион.";
        else if (formAddRecord.comboBoxBrand_GAE.Text == "")
            errorText = "Невозможно добавить запись, так как не выбрана марка.";
        else if (formAddRecord.comboBoxColor_GAE.Text == "")
            errorText = "Невозможно добавить запись, так как не выбран цвет.";
        return errorText;
    }
    private string GetCsvLineFromFormAddRecord(FormAddRecord formAddRecord)
    {
        string line = "";
        line += formAddRecord.textBoxNumber_GAE.Text;
        line += "," + formAddRecord.comboBoxRegion_GAE.Text;
        line += "," + formAddRecord.comboBoxBrand_GAE.Text;
        line += "," + formAddRecord.comboBoxColor_GAE.Text;
        line += "," + formAddRecord.textBoxDriverName_GAE.Text;
        line += ",+7" + formAddRecord.textBoxDriverPhone_GAE.Text;
        return line;
    }
    private string GetCsvLineFromFirstSelectedRow()
    {
        string line = "";
        line += dataGridViewMain_GAE.SelectedRows[0].Cells[0].Value;
        line += "," + dataGridViewMain_GAE.SelectedRows[0].Cells[1].Value;
        line += "," + dataGridViewMain_GAE.SelectedRows[0].Cells[2].Value;
        line += "," + dataGridViewMain_GAE.SelectedRows[0].Cells[3].Value;
        line += "," + dataGridViewMain_GAE.SelectedRows[0].Cells[4].Value;
        line += "," + dataGridViewMain_GAE.SelectedRows[0].Cells[5].Value;
        return line;
    }
    private void SetFormAddRecordFieldsWithFirstSelectedRowValues(FormAddRecord formAddRecord)
    {
        formAddRecord.textBoxNumber_GAE.Text = dataGridViewMain_GAE.SelectedRows[0].Cells[0].Value.ToString();
        formAddRecord.comboBoxRegion_GAE.Text = dataGridViewMain_GAE.SelectedRows[0].Cells[1].Value.ToString();
        formAddRecord.comboBoxBrand_GAE.Text = dataGridViewMain_GAE.SelectedRows[0].Cells[2].Value.ToString();
        formAddRecord.comboBoxColor_GAE.Text = dataGridViewMain_GAE.SelectedRows[0].Cells[3].Value.ToString();
        formAddRecord.textBoxDriverName_GAE.Text = dataGridViewMain_GAE.SelectedRows[0].Cells[4].Value.ToString();
        formAddRecord.textBoxDriverPhone_GAE.Text = dataGridViewMain_GAE.SelectedRows[0].Cells[5].Value.ToString();
    }

    private void buttonAdd_GAE_Click(object sender, EventArgs e)
    {

        FormAddRecord formAddRecord = new();
        if (formAddRecord.ShowDialog() == DialogResult.OK)
        {
            if (DataService.IsCarNumberPresentInCsv(filePath, formAddRecord.textBoxNumber_GAE.Text)
                && formAddRecord.textBoxNumber_GAE.Text != String.Empty)
            {
                MessageBox.Show("Невозможно добавить запись, так как запись с таким автомобильным номером уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string validityResult = CheckValidityOfFormAddRecord(formAddRecord);
            if (validityResult != "")
            {
                MessageBox.Show(validityResult, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataService.AppendCsv(filePath, GetCsvLineFromFormAddRecord(formAddRecord));
            ReloadTable();
        }

    }

    private void buttonRemove_GAE_Click(object sender, EventArgs e)
    {
        if (dataGridViewMain_GAE.SelectedRows.Count == 0)
            return;
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
        FormAddRecord formEditRecord = new();
        formEditRecord.Text = "Редактировать запись";

        SetFormAddRecordFieldsWithFirstSelectedRowValues(formEditRecord);

        if (formEditRecord.ShowDialog() == DialogResult.OK)
        {


            // Проверка на изменение автомобильного номера на уже существующий
            if (DataService.IsCarNumberPresentInCsv(filePath, formEditRecord.textBoxNumber_GAE.Text)
                && dataGridViewMain_GAE.SelectedRows[0].Cells[0].Value.ToString() != formEditRecord.textBoxNumber_GAE.Text
                && formEditRecord.textBoxNumber_GAE.Text != String.Empty)
            {
                MessageBox.Show("Невозможно редактировать запись, так как запись с таким автомобильным номером уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string validityResult = CheckValidityOfFormAddRecord(formEditRecord);
            if (validityResult != "")
            {
                MessageBox.Show(validityResult, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataService.AppendCsv(filePath, GetCsvLineFromFormAddRecord(formEditRecord));
            DataService.DeleteLineInCsv(filePath, GetCsvLineFromFirstSelectedRow());
            ReloadTable();
        }
    }

    private void buttonHelp_GAE_Click(object sender, EventArgs e) => new FormAbout().ShowDialog();

    private void buttonFilter_GAE_Click(object sender, EventArgs e)
    {
        FormFilter formFilter = new();

        for (int i = 0; i < formFilter.checkedListBoxBrand_GAE.Items.Count; i++)
        {
            if (filterBrand.Contains(formFilter.checkedListBoxBrand_GAE.Items[i].ToString()))
                formFilter.checkedListBoxBrand_GAE.SetItemChecked(i, true);
        }
        for (int i = 0; i < formFilter.checkedListBoxColor_GAE.Items.Count; i++)
        {
            if (filterColor.Contains(formFilter.checkedListBoxColor_GAE.Items[i].ToString()))
                formFilter.checkedListBoxColor_GAE.SetItemChecked(i, true);
        }
        for (int i = 0; i < formFilter.checkedListBoxRegion_GAE.Items.Count; i++)
        {
            if (filterRegion.Contains(formFilter.checkedListBoxRegion_GAE.Items[i].ToString()))
                formFilter.checkedListBoxRegion_GAE.SetItemChecked(i, true);
        }

        if (formFilter.ShowDialog() == DialogResult.OK)
        {
            filterRegion.Clear();
            filterBrand.Clear();
            filterColor.Clear();
            foreach (var i in formFilter.checkedListBoxRegion_GAE.CheckedItems)
                filterRegion.Add(i.ToString());
            foreach (var i in formFilter.checkedListBoxBrand_GAE.CheckedItems)
                filterBrand.Add(i.ToString());
            foreach (var i in formFilter.checkedListBoxColor_GAE.CheckedItems)
                filterColor.Add(i.ToString());
            ReloadTable();
        }
    }
}
