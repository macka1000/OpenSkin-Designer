namespace OpenSkinDesigner.Frames
{
    partial class fResolution
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
            this.groupBoxResolution = new System.Windows.Forms.GroupBox();
            this.radioButton1080 = new System.Windows.Forms.RadioButton();
            this.radioButton720 = new System.Windows.Forms.RadioButton();
            this.labelChooseResolution = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.groupBoxResolution.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxResolution
            // 
            this.groupBoxResolution.Controls.Add(this.radioButton1080);
            this.groupBoxResolution.Controls.Add(this.radioButton720);
            this.groupBoxResolution.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxResolution.Location = new System.Drawing.Point(17, 37);
            this.groupBoxResolution.Name = "groupBoxResolution";
            this.groupBoxResolution.Size = new System.Drawing.Size(235, 86);
            this.groupBoxResolution.TabIndex = 0;
            this.groupBoxResolution.TabStop = false;
            this.groupBoxResolution.Text = "Resolution";
            // 
            // radioButton1080
            // 
            this.radioButton1080.AutoSize = true;
            this.radioButton1080.Location = new System.Drawing.Point(30, 52);
            this.radioButton1080.Name = "radioButton1080";
            this.radioButton1080.Size = new System.Drawing.Size(108, 17);
            this.radioButton1080.TabIndex = 2;
            this.radioButton1080.TabStop = true;
            this.radioButton1080.Text = "1920x1080 (16:9)";
            this.radioButton1080.UseVisualStyleBackColor = true;
            // 
            // radioButton720
            // 
            this.radioButton720.AutoSize = true;
            this.radioButton720.Location = new System.Drawing.Point(30, 29);
            this.radioButton720.Name = "radioButton720";
            this.radioButton720.Size = new System.Drawing.Size(102, 17);
            this.radioButton720.TabIndex = 1;
            this.radioButton720.TabStop = true;
            this.radioButton720.Text = "1280x720 (16:9)";
            this.radioButton720.UseVisualStyleBackColor = true;
            // 
            // labelChooseResolution
            // 
            this.labelChooseResolution.AutoSize = true;
            this.labelChooseResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseResolution.Location = new System.Drawing.Point(12, 9);
            this.labelChooseResolution.Name = "labelChooseResolution";
            this.labelChooseResolution.Size = new System.Drawing.Size(230, 25);
            this.labelChooseResolution.TabIndex = 1;
            this.labelChooseResolution.Text = "Choose the Resolution";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(14, 136);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(311, 13);
            this.labelNote.TabIndex = 2;
            this.labelNote.Text = "Note: Changing the Resolution will result in rescaling of the skin. ";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(258, 100);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // fResolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 161);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelChooseResolution);
            this.Controls.Add(this.groupBoxResolution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::OpenSkinDesigner.Properties.Resources.OpenSkinDesigner;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(364, 200);
            this.Name = "fResolution";
            this.ShowInTaskbar = false;
            this.Text = "Resolution Settings";
            this.groupBoxResolution.ResumeLayout(false);
            this.groupBoxResolution.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResolution;
        private System.Windows.Forms.RadioButton radioButton1080;
        private System.Windows.Forms.RadioButton radioButton720;
        private System.Windows.Forms.Label labelChooseResolution;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Button buttonChange;
    }
}
