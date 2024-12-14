namespace Project.V8
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxProfilePicture_GAE = new PictureBox();
            buttonOk = new Button();
            labelDev_GAE = new Label();
            labelGroup_GAE = new Label();
            labelCSharp_GAE = new Label();
            labelTyuiu_GAE = new Label();
            label1 = new Label();
            labelInternalName_GAE = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfilePicture_GAE).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProfilePicture_GAE
            // 
            pictureBoxProfilePicture_GAE.Image = (Image)resources.GetObject("pictureBoxProfilePicture_GAE.Image");
            pictureBoxProfilePicture_GAE.InitialImage = null;
            pictureBoxProfilePicture_GAE.Location = new Point(12, 12);
            pictureBoxProfilePicture_GAE.Name = "pictureBoxProfilePicture_GAE";
            pictureBoxProfilePicture_GAE.Size = new Size(133, 202);
            pictureBoxProfilePicture_GAE.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfilePicture_GAE.TabIndex = 0;
            pictureBoxProfilePicture_GAE.TabStop = false;
            // 
            // buttonOk
            // 
            buttonOk.FlatStyle = FlatStyle.Flat;
            buttonOk.Location = new Point(441, 185);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "Ок";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // labelDev_GAE
            // 
            labelDev_GAE.AutoSize = true;
            labelDev_GAE.Location = new Point(151, 12);
            labelDev_GAE.Name = "labelDev_GAE";
            labelDev_GAE.Size = new Size(187, 20);
            labelDev_GAE.TabIndex = 2;
            labelDev_GAE.Text = "Разработчик: Гридин А. Е.";
            // 
            // labelGroup_GAE
            // 
            labelGroup_GAE.AutoSize = true;
            labelGroup_GAE.Location = new Point(151, 32);
            labelGroup_GAE.Name = "labelGroup_GAE";
            labelGroup_GAE.Size = new Size(139, 20);
            labelGroup_GAE.TabIndex = 3;
            labelGroup_GAE.Text = "группа ИИПБ-24-2";
            // 
            // labelCSharp_GAE
            // 
            labelCSharp_GAE.AutoSize = true;
            labelCSharp_GAE.Location = new Point(151, 63);
            labelCSharp_GAE.Name = "labelCSharp_GAE";
            labelCSharp_GAE.Size = new Size(387, 20);
            labelCSharp_GAE.TabIndex = 4;
            labelCSharp_GAE.Text = "Программа разработана в рамках изучения языка C#";
            // 
            // labelTyuiu_GAE
            // 
            labelTyuiu_GAE.AutoSize = true;
            labelTyuiu_GAE.Location = new Point(151, 95);
            labelTyuiu_GAE.Name = "labelTyuiu_GAE";
            labelTyuiu_GAE.Size = new Size(357, 20);
            labelTyuiu_GAE.TabIndex = 5;
            labelTyuiu_GAE.Text = "Тюменский индустриальный университет (с) 2024";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 115);
            label1.Name = "label1";
            label1.Size = new Size(329, 20);
            label1.TabIndex = 6;
            label1.Text = "Высшая школа цифровых технологий (с) 2024";
            // 
            // labelInternalName_GAE
            // 
            labelInternalName_GAE.AutoSize = true;
            labelInternalName_GAE.Location = new Point(151, 151);
            labelInternalName_GAE.Name = "labelInternalName_GAE";
            labelInternalName_GAE.Size = new Size(196, 20);
            labelInternalName_GAE.TabIndex = 7;
            labelInternalName_GAE.Text = "Внутреннее имя: Project.V8";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 226);
            Controls.Add(labelInternalName_GAE);
            Controls.Add(label1);
            Controls.Add(labelTyuiu_GAE);
            Controls.Add(labelCSharp_GAE);
            Controls.Add(labelGroup_GAE);
            Controls.Add(labelDev_GAE);
            Controls.Add(buttonOk);
            Controls.Add(pictureBoxProfilePicture_GAE);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfilePicture_GAE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxProfilePicture_GAE;
        private Button buttonOk;
        private Label labelDev_GAE;
        private Label labelGroup_GAE;
        private Label labelCSharp_GAE;
        private Label labelTyuiu_GAE;
        private Label label1;
        private Label labelInternalName_GAE;
    }
}