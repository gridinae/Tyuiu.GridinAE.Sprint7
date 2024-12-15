namespace Project.V8
{
    partial class FormSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            label1 = new Label();
            comboBoxSearchType_GAE = new ComboBox();
            buttonCancel_GAE = new Button();
            buttonFind_GAE = new Button();
            labelSearchString_GAE = new Label();
            textBoxSearchString_GAE = new TextBox();
            buttonClearSearchString_GAE = new Button();
            checkBoxExactMatch_GAE = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Тип поиска: ";
            // 
            // comboBoxSearchType_GAE
            // 
            comboBoxSearchType_GAE.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchType_GAE.FormattingEnabled = true;
            comboBoxSearchType_GAE.Items.AddRange(new object[] { "По авт. номеру", "По ФИО" });
            comboBoxSearchType_GAE.Location = new Point(113, 12);
            comboBoxSearchType_GAE.Name = "comboBoxSearchType_GAE";
            comboBoxSearchType_GAE.Size = new Size(190, 28);
            comboBoxSearchType_GAE.TabIndex = 1;
            // 
            // buttonCancel_GAE
            // 
            buttonCancel_GAE.Location = new Point(110, 148);
            buttonCancel_GAE.Name = "buttonCancel_GAE";
            buttonCancel_GAE.Size = new Size(85, 29);
            buttonCancel_GAE.TabIndex = 17;
            buttonCancel_GAE.Text = "Отмена";
            buttonCancel_GAE.UseVisualStyleBackColor = true;
            buttonCancel_GAE.Click += buttonCancel_GAE_Click;
            // 
            // buttonFind_GAE
            // 
            buttonFind_GAE.DialogResult = DialogResult.OK;
            buttonFind_GAE.Location = new Point(201, 148);
            buttonFind_GAE.Name = "buttonFind_GAE";
            buttonFind_GAE.Size = new Size(102, 29);
            buttonFind_GAE.TabIndex = 16;
            buttonFind_GAE.Text = "Найти";
            buttonFind_GAE.UseVisualStyleBackColor = true;
            // 
            // labelSearchString_GAE
            // 
            labelSearchString_GAE.AutoSize = true;
            labelSearchString_GAE.Location = new Point(12, 52);
            labelSearchString_GAE.Name = "labelSearchString_GAE";
            labelSearchString_GAE.Size = new Size(113, 20);
            labelSearchString_GAE.TabIndex = 18;
            labelSearchString_GAE.Text = "Строка поиска:";
            // 
            // textBoxSearchString_GAE
            // 
            textBoxSearchString_GAE.Location = new Point(12, 77);
            textBoxSearchString_GAE.Name = "textBoxSearchString_GAE";
            textBoxSearchString_GAE.Size = new Size(256, 27);
            textBoxSearchString_GAE.TabIndex = 19;
            // 
            // buttonClearSearchString_GAE
            // 
            buttonClearSearchString_GAE.FlatStyle = FlatStyle.Flat;
            buttonClearSearchString_GAE.Image = (Image)resources.GetObject("buttonClearSearchString_GAE.Image");
            buttonClearSearchString_GAE.Location = new Point(274, 75);
            buttonClearSearchString_GAE.Name = "buttonClearSearchString_GAE";
            buttonClearSearchString_GAE.Size = new Size(29, 29);
            buttonClearSearchString_GAE.TabIndex = 20;
            buttonClearSearchString_GAE.UseVisualStyleBackColor = true;
            buttonClearSearchString_GAE.Click += buttonClearSearchString_GAE_Click;
            // 
            // checkBoxExactMatch_GAE
            // 
            checkBoxExactMatch_GAE.AutoSize = true;
            checkBoxExactMatch_GAE.Location = new Point(12, 110);
            checkBoxExactMatch_GAE.Name = "checkBoxExactMatch_GAE";
            checkBoxExactMatch_GAE.Size = new Size(169, 24);
            checkBoxExactMatch_GAE.TabIndex = 21;
            checkBoxExactMatch_GAE.Text = "Точное совпадение";
            checkBoxExactMatch_GAE.UseVisualStyleBackColor = true;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 189);
            Controls.Add(checkBoxExactMatch_GAE);
            Controls.Add(buttonClearSearchString_GAE);
            Controls.Add(textBoxSearchString_GAE);
            Controls.Add(labelSearchString_GAE);
            Controls.Add(buttonCancel_GAE);
            Controls.Add(buttonFind_GAE);
            Controls.Add(comboBoxSearchType_GAE);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormSearch";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Поиск";
            Load += FormSearch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonCancel_GAE;
        private Button buttonFind_GAE;
        private Label labelSearchString_GAE;
        private Button buttonClearSearchString_GAE;
        public ComboBox comboBoxSearchType_GAE;
        public TextBox textBoxSearchString_GAE;
        public CheckBox checkBoxExactMatch_GAE;
    }
}