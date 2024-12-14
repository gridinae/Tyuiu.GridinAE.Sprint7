namespace Project.V8
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelMainButtons_GAE = new Panel();
            buttonHelp_GAE = new Button();
            buttonStats_GAE = new Button();
            buttonFilter_GAE = new Button();
            buttonSearch_GAE = new Button();
            buttonEdit_GAE = new Button();
            buttonRemove_GAE = new Button();
            buttonAdd_GAE = new Button();
            dataGridViewMain_GAE = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            Region = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Color = new DataGridViewTextBoxColumn();
            DriverName = new DataGridViewTextBoxColumn();
            DriverPhoneNumber = new DataGridViewTextBoxColumn();
            toolTipMain = new ToolTip(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelItemCount = new ToolStripStatusLabel();
            panelMainButtons_GAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain_GAE).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMainButtons_GAE
            // 
            panelMainButtons_GAE.Controls.Add(buttonHelp_GAE);
            panelMainButtons_GAE.Controls.Add(buttonStats_GAE);
            panelMainButtons_GAE.Controls.Add(buttonFilter_GAE);
            panelMainButtons_GAE.Controls.Add(buttonSearch_GAE);
            panelMainButtons_GAE.Controls.Add(buttonEdit_GAE);
            panelMainButtons_GAE.Controls.Add(buttonRemove_GAE);
            panelMainButtons_GAE.Controls.Add(buttonAdd_GAE);
            panelMainButtons_GAE.Dock = DockStyle.Top;
            panelMainButtons_GAE.Location = new Point(0, 0);
            panelMainButtons_GAE.Name = "panelMainButtons_GAE";
            panelMainButtons_GAE.Size = new Size(782, 61);
            panelMainButtons_GAE.TabIndex = 1;
            // 
            // buttonHelp_GAE
            // 
            buttonHelp_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_GAE.FlatStyle = FlatStyle.Flat;
            buttonHelp_GAE.Image = (Image)resources.GetObject("buttonHelp_GAE.Image");
            buttonHelp_GAE.Location = new Point(723, 3);
            buttonHelp_GAE.Name = "buttonHelp_GAE";
            buttonHelp_GAE.Size = new Size(56, 55);
            buttonHelp_GAE.TabIndex = 7;
            toolTipMain.SetToolTip(buttonHelp_GAE, "Помощь");
            buttonHelp_GAE.UseVisualStyleBackColor = true;
            // 
            // buttonStats_GAE
            // 
            buttonStats_GAE.FlatStyle = FlatStyle.Flat;
            buttonStats_GAE.Image = (Image)resources.GetObject("buttonStats_GAE.Image");
            buttonStats_GAE.Location = new Point(341, 3);
            buttonStats_GAE.Name = "buttonStats_GAE";
            buttonStats_GAE.Size = new Size(56, 55);
            buttonStats_GAE.TabIndex = 6;
            toolTipMain.SetToolTip(buttonStats_GAE, "Статистика");
            buttonStats_GAE.UseVisualStyleBackColor = true;
            // 
            // buttonFilter_GAE
            // 
            buttonFilter_GAE.FlatStyle = FlatStyle.Flat;
            buttonFilter_GAE.Image = (Image)resources.GetObject("buttonFilter_GAE.Image");
            buttonFilter_GAE.Location = new Point(264, 3);
            buttonFilter_GAE.Name = "buttonFilter_GAE";
            buttonFilter_GAE.Size = new Size(56, 55);
            buttonFilter_GAE.TabIndex = 5;
            toolTipMain.SetToolTip(buttonFilter_GAE, "Фильтрация");
            buttonFilter_GAE.UseVisualStyleBackColor = true;
            // 
            // buttonSearch_GAE
            // 
            buttonSearch_GAE.FlatStyle = FlatStyle.Flat;
            buttonSearch_GAE.Image = (Image)resources.GetObject("buttonSearch_GAE.Image");
            buttonSearch_GAE.Location = new Point(202, 3);
            buttonSearch_GAE.Name = "buttonSearch_GAE";
            buttonSearch_GAE.Size = new Size(56, 55);
            buttonSearch_GAE.TabIndex = 3;
            toolTipMain.SetToolTip(buttonSearch_GAE, "Поиск");
            buttonSearch_GAE.UseVisualStyleBackColor = true;
            // 
            // buttonEdit_GAE
            // 
            buttonEdit_GAE.FlatStyle = FlatStyle.Flat;
            buttonEdit_GAE.Image = (Image)resources.GetObject("buttonEdit_GAE.Image");
            buttonEdit_GAE.Location = new Point(127, 3);
            buttonEdit_GAE.Name = "buttonEdit_GAE";
            buttonEdit_GAE.Size = new Size(56, 55);
            buttonEdit_GAE.TabIndex = 2;
            toolTipMain.SetToolTip(buttonEdit_GAE, "Редактировать запись");
            buttonEdit_GAE.UseVisualStyleBackColor = true;
            // 
            // buttonRemove_GAE
            // 
            buttonRemove_GAE.FlatStyle = FlatStyle.Flat;
            buttonRemove_GAE.Image = (Image)resources.GetObject("buttonRemove_GAE.Image");
            buttonRemove_GAE.Location = new Point(65, 3);
            buttonRemove_GAE.Name = "buttonRemove_GAE";
            buttonRemove_GAE.Size = new Size(56, 55);
            buttonRemove_GAE.TabIndex = 1;
            toolTipMain.SetToolTip(buttonRemove_GAE, "Удалить записи");
            buttonRemove_GAE.UseVisualStyleBackColor = true;
            buttonRemove_GAE.Click += buttonRemove_GAE_Click;
            // 
            // buttonAdd_GAE
            // 
            buttonAdd_GAE.FlatStyle = FlatStyle.Flat;
            buttonAdd_GAE.Image = (Image)resources.GetObject("buttonAdd_GAE.Image");
            buttonAdd_GAE.Location = new Point(3, 3);
            buttonAdd_GAE.Name = "buttonAdd_GAE";
            buttonAdd_GAE.Size = new Size(56, 55);
            buttonAdd_GAE.TabIndex = 0;
            toolTipMain.SetToolTip(buttonAdd_GAE, "Добавить запись");
            buttonAdd_GAE.UseVisualStyleBackColor = true;
            buttonAdd_GAE.Click += buttonAdd_GAE_Click;
            // 
            // dataGridViewMain_GAE
            // 
            dataGridViewMain_GAE.AllowUserToAddRows = false;
            dataGridViewMain_GAE.AllowUserToDeleteRows = false;
            dataGridViewMain_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMain_GAE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMain_GAE.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewMain_GAE.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewMain_GAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain_GAE.Columns.AddRange(new DataGridViewColumn[] { Number, Region, Brand, Color, DriverName, DriverPhoneNumber });
            dataGridViewMain_GAE.Location = new Point(0, 61);
            dataGridViewMain_GAE.Name = "dataGridViewMain_GAE";
            dataGridViewMain_GAE.ReadOnly = true;
            dataGridViewMain_GAE.RowHeadersVisible = false;
            dataGridViewMain_GAE.RowHeadersWidth = 51;
            dataGridViewMain_GAE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMain_GAE.Size = new Size(782, 263);
            dataGridViewMain_GAE.TabIndex = 0;
            dataGridViewMain_GAE.RowsAdded += dataGridViewMain_GAE_RowsAdded;
            dataGridViewMain_GAE.RowsRemoved += dataGridViewMain_GAE_RowsRemoved;
            // 
            // Number
            // 
            Number.HeaderText = "Автомобильный Номер";
            Number.MinimumWidth = 6;
            Number.Name = "Number";
            Number.ReadOnly = true;
            // 
            // Region
            // 
            Region.HeaderText = "Регион";
            Region.MinimumWidth = 6;
            Region.Name = "Region";
            Region.ReadOnly = true;
            // 
            // Brand
            // 
            Brand.HeaderText = "Марка";
            Brand.MinimumWidth = 6;
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            // 
            // Color
            // 
            Color.HeaderText = "Цвет";
            Color.MinimumWidth = 6;
            Color.Name = "Color";
            Color.ReadOnly = true;
            // 
            // DriverName
            // 
            DriverName.HeaderText = "ФИО Водителя";
            DriverName.MinimumWidth = 6;
            DriverName.Name = "DriverName";
            DriverName.ReadOnly = true;
            // 
            // DriverPhoneNumber
            // 
            DriverPhoneNumber.HeaderText = "Телефон Водителя";
            DriverPhoneNumber.MinimumWidth = 6;
            DriverPhoneNumber.Name = "DriverPhoneNumber";
            DriverPhoneNumber.ReadOnly = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelItemCount });
            statusStrip1.Location = new Point(0, 327);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(782, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelItemCount
            // 
            toolStripStatusLabelItemCount.Name = "toolStripStatusLabelItemCount";
            toolStripStatusLabelItemCount.Size = new Size(128, 20);
            toolStripStatusLabelItemCount.Text = "Число записей: 0";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 353);
            Controls.Add(statusStrip1);
            Controls.Add(dataGridViewMain_GAE);
            Controls.Add(panelMainButtons_GAE);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 400);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Project.V8";
            Load += FormMain_Load;
            panelMainButtons_GAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain_GAE).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelMainButtons_GAE;
        private DataGridView dataGridViewMain_GAE;
        private Button buttonAdd_GAE;
        private Button buttonEdit_GAE;
        private Button buttonRemove_GAE;
        private Button buttonSearch_GAE;
        private Button buttonHelp_GAE;
        private Button buttonStats_GAE;
        private ToolTip toolTipMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelItemCount;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Region;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn DriverName;
        private DataGridViewTextBoxColumn DriverPhoneNumber;
        private Button buttonFilter_GAE;
    }
}
