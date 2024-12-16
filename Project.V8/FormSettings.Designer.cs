namespace Project.V8
{
    partial class FormSettings
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
            tabControlSettings_GAE = new TabControl();
            tabPageCellStyle_GAE = new TabPage();
            panelSelectionFgColor_GAE = new Panel();
            panelSelectionBgColor_GAE = new Panel();
            buttonChangeSelectionFgColor_GAE = new Button();
            label1 = new Label();
            buttonChangeSelectionBgColor_GAE = new Button();
            labelSelectionBgColor_GAE = new Label();
            buttonChangeFont_GAE = new Button();
            labelFont_GAE = new Label();
            buttonAccept_GAE = new Button();
            buttonCancel_GAE = new Button();
            buttonReset_GAE = new Button();
            colorDialogBg_GAE = new ColorDialog();
            colorDialogFg_GAE = new ColorDialog();
            fontDialog_GAE = new FontDialog();
            tabControlSettings_GAE.SuspendLayout();
            tabPageCellStyle_GAE.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlSettings_GAE
            // 
            tabControlSettings_GAE.Controls.Add(tabPageCellStyle_GAE);
            tabControlSettings_GAE.Dock = DockStyle.Top;
            tabControlSettings_GAE.Location = new Point(0, 0);
            tabControlSettings_GAE.Name = "tabControlSettings_GAE";
            tabControlSettings_GAE.SelectedIndex = 0;
            tabControlSettings_GAE.Size = new Size(387, 270);
            tabControlSettings_GAE.TabIndex = 0;
            // 
            // tabPageCellStyle_GAE
            // 
            tabPageCellStyle_GAE.Controls.Add(panelSelectionFgColor_GAE);
            tabPageCellStyle_GAE.Controls.Add(panelSelectionBgColor_GAE);
            tabPageCellStyle_GAE.Controls.Add(buttonChangeSelectionFgColor_GAE);
            tabPageCellStyle_GAE.Controls.Add(label1);
            tabPageCellStyle_GAE.Controls.Add(buttonChangeSelectionBgColor_GAE);
            tabPageCellStyle_GAE.Controls.Add(labelSelectionBgColor_GAE);
            tabPageCellStyle_GAE.Controls.Add(buttonChangeFont_GAE);
            tabPageCellStyle_GAE.Controls.Add(labelFont_GAE);
            tabPageCellStyle_GAE.Location = new Point(4, 29);
            tabPageCellStyle_GAE.Name = "tabPageCellStyle_GAE";
            tabPageCellStyle_GAE.Padding = new Padding(3);
            tabPageCellStyle_GAE.Size = new Size(379, 237);
            tabPageCellStyle_GAE.TabIndex = 0;
            tabPageCellStyle_GAE.Text = "Стиль ячеек";
            tabPageCellStyle_GAE.UseVisualStyleBackColor = true;
            // 
            // panelSelectionFgColor_GAE
            // 
            panelSelectionFgColor_GAE.BackColor = Color.Black;
            panelSelectionFgColor_GAE.BorderStyle = BorderStyle.Fixed3D;
            panelSelectionFgColor_GAE.Location = new Point(249, 161);
            panelSelectionFgColor_GAE.Name = "panelSelectionFgColor_GAE";
            panelSelectionFgColor_GAE.Size = new Size(22, 22);
            panelSelectionFgColor_GAE.TabIndex = 9;
            // 
            // panelSelectionBgColor_GAE
            // 
            panelSelectionBgColor_GAE.BackColor = Color.Black;
            panelSelectionBgColor_GAE.BorderStyle = BorderStyle.Fixed3D;
            panelSelectionBgColor_GAE.Location = new Point(243, 84);
            panelSelectionBgColor_GAE.Name = "panelSelectionBgColor_GAE";
            panelSelectionBgColor_GAE.Size = new Size(22, 22);
            panelSelectionBgColor_GAE.TabIndex = 8;
            // 
            // buttonChangeSelectionFgColor_GAE
            // 
            buttonChangeSelectionFgColor_GAE.Location = new Point(8, 186);
            buttonChangeSelectionFgColor_GAE.Name = "buttonChangeSelectionFgColor_GAE";
            buttonChangeSelectionFgColor_GAE.Size = new Size(106, 29);
            buttonChangeSelectionFgColor_GAE.TabIndex = 7;
            buttonChangeSelectionFgColor_GAE.Text = "Изменить шрифт";
            buttonChangeSelectionFgColor_GAE.UseVisualStyleBackColor = true;
            buttonChangeSelectionFgColor_GAE.Click += buttonChangeSelectionFgColor_GAE_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 163);
            label1.Name = "label1";
            label1.Size = new Size(235, 20);
            label1.TabIndex = 6;
            label1.Text = "Цвет текста выделенной ячейки:";
            // 
            // buttonChangeSelectionBgColor_GAE
            // 
            buttonChangeSelectionBgColor_GAE.Location = new Point(8, 109);
            buttonChangeSelectionBgColor_GAE.Name = "buttonChangeSelectionBgColor_GAE";
            buttonChangeSelectionBgColor_GAE.Size = new Size(106, 29);
            buttonChangeSelectionBgColor_GAE.TabIndex = 5;
            buttonChangeSelectionBgColor_GAE.Text = "Изменить шрифт";
            buttonChangeSelectionBgColor_GAE.UseVisualStyleBackColor = true;
            buttonChangeSelectionBgColor_GAE.Click += buttonChangeSelectionBgColor_GAE_Click;
            // 
            // labelSelectionBgColor_GAE
            // 
            labelSelectionBgColor_GAE.AutoSize = true;
            labelSelectionBgColor_GAE.Location = new Point(8, 84);
            labelSelectionBgColor_GAE.Name = "labelSelectionBgColor_GAE";
            labelSelectionBgColor_GAE.Size = new Size(229, 20);
            labelSelectionBgColor_GAE.TabIndex = 4;
            labelSelectionBgColor_GAE.Text = "Цвет фона выделенной ячейки:";
            // 
            // buttonChangeFont_GAE
            // 
            buttonChangeFont_GAE.Location = new Point(8, 37);
            buttonChangeFont_GAE.Name = "buttonChangeFont_GAE";
            buttonChangeFont_GAE.Size = new Size(106, 29);
            buttonChangeFont_GAE.TabIndex = 3;
            buttonChangeFont_GAE.Text = "Изменить шрифт";
            buttonChangeFont_GAE.UseVisualStyleBackColor = true;
            buttonChangeFont_GAE.Click += buttonChangeFont_GAE_Click;
            // 
            // labelFont_GAE
            // 
            labelFont_GAE.AutoSize = true;
            labelFont_GAE.Location = new Point(8, 14);
            labelFont_GAE.Name = "labelFont_GAE";
            labelFont_GAE.Size = new Size(64, 20);
            labelFont_GAE.TabIndex = 0;
            labelFont_GAE.Text = "Шрифт: ";
            // 
            // buttonAccept_GAE
            // 
            buttonAccept_GAE.DialogResult = DialogResult.OK;
            buttonAccept_GAE.Location = new Point(266, 279);
            buttonAccept_GAE.Name = "buttonAccept_GAE";
            buttonAccept_GAE.Size = new Size(109, 29);
            buttonAccept_GAE.TabIndex = 1;
            buttonAccept_GAE.Text = "Применить";
            buttonAccept_GAE.UseVisualStyleBackColor = true;
            // 
            // buttonCancel_GAE
            // 
            buttonCancel_GAE.Location = new Point(177, 279);
            buttonCancel_GAE.Name = "buttonCancel_GAE";
            buttonCancel_GAE.Size = new Size(83, 29);
            buttonCancel_GAE.TabIndex = 2;
            buttonCancel_GAE.Text = "Отмена";
            buttonCancel_GAE.UseVisualStyleBackColor = true;
            buttonCancel_GAE.Click += buttonCancel_GAE_Click;
            // 
            // buttonReset_GAE
            // 
            buttonReset_GAE.Location = new Point(12, 279);
            buttonReset_GAE.Name = "buttonReset_GAE";
            buttonReset_GAE.Size = new Size(86, 29);
            buttonReset_GAE.TabIndex = 3;
            buttonReset_GAE.Text = "Сбросить";
            buttonReset_GAE.UseVisualStyleBackColor = true;
            buttonReset_GAE.Click += buttonReset_GAE_Click;
            // 
            // colorDialogBg_GAE
            // 
            colorDialogBg_GAE.SolidColorOnly = true;
            // 
            // colorDialogFg_GAE
            // 
            colorDialogFg_GAE.SolidColorOnly = true;
            // 
            // fontDialog_GAE
            // 
            fontDialog_GAE.FontMustExist = true;
            fontDialog_GAE.ShowApply = true;
            fontDialog_GAE.ShowEffects = false;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 320);
            Controls.Add(buttonReset_GAE);
            Controls.Add(buttonCancel_GAE);
            Controls.Add(buttonAccept_GAE);
            Controls.Add(tabControlSettings_GAE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormSettings";
            ShowIcon = false;
            Text = "Настройки";
            Load += FormSettings_Load;
            tabControlSettings_GAE.ResumeLayout(false);
            tabPageCellStyle_GAE.ResumeLayout(false);
            tabPageCellStyle_GAE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlSettings_GAE;
        private TabPage tabPageCellStyle_GAE;
        private Button buttonAccept_GAE;
        private Button buttonCancel_GAE;
        private Button buttonChangeFont_GAE;
        private Label labelSelectionBgColor_GAE;
        private Button buttonChangeSelectionFgColor_GAE;
        private Label label1;
        private Button buttonChangeSelectionBgColor_GAE;
        public Label labelFont_GAE;
        public Panel panelSelectionBgColor_GAE;
        public Panel panelSelectionFgColor_GAE;
        private Button buttonReset_GAE;
        private ColorDialog colorDialogBg_GAE;
        private ColorDialog colorDialogFg_GAE;
        public FontDialog fontDialog_GAE;
    }
}