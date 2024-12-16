using Project.V8.Lib;
using System.ComponentModel;
using System.Diagnostics;
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
            toolStripStatusLabelItemCount.Text = "����� �������: " + itemCount.ToString();
        }
    }
    private void dataGridViewMain_GAE_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) => ItemCount += e.RowCount;
    private void dataGridViewMain_GAE_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => ItemCount -= e.RowCount;

    private readonly string filePath = AppDomain.CurrentDomain.BaseDirectory + @"\Data.csv";

    private List<string> filterRegion = ["������", "������", "�����", "������������", "�����-���������", "�����������"];
    private List<string> filterBrand = ["Volvo", "Audi", "Nissan", "BMW", "Mercedes", "Opel", "Lada"];
    private List<string> filterColor = ["������", "�����", "�����", "�����", "����������", "�������", "�������", "������", "�������", "����������"];

    private string searchType = "�� ���. ������"; // �� ���� ����� ������������ enum
    private bool searchExactMatch = false;
    private string searchString = String.Empty;

    private string[][] csv = [];
    private List<string[]> filteredData = [];

    private void ReloadCsv()
    {
        if (!File.Exists(filePath))
        {
            csv = [];
            MessageBox.Show($"������ ��� ������ ����� ������: ���� {filePath} �� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        csv = DataService.ReadCsv(filePath);
    }
    private void ReloadTable()
    {
        var selectedRows = dataGridViewMain_GAE.SelectedRows;

        filteredData.Clear();
        int index;
        foreach (string[] record in csv)
            if (filterRegion.Contains(record[1]) && filterBrand.Contains(record[2]) && filterColor.Contains(record[3]))
            {
                index = searchType switch
                {
                    "�� ���. ������" => 0,
                    "�� ���" => 4
                };
                if (searchString == string.Empty || (searchExactMatch && record[index] == searchString || !searchExactMatch && record[index].Contains(searchString)))
                    filteredData.Add(record);
            }

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
    private void ReloadCellStyleSettings()
    {
        CellStyleSettings cellStyleSettings = new();
        cellStyleSettings.Read();

        dataGridViewMain_GAE.DefaultCellStyle.Font = cellStyleSettings.Font;
        dataGridViewMain_GAE.DefaultCellStyle.SelectionForeColor = cellStyleSettings.SelectionForeColor;
        dataGridViewMain_GAE.DefaultCellStyle.SelectionBackColor = cellStyleSettings.SelectionBackColor;

    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        ReloadCsv();
        ReloadTable();
        ReloadCellStyleSettings();
    }


    private string CheckValidityOfFormAddRecord(FormAddRecord formAddRecord)
    {
        string errorText = "";
        if (formAddRecord.textBoxNumber_GAE.Text.Contains(','))
            errorText = "���������� �������� ������. ���� \"������������� �����\" �������� ����������� ������ \",\".";
        else if (formAddRecord.textBoxDriverName_GAE.Text.Contains(','))
            errorText = "���������� �������� ������. ���� \"��� ��������\" �������� ����������� ������ \",\".";
        else if (formAddRecord.textBoxNumber_GAE.Text == "")
            errorText = "���������� �������� ������. ���� \"������������� �����\" �� ���������.";
        else if (formAddRecord.textBoxDriverName_GAE.Text == "")
            errorText = "���������� �������� ������. ���� \"��� ��������\" �� ���������.";
        else if (formAddRecord.textBoxDriverPhone_GAE.Text == "")
            errorText = "���������� �������� ������. ���� \"������� ��������\" �� ���������.";
        else if (formAddRecord.comboBoxRegion_GAE.Text == "")
            errorText = "���������� �������� ������, ��� ��� �� ������ ������.";
        else if (formAddRecord.comboBoxBrand_GAE.Text == "")
            errorText = "���������� �������� ������, ��� ��� �� ������� �����.";
        else if (formAddRecord.comboBoxColor_GAE.Text == "")
            errorText = "���������� �������� ������, ��� ��� �� ������ ����.";
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
        formAddRecord.textBoxDriverPhone_GAE.Text = dataGridViewMain_GAE.SelectedRows[0].Cells[5].Value.ToString()[2..];
    }

    private void buttonAdd_GAE_Click(object sender, EventArgs e)
    {

        FormAddRecord formAddRecord = new();
        if (formAddRecord.ShowDialog() == DialogResult.OK)
        {
            if (DataService.IsCarNumberPresentInCsv(filePath, formAddRecord.textBoxNumber_GAE.Text)
                && formAddRecord.textBoxNumber_GAE.Text != String.Empty)
            {
                MessageBox.Show("���������� �������� ������, ��� ��� ������ � ����� ������������� ������� ��� ����������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string validityResult = CheckValidityOfFormAddRecord(formAddRecord);
            if (validityResult != "")
            {
                MessageBox.Show(validityResult, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataService.AppendCsv(filePath, GetCsvLineFromFormAddRecord(formAddRecord));
            ReloadCsv();
            ReloadTable();
        }

    }

    private void buttonRemove_GAE_Click(object sender, EventArgs e)
    {
        if (dataGridViewMain_GAE.SelectedRows.Count == 0)
            return;
        var msgBoxResult = MessageBox.Show("������� ���������� ������? ��� �������� ������ ��������.", "��������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            ReloadCsv();
            ReloadTable();
        }

    }

    private void buttonEdit_GAE_Click(object sender, EventArgs e)
    {
        if (dataGridViewMain_GAE.SelectedRows.Count == 0)
            return;
        FormAddRecord formEditRecord = new();
        formEditRecord.Text = "������������� ������";
        formEditRecord.buttonOK_GAE.Text = "��";

        SetFormAddRecordFieldsWithFirstSelectedRowValues(formEditRecord);

        if (formEditRecord.ShowDialog() == DialogResult.OK)
        {


            // �������� �� ��������� �������������� ������ �� ��� ������������
            if (DataService.IsCarNumberPresentInCsv(filePath, formEditRecord.textBoxNumber_GAE.Text)
                && dataGridViewMain_GAE.SelectedRows[0].Cells[0].Value.ToString() != formEditRecord.textBoxNumber_GAE.Text
                && formEditRecord.textBoxNumber_GAE.Text != String.Empty)
            {
                MessageBox.Show("���������� ������������� ������, ��� ��� ������ � ����� ������������� ������� ��� ����������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string validityResult = CheckValidityOfFormAddRecord(formEditRecord);
            if (validityResult != "")
            {
                MessageBox.Show(validityResult, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataService.DeleteLineInCsv(filePath, GetCsvLineFromFirstSelectedRow());
            DataService.AppendCsv(filePath, GetCsvLineFromFormAddRecord(formEditRecord));


            ReloadCsv();
            ReloadTable();
        }
    }

    private void buttonHelp_GAE_Click(object sender, EventArgs e) => contextMenuStripHelp_GAE.Show(Cursor.Position);

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
            if (filterRegion.SequenceEqual(new List<string> { "������", "������", "�����", "������������", "�����-���������", "�����������" })
             && filterBrand.SequenceEqual(new List<string> { "Volvo", "Audi", "Nissan", "BMW", "Mercedes", "Opel", "Lada" })
             && filterColor.SequenceEqual(new List<string> { "������", "�����", "�����", "�����", "����������", "�������", "�������", "������", "�������", "����������" }))
            {
                buttonFilter_GAE.BackColor = SystemColors.Control;
            }
            else
            {
                buttonFilter_GAE.BackColor = System.Drawing.Color.Coral;
            }
            ReloadTable();
        }
    }

    private void buttonSearch_GAE_Click(object sender, EventArgs e)
    {
        FormSearch formSearch = new();
        formSearch.comboBoxSearchType_GAE.Text = searchType;
        formSearch.textBoxSearchString_GAE.Text = searchString;
        formSearch.checkBoxExactMatch_GAE.Checked = searchExactMatch;
        if (formSearch.ShowDialog() == DialogResult.OK)
        {
            searchType = formSearch.comboBoxSearchType_GAE.Text;
            searchString = formSearch.textBoxSearchString_GAE.Text;
            searchExactMatch = formSearch.checkBoxExactMatch_GAE.Checked;

            if (searchString == string.Empty)
                buttonSearch_GAE.BackColor = SystemColors.Control;
            else
                buttonSearch_GAE.BackColor = System.Drawing.Color.Coral;

            ReloadTable();
        }
    }

    private void buttonStats_GAE_Click(object sender, EventArgs e)
    {
        if (dataGridViewMain_GAE.RowCount == 0)
        {
            MessageBox.Show("���������� �������� ����������, ��� ��� � ������� ����������� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        FormStats formStats = new();

        int count;
        foreach (var s in new string[] { "������", "������", "�����", "������������", "�����-���������", "�����������" })
        {
            count = 0;
            for (int i = 0; i < dataGridViewMain_GAE.RowCount; i++)
            {
                if (dataGridViewMain_GAE.Rows[i].Cells[1].Value.ToString() == s)
                    count++;
            }
            if (count != 0)
                formStats.chartRegion_GAE.Series.First().Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint { YValues = [count], LegendText = s });
        }

        foreach (var s in new string[] { "Volvo", "Audi", "Nissan", "BMW", "Mercedes", "Opel", "Lada" })
        {
            count = 0;
            for (int i = 0; i < dataGridViewMain_GAE.RowCount; i++)
            {
                if (dataGridViewMain_GAE.Rows[i].Cells[2].Value.ToString() == s)
                    count++;
            }
            if (count != 0)
                formStats.chartBrand_GAE.Series.First().Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint { YValues = [count], LegendText = s });
        }

        foreach (var s in new string[] { "������", "�����", "�����", "�����", "����������", "�������", "�������", "������", "�������", "����������" })
        {
            count = 0;
            for (int i = 0; i < dataGridViewMain_GAE.RowCount; i++)
            {
                if (dataGridViewMain_GAE.Rows[i].Cells[3].Value.ToString() == s)
                    count++;
            }

            Color color = s switch
            {
                "������" => ColorTranslator.FromHtml("#000000"),
                "�����" => ColorTranslator.FromHtml("#efefef"),
                "�����" => ColorTranslator.FromHtml("#9e9e9e"),
                "�����" => ColorTranslator.FromHtml("#322fd9"),
                "����������" => ColorTranslator.FromHtml("#b428d8"),
                "�������" => ColorTranslator.FromHtml("#d93252"),
                "�������" => ColorTranslator.FromHtml("#e369c5"),
                "������" => ColorTranslator.FromHtml("#e6e477"),
                "�������" => ColorTranslator.FromHtml("#69e15d"),
                "����������" => ColorTranslator.FromHtml("#918151")

            };

            if (count != 0)
                formStats.chartColor_GAE.Series.First().Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint { YValues = [count], LegendText = s, Color = color });
        }


        formStats.ShowDialog();
    }

    private void toolStripMenuHelpManual_Click(object sender, EventArgs e)
    {
        new Process
        {
            StartInfo = new ProcessStartInfo(AppDomain.CurrentDomain.BaseDirectory + @"\Manual.rtf")
            {
                UseShellExecute = true
            }
        }.Start();
    }

    private void toolStripMenuHelpAbout_Click(object sender, EventArgs e)
    {
        new FormAbout().ShowDialog();
    }

    private void buttonSettings_GAE_Click(object sender, EventArgs e)
    {
        FormSettings formSettings = new();

        formSettings.Font = dataGridViewMain_GAE.DefaultCellStyle.Font;
        formSettings.labelFont_GAE.Text = "�����: " + dataGridViewMain_GAE.DefaultCellStyle.Font.Name +
                                     ", " + dataGridViewMain_GAE.DefaultCellStyle.Font.SizeInPoints.ToString() + " ��.";
        if (dataGridViewMain_GAE.DefaultCellStyle.Font.Style != FontStyle.Regular)
            formSettings.labelFont_GAE.Text += $", {dataGridViewMain_GAE.DefaultCellStyle.Font.Style}";

        formSettings.panelSelectionBgColor_GAE.BackColor = dataGridViewMain_GAE.DefaultCellStyle.SelectionBackColor;
        formSettings.panelSelectionFgColor_GAE.BackColor = dataGridViewMain_GAE.DefaultCellStyle.SelectionForeColor;

        if (formSettings.ShowDialog() == DialogResult.OK)
        {
            dataGridViewMain_GAE.DefaultCellStyle.Font = formSettings.Font;
            dataGridViewMain_GAE.DefaultCellStyle.SelectionForeColor = formSettings.panelSelectionFgColor_GAE.BackColor;
            dataGridViewMain_GAE.DefaultCellStyle.SelectionBackColor = formSettings.panelSelectionBgColor_GAE.BackColor;

            new CellStyleSettings(formSettings.Font, formSettings.panelSelectionFgColor_GAE.BackColor, formSettings.panelSelectionBgColor_GAE.BackColor).Write();
        }

        
    }
}
