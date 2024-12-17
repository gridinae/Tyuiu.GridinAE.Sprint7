namespace Project.V8
{
    partial class FormRTFViewer
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
            richTextBoxManual_GAE = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxManual_GAE
            // 
            richTextBoxManual_GAE.Dock = DockStyle.Fill;
            richTextBoxManual_GAE.Location = new Point(0, 0);
            richTextBoxManual_GAE.Name = "richTextBoxManual_GAE";
            richTextBoxManual_GAE.ReadOnly = true;
            richTextBoxManual_GAE.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richTextBoxManual_GAE.Size = new Size(614, 515);
            richTextBoxManual_GAE.TabIndex = 0;
            richTextBoxManual_GAE.Text = "";
            // 
            // FormRTFViewer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 515);
            Controls.Add(richTextBoxManual_GAE);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormRTFViewer";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Мануал";
            Load += FormRTFViewer_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxManual_GAE;
    }
}