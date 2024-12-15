namespace Project.V8
{
    partial class FormFilter
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilter));
            buttonAccept_GAE = new Button();
            buttonCancel_GAE = new Button();
            tabControlFilter_GAE = new TabControl();
            tabPageRegion_GAE = new TabPage();
            checkedListBoxRegion_GAE = new CheckedListBox();
            tabPageBrand_GAE = new TabPage();
            checkedListBoxBrand_GAE = new CheckedListBox();
            tabPageColor_GAE = new TabPage();
            checkedListBoxColor_GAE = new CheckedListBox();
            buttonResetFilter_GAE = new Button();
            toolTipFilter_GAE = new ToolTip(components);
            tabControlFilter_GAE.SuspendLayout();
            tabPageRegion_GAE.SuspendLayout();
            tabPageBrand_GAE.SuspendLayout();
            tabPageColor_GAE.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAccept_GAE
            // 
            buttonAccept_GAE.DialogResult = DialogResult.OK;
            buttonAccept_GAE.Location = new Point(133, 262);
            buttonAccept_GAE.Name = "buttonAccept_GAE";
            buttonAccept_GAE.Size = new Size(98, 29);
            buttonAccept_GAE.TabIndex = 14;
            buttonAccept_GAE.Text = "Применить";
            buttonAccept_GAE.UseVisualStyleBackColor = true;
            // 
            // buttonCancel_GAE
            // 
            buttonCancel_GAE.Location = new Point(42, 262);
            buttonCancel_GAE.Name = "buttonCancel_GAE";
            buttonCancel_GAE.Size = new Size(85, 29);
            buttonCancel_GAE.TabIndex = 15;
            buttonCancel_GAE.Text = "Отмена";
            buttonCancel_GAE.UseVisualStyleBackColor = true;
            buttonCancel_GAE.Click += buttonCancel_GAE_Click;
            // 
            // tabControlFilter_GAE
            // 
            tabControlFilter_GAE.Controls.Add(tabPageRegion_GAE);
            tabControlFilter_GAE.Controls.Add(tabPageBrand_GAE);
            tabControlFilter_GAE.Controls.Add(tabPageColor_GAE);
            tabControlFilter_GAE.Dock = DockStyle.Top;
            tabControlFilter_GAE.Location = new Point(0, 0);
            tabControlFilter_GAE.Name = "tabControlFilter_GAE";
            tabControlFilter_GAE.SelectedIndex = 0;
            tabControlFilter_GAE.Size = new Size(235, 256);
            tabControlFilter_GAE.TabIndex = 16;
            // 
            // tabPageRegion_GAE
            // 
            tabPageRegion_GAE.Controls.Add(checkedListBoxRegion_GAE);
            tabPageRegion_GAE.Location = new Point(4, 29);
            tabPageRegion_GAE.Name = "tabPageRegion_GAE";
            tabPageRegion_GAE.Padding = new Padding(3);
            tabPageRegion_GAE.Size = new Size(227, 223);
            tabPageRegion_GAE.TabIndex = 0;
            tabPageRegion_GAE.Text = "Регион";
            tabPageRegion_GAE.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxRegion_GAE
            // 
            checkedListBoxRegion_GAE.Dock = DockStyle.Fill;
            checkedListBoxRegion_GAE.FormattingEnabled = true;
            checkedListBoxRegion_GAE.Items.AddRange(new object[] { "Москва", "Тюмень", "Тверь", "Екатеринбург", "Санкт-Петербург", "Новосибирск" });
            checkedListBoxRegion_GAE.Location = new Point(3, 3);
            checkedListBoxRegion_GAE.Name = "checkedListBoxRegion_GAE";
            checkedListBoxRegion_GAE.Size = new Size(221, 217);
            checkedListBoxRegion_GAE.TabIndex = 0;
            // 
            // tabPageBrand_GAE
            // 
            tabPageBrand_GAE.Controls.Add(checkedListBoxBrand_GAE);
            tabPageBrand_GAE.Location = new Point(4, 29);
            tabPageBrand_GAE.Name = "tabPageBrand_GAE";
            tabPageBrand_GAE.Padding = new Padding(3);
            tabPageBrand_GAE.Size = new Size(227, 223);
            tabPageBrand_GAE.TabIndex = 1;
            tabPageBrand_GAE.Text = "Марка";
            tabPageBrand_GAE.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxBrand_GAE
            // 
            checkedListBoxBrand_GAE.Dock = DockStyle.Fill;
            checkedListBoxBrand_GAE.FormattingEnabled = true;
            checkedListBoxBrand_GAE.Items.AddRange(new object[] { "Volvo", "Audi", "Nissan", "BMW", "Mercedes", "Opel", "Lada" });
            checkedListBoxBrand_GAE.Location = new Point(3, 3);
            checkedListBoxBrand_GAE.Name = "checkedListBoxBrand_GAE";
            checkedListBoxBrand_GAE.Size = new Size(221, 217);
            checkedListBoxBrand_GAE.TabIndex = 0;
            // 
            // tabPageColor_GAE
            // 
            tabPageColor_GAE.Controls.Add(checkedListBoxColor_GAE);
            tabPageColor_GAE.Location = new Point(4, 29);
            tabPageColor_GAE.Name = "tabPageColor_GAE";
            tabPageColor_GAE.Padding = new Padding(3);
            tabPageColor_GAE.Size = new Size(227, 223);
            tabPageColor_GAE.TabIndex = 2;
            tabPageColor_GAE.Text = "Цвет";
            tabPageColor_GAE.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxColor_GAE
            // 
            checkedListBoxColor_GAE.Dock = DockStyle.Fill;
            checkedListBoxColor_GAE.FormattingEnabled = true;
            checkedListBoxColor_GAE.Items.AddRange(new object[] { "Черный", "Белый", "Серый", "Синий", "Фиолетовый", "Красный", "Розовый", "Желтый", "Зеленый", "Коричневый" });
            checkedListBoxColor_GAE.Location = new Point(3, 3);
            checkedListBoxColor_GAE.Name = "checkedListBoxColor_GAE";
            checkedListBoxColor_GAE.Size = new Size(221, 217);
            checkedListBoxColor_GAE.TabIndex = 0;
            // 
            // buttonResetFilter_GAE
            // 
            buttonResetFilter_GAE.FlatStyle = FlatStyle.Flat;
            buttonResetFilter_GAE.Image = (Image)resources.GetObject("buttonResetFilter_GAE.Image");
            buttonResetFilter_GAE.Location = new Point(7, 262);
            buttonResetFilter_GAE.Name = "buttonResetFilter_GAE";
            buttonResetFilter_GAE.Size = new Size(29, 29);
            buttonResetFilter_GAE.TabIndex = 21;
            toolTipFilter_GAE.SetToolTip(buttonResetFilter_GAE, "Сбросить фильтр");
            buttonResetFilter_GAE.UseVisualStyleBackColor = true;
            buttonResetFilter_GAE.Click += buttonResetFilter_GAE_Click;
            // 
            // FormFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 303);
            Controls.Add(buttonResetFilter_GAE);
            Controls.Add(tabControlFilter_GAE);
            Controls.Add(buttonCancel_GAE);
            Controls.Add(buttonAccept_GAE);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormFilter";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Фильтр";
            Load += FormFilter_Load;
            tabControlFilter_GAE.ResumeLayout(false);
            tabPageRegion_GAE.ResumeLayout(false);
            tabPageBrand_GAE.ResumeLayout(false);
            tabPageColor_GAE.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button buttonAccept_GAE;
        private Button buttonCancel_GAE;
        private TabControl tabControlFilter_GAE;
        private TabPage tabPageRegion_GAE;
        private TabPage tabPageBrand_GAE;
        private TabPage tabPageColor_GAE;
        public CheckedListBox checkedListBoxRegion_GAE;
        public CheckedListBox checkedListBoxBrand_GAE;
        public CheckedListBox checkedListBoxColor_GAE;
        private Button buttonResetFilter_GAE;
        private ToolTip toolTipFilter_GAE;
    }
}