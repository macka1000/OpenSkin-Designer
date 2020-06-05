namespace OpenSkinDesigner.Frames
{
    partial class fColors
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
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.labelEditColors = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.textBoxRed = new System.Windows.Forms.MaskedTextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelDecimal1 = new System.Windows.Forms.Label();
            this.labelDecimal3 = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.textBoxBlue = new System.Windows.Forms.MaskedTextBox();
            this.labelDecimal2 = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.textBoxGreen = new System.Windows.Forms.MaskedTextBox();
            this.labelHexadecimal = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.MaskedTextBox();
            this.labelDecimal4 = new System.Windows.Forms.Label();
            this.labelAlpha = new System.Windows.Forms.Label();
            this.textBoxAlpha = new System.Windows.Forms.MaskedTextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBar_Alpha = new System.Windows.Forms.TrackBar();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonPalette = new System.Windows.Forms.Button();
            this.buttonHints = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            this.groupBoxColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Alpha)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEditColors
            // 
            this.labelEditColors.AutoSize = true;
            this.labelEditColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditColors.Location = new System.Drawing.Point(12, 9);
            this.labelEditColors.Name = "labelEditColors";
            this.labelEditColors.Size = new System.Drawing.Size(113, 25);
            this.labelEditColors.TabIndex = 2;
            this.labelEditColors.Text = "Edit colors";
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderValue,
            this.columnHeaderColor});
            this.listView1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 37);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(665, 281);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 455;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Value";
            this.columnHeaderValue.Width = 88;
            // 
            // columnHeaderColor
            // 
            this.columnHeaderColor.Text = "Color";
            this.columnHeaderColor.Width = 101;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(54, 21);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(357, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxColor.BackColor = System.Drawing.Color.White;
            this.pictureBoxColor.Location = new System.Drawing.Point(5, 57);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(122, 122);
            this.pictureBoxColor.TabIndex = 8;
            this.pictureBoxColor.TabStop = false;
            // 
            // textBoxRed
            // 
            this.textBoxRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxRed.AsciiOnly = true;
            this.textBoxRed.BeepOnError = true;
            this.textBoxRed.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRed.Location = new System.Drawing.Point(199, 54);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.PromptChar = '0';
            this.textBoxRed.Size = new System.Drawing.Size(37, 20);
            this.textBoxRed.TabIndex = 9;
            this.textBoxRed.Text = "255";
            this.textBoxRed.TextChanged += new System.EventHandler(this.textBoxRed_TextChanged);
            this.textBoxRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRed_KeyPress);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(602, 545);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(417, 19);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelRed
            // 
            this.labelRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(141, 57);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(27, 13);
            this.labelRed.TabIndex = 12;
            this.labelRed.Text = "Red";
            // 
            // labelDecimal1
            // 
            this.labelDecimal1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDecimal1.AutoSize = true;
            this.labelDecimal1.Location = new System.Drawing.Point(246, 57);
            this.labelDecimal1.Name = "labelDecimal1";
            this.labelDecimal1.Size = new System.Drawing.Size(143, 13);
            this.labelDecimal1.TabIndex = 13;
            this.labelDecimal1.Text = "(in decimal, min=0, max=255)";
            // 
            // labelDecimal3
            // 
            this.labelDecimal3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDecimal3.AutoSize = true;
            this.labelDecimal3.Location = new System.Drawing.Point(246, 109);
            this.labelDecimal3.Name = "labelDecimal3";
            this.labelDecimal3.Size = new System.Drawing.Size(143, 13);
            this.labelDecimal3.TabIndex = 16;
            this.labelDecimal3.Text = "(in decimal, min=0, max=255)";
            // 
            // labelBlue
            // 
            this.labelBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(141, 109);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(28, 13);
            this.labelBlue.TabIndex = 15;
            this.labelBlue.Text = "Blue";
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxBlue.AsciiOnly = true;
            this.textBoxBlue.BeepOnError = true;
            this.textBoxBlue.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBlue.Location = new System.Drawing.Point(199, 106);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.PromptChar = '0';
            this.textBoxBlue.Size = new System.Drawing.Size(37, 20);
            this.textBoxBlue.TabIndex = 14;
            this.textBoxBlue.Text = "255";
            this.textBoxBlue.TextChanged += new System.EventHandler(this.textBoxBlue_TextChanged);
            this.textBoxBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBlue_KeyPress);
            // 
            // labelDecimal2
            // 
            this.labelDecimal2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDecimal2.AutoSize = true;
            this.labelDecimal2.Location = new System.Drawing.Point(246, 83);
            this.labelDecimal2.Name = "labelDecimal2";
            this.labelDecimal2.Size = new System.Drawing.Size(143, 13);
            this.labelDecimal2.TabIndex = 19;
            this.labelDecimal2.Text = "(in decimal, min=0, max=255)";
            // 
            // labelGreen
            // 
            this.labelGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(141, 83);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(36, 13);
            this.labelGreen.TabIndex = 18;
            this.labelGreen.Text = "Green";
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxGreen.AsciiOnly = true;
            this.textBoxGreen.BeepOnError = true;
            this.textBoxGreen.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGreen.Location = new System.Drawing.Point(199, 80);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.PromptChar = '0';
            this.textBoxGreen.Size = new System.Drawing.Size(37, 20);
            this.textBoxGreen.TabIndex = 17;
            this.textBoxGreen.Text = "255";
            this.textBoxGreen.TextChanged += new System.EventHandler(this.textBoxGreen_TextChanged);
            this.textBoxGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGreen_KeyPress);
            // 
            // labelHexadecimal
            // 
            this.labelHexadecimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHexadecimal.AutoSize = true;
            this.labelHexadecimal.Location = new System.Drawing.Point(285, 161);
            this.labelHexadecimal.Name = "labelHexadecimal";
            this.labelHexadecimal.Size = new System.Drawing.Size(83, 13);
            this.labelHexadecimal.TabIndex = 22;
            this.labelHexadecimal.Text = "(in hexadecimal)";
            // 
            // labelValue
            // 
            this.labelValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(141, 161);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(34, 13);
            this.labelValue.TabIndex = 21;
            this.labelValue.Text = "Value";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxValue.AsciiOnly = true;
            this.textBoxValue.BeepOnError = true;
            this.textBoxValue.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValue.Location = new System.Drawing.Point(199, 158);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.PromptChar = '0';
            this.textBoxValue.Size = new System.Drawing.Size(76, 20);
            this.textBoxValue.TabIndex = 20;
            this.textBoxValue.Text = "FFFFFFFF";
            this.textBoxValue.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBoxValue_MaskInputRejected_1);
            this.textBoxValue.TextChanged += new System.EventHandler(this.textBoxValue_TextChanged);
            this.textBoxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValue_KeyPress);
            // 
            // labelDecimal4
            // 
            this.labelDecimal4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDecimal4.AutoSize = true;
            this.labelDecimal4.Location = new System.Drawing.Point(246, 135);
            this.labelDecimal4.Name = "labelDecimal4";
            this.labelDecimal4.Size = new System.Drawing.Size(143, 13);
            this.labelDecimal4.TabIndex = 25;
            this.labelDecimal4.Text = "(in decimal, min=0, max=255)";
            // 
            // labelAlpha
            // 
            this.labelAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAlpha.AutoSize = true;
            this.labelAlpha.Location = new System.Drawing.Point(141, 135);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(34, 13);
            this.labelAlpha.TabIndex = 24;
            this.labelAlpha.Text = "Alpha";
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxAlpha.AsciiOnly = true;
            this.textBoxAlpha.BeepOnError = true;
            this.textBoxAlpha.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlpha.Location = new System.Drawing.Point(199, 132);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.PromptChar = '0';
            this.textBoxAlpha.Size = new System.Drawing.Size(37, 20);
            this.textBoxAlpha.TabIndex = 23;
            this.textBoxAlpha.Text = "255";
            this.textBoxAlpha.TextChanged += new System.EventHandler(this.textBoxAlpha_TextChanged);
            this.textBoxAlpha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlpha_KeyPress);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(498, 19);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 27;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxColor.Controls.Add(this.trackBarBlue);
            this.groupBoxColor.Controls.Add(this.trackBarGreen);
            this.groupBoxColor.Controls.Add(this.trackBarRed);
            this.groupBoxColor.Controls.Add(this.trackBar_Alpha);
            this.groupBoxColor.Controls.Add(this.buttonChange);
            this.groupBoxColor.Controls.Add(this.buttonRemove);
            this.groupBoxColor.Controls.Add(this.buttonPalette);
            this.groupBoxColor.Controls.Add(this.labelDecimal4);
            this.groupBoxColor.Controls.Add(this.buttonAdd);
            this.groupBoxColor.Controls.Add(this.labelAlpha);
            this.groupBoxColor.Controls.Add(this.textBoxAlpha);
            this.groupBoxColor.Controls.Add(this.labelHexadecimal);
            this.groupBoxColor.Controls.Add(this.labelValue);
            this.groupBoxColor.Controls.Add(this.textBoxName);
            this.groupBoxColor.Controls.Add(this.textBoxValue);
            this.groupBoxColor.Controls.Add(this.labelName);
            this.groupBoxColor.Controls.Add(this.labelDecimal2);
            this.groupBoxColor.Controls.Add(this.labelGreen);
            this.groupBoxColor.Controls.Add(this.textBoxGreen);
            this.groupBoxColor.Controls.Add(this.labelDecimal3);
            this.groupBoxColor.Controls.Add(this.labelBlue);
            this.groupBoxColor.Controls.Add(this.textBoxBlue);
            this.groupBoxColor.Controls.Add(this.labelDecimal1);
            this.groupBoxColor.Controls.Add(this.labelRed);
            this.groupBoxColor.Controls.Add(this.textBoxRed);
            this.groupBoxColor.Controls.Add(this.pictureBoxColor);
            this.groupBoxColor.Location = new System.Drawing.Point(12, 323);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(665, 216);
            this.groupBoxColor.TabIndex = 28;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color";
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarBlue.AutoSize = false;
            this.trackBarBlue.Location = new System.Drawing.Point(396, 106);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(263, 29);
            this.trackBarBlue.TabIndex = 31;
            this.trackBarBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBlue.Value = 255;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGreen.AutoSize = false;
            this.trackBarGreen.Location = new System.Drawing.Point(396, 80);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(263, 29);
            this.trackBarGreen.TabIndex = 30;
            this.trackBarGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGreen.Value = 255;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarRed.AutoSize = false;
            this.trackBarRed.Location = new System.Drawing.Point(396, 54);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(263, 29);
            this.trackBarRed.TabIndex = 29;
            this.trackBarRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRed.Value = 255;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBar_Alpha
            // 
            this.trackBar_Alpha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Alpha.AutoSize = false;
            this.trackBar_Alpha.Location = new System.Drawing.Point(396, 132);
            this.trackBar_Alpha.Maximum = 255;
            this.trackBar_Alpha.Name = "trackBar_Alpha";
            this.trackBar_Alpha.Size = new System.Drawing.Size(263, 29);
            this.trackBar_Alpha.TabIndex = 28;
            this.trackBar_Alpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Alpha.Value = 255;
            this.trackBar_Alpha.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChange.Location = new System.Drawing.Point(579, 19);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 27;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // buttonPalette
            // 
            this.buttonPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPalette.Location = new System.Drawing.Point(5, 185);
            this.buttonPalette.Name = "buttonPalette";
            this.buttonPalette.Size = new System.Drawing.Size(122, 23);
            this.buttonPalette.TabIndex = 26;
            this.buttonPalette.Text = "Palette";
            this.buttonPalette.UseVisualStyleBackColor = true;
            this.buttonPalette.Click += new System.EventHandler(this.buttonPallete_Click);
            // 
            // buttonHints
            // 
            this.buttonHints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHints.Location = new System.Drawing.Point(17, 545);
            this.buttonHints.Name = "buttonHints";
            this.buttonHints.Size = new System.Drawing.Size(122, 23);
            this.buttonHints.TabIndex = 29;
            this.buttonHints.Text = "Hints";
            this.buttonHints.UseVisualStyleBackColor = true;
            this.buttonHints.Click += new System.EventHandler(this.button1_Click);
            // 
            // fColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 598);
            this.ControlBox = false;
            this.Controls.Add(this.buttonHints);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelEditColors);
            this.Icon = global::OpenSkinDesigner.Properties.Resources.OpenSkinDesigner;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(705, 950);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(705, 614);
            this.Name = "fColors";
            this.ShowInTaskbar = false;
            this.Text = "Color settings";
            this.Load += new System.EventHandler(this.fColors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Alpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditColors;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.MaskedTextBox textBoxRed;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelDecimal1;
        private System.Windows.Forms.Label labelDecimal3;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.MaskedTextBox textBoxBlue;
        private System.Windows.Forms.Label labelDecimal2;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.MaskedTextBox textBoxGreen;
        private System.Windows.Forms.Label labelHexadecimal;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.MaskedTextBox textBoxValue;
        private System.Windows.Forms.Label labelDecimal4;
        private System.Windows.Forms.Label labelAlpha;
        private System.Windows.Forms.MaskedTextBox textBoxAlpha;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Button buttonPalette;
        private System.Windows.Forms.ColumnHeader columnHeaderColor;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonHints;
        private System.Windows.Forms.TrackBar trackBar_Alpha;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarRed;
    }
}
