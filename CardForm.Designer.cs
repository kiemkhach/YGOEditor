namespace YGOEditor
{
    partial class CardForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardForm));
            this.txtFileNameMiniPic = new System.Windows.Forms.TextBox();
            this.lblFileNameMiniPic = new System.Windows.Forms.Label();
            this.txtFileNamePic = new System.Windows.Forms.TextBox();
            this.lblFileNamePic = new System.Windows.Forms.Label();
            this.miniPicture = new System.Windows.Forms.PictureBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.lblFileTypePic = new System.Windows.Forms.Label();
            this.txtFileTypePic = new System.Windows.Forms.TextBox();
            this.lblFileTypeMiniPic = new System.Windows.Forms.Label();
            this.txtFileTypeMiniPic = new System.Windows.Forms.TextBox();
            this.groupCollection = new System.Windows.Forms.GroupBox();
            this.CardList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yuGiCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableRight = new System.Windows.Forms.TableLayoutPanel();
            this.tablePicture = new System.Windows.Forms.TableLayoutPanel();
            this.groupPicture = new System.Windows.Forms.GroupBox();
            this.groupMiniPicture = new System.Windows.Forms.GroupBox();
            this.groupCardInfo = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbbLang = new System.Windows.Forms.ComboBox();
            this.rtxtDesc = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDef = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAtk = new System.Windows.Forms.TextBox();
            this.txtPack = new System.Windows.Forms.TextBox();
            this.txtAtt = new System.Windows.Forms.TextBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.txtDescOffest = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDef = new System.Windows.Forms.Label();
            this.tbtAtk = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblPack = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblAtt = new System.Windows.Forms.Label();
            this.LblDescOffset = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCardIndex = new System.Windows.Forms.Label();
            this.tableLeft = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.miniPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.groupCollection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yuGiCardBindingSource)).BeginInit();
            this.tableRight.SuspendLayout();
            this.tablePicture.SuspendLayout();
            this.groupPicture.SuspendLayout();
            this.groupMiniPicture.SuspendLayout();
            this.groupCardInfo.SuspendLayout();
            this.tableLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileNameMiniPic
            // 
            this.txtFileNameMiniPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileNameMiniPic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yuGiCardBindingSource, "CardImageNameMini", true));
            this.txtFileNameMiniPic.Location = new System.Drawing.Point(117, 75);
            this.txtFileNameMiniPic.MaxLength = 6;
            this.txtFileNameMiniPic.Name = "txtFileNameMiniPic";
            this.txtFileNameMiniPic.Size = new System.Drawing.Size(155, 26);
            this.txtFileNameMiniPic.TabIndex = 5;
            // 
            // lblFileNameMiniPic
            // 
            this.lblFileNameMiniPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileNameMiniPic.AutoSize = true;
            this.lblFileNameMiniPic.Location = new System.Drawing.Point(117, 52);
            this.lblFileNameMiniPic.Name = "lblFileNameMiniPic";
            this.lblFileNameMiniPic.Size = new System.Drawing.Size(92, 20);
            this.lblFileNameMiniPic.TabIndex = 4;
            this.lblFileNameMiniPic.Text = "File Name : ";
            // 
            // txtFileNamePic
            // 
            this.txtFileNamePic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileNamePic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yuGiCardBindingSource, "CardImageName", true));
            this.txtFileNamePic.Location = new System.Drawing.Point(111, 454);
            this.txtFileNamePic.MaxLength = 6;
            this.txtFileNamePic.Name = "txtFileNamePic";
            this.txtFileNamePic.Size = new System.Drawing.Size(161, 26);
            this.txtFileNamePic.TabIndex = 3;
            // 
            // lblFileNamePic
            // 
            this.lblFileNamePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFileNamePic.AutoSize = true;
            this.lblFileNamePic.Location = new System.Drawing.Point(6, 457);
            this.lblFileNamePic.Name = "lblFileNamePic";
            this.lblFileNamePic.Size = new System.Drawing.Size(92, 20);
            this.lblFileNamePic.TabIndex = 2;
            this.lblFileNamePic.Text = "File Name : ";
            // 
            // miniPicture
            // 
            this.miniPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.miniPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.miniPicture.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.yuGiCardBindingSource, "CardImageMini", true));
            this.miniPicture.Location = new System.Drawing.Point(6, 25);
            this.miniPicture.Name = "miniPicture";
            this.miniPicture.Size = new System.Drawing.Size(105, 137);
            this.miniPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.miniPicture.TabIndex = 1;
            this.miniPicture.TabStop = false;
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.yuGiCardBindingSource, "CardImage", true));
            this.picture.Location = new System.Drawing.Point(6, 25);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(266, 422);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // lblFileTypePic
            // 
            this.lblFileTypePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFileTypePic.AutoSize = true;
            this.lblFileTypePic.Location = new System.Drawing.Point(6, 489);
            this.lblFileTypePic.Name = "lblFileTypePic";
            this.lblFileTypePic.Size = new System.Drawing.Size(84, 20);
            this.lblFileTypePic.TabIndex = 7;
            this.lblFileTypePic.Text = "File Type : ";
            // 
            // txtFileTypePic
            // 
            this.txtFileTypePic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileTypePic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yuGiCardBindingSource, "CardImageType", true));
            this.txtFileTypePic.Location = new System.Drawing.Point(111, 486);
            this.txtFileTypePic.MaxLength = 6;
            this.txtFileTypePic.Name = "txtFileTypePic";
            this.txtFileTypePic.ReadOnly = true;
            this.txtFileTypePic.Size = new System.Drawing.Size(161, 26);
            this.txtFileTypePic.TabIndex = 8;
            // 
            // lblFileTypeMiniPic
            // 
            this.lblFileTypeMiniPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileTypeMiniPic.AutoSize = true;
            this.lblFileTypeMiniPic.Location = new System.Drawing.Point(113, 113);
            this.lblFileTypeMiniPic.Name = "lblFileTypeMiniPic";
            this.lblFileTypeMiniPic.Size = new System.Drawing.Size(84, 20);
            this.lblFileTypeMiniPic.TabIndex = 10;
            this.lblFileTypeMiniPic.Text = "File Type : ";
            // 
            // txtFileTypeMiniPic
            // 
            this.txtFileTypeMiniPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileTypeMiniPic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yuGiCardBindingSource, "CardImageMiniType", true));
            this.txtFileTypeMiniPic.Location = new System.Drawing.Point(117, 136);
            this.txtFileTypeMiniPic.MaxLength = 6;
            this.txtFileTypeMiniPic.Name = "txtFileTypeMiniPic";
            this.txtFileTypeMiniPic.ReadOnly = true;
            this.txtFileTypeMiniPic.Size = new System.Drawing.Size(155, 26);
            this.txtFileTypeMiniPic.TabIndex = 11;
            // 
            // groupCollection
            // 
            this.groupCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCollection.Controls.Add(this.CardList);
            this.groupCollection.Location = new System.Drawing.Point(3, 3);
            this.groupCollection.Name = "groupCollection";
            this.groupCollection.Size = new System.Drawing.Size(433, 713);
            this.groupCollection.TabIndex = 4;
            this.groupCollection.TabStop = false;
            this.groupCollection.Text = "Collection";
            // 
            // CardList
            // 
            this.CardList.AllowUserToResizeRows = false;
            this.CardList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardList.AutoGenerateColumns = false;
            this.CardList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CardList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.CardList.DataSource = this.yuGiCardBindingSource;
            this.CardList.Location = new System.Drawing.Point(6, 25);
            this.CardList.MultiSelect = false;
            this.CardList.Name = "CardList";
            this.CardList.ReadOnly = true;
            this.CardList.RowHeadersVisible = false;
            this.CardList.RowHeadersWidth = 62;
            this.CardList.RowTemplate.Height = 28;
            this.CardList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CardList.Size = new System.Drawing.Size(421, 676);
            this.CardList.TabIndex = 0;
            this.CardList.SelectionChanged += new System.EventHandler(this.CardList_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CardIdx";
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CardId";
            this.dataGridViewTextBoxColumn2.HeaderText = "CardId";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CardName";
            this.dataGridViewTextBoxColumn3.HeaderText = "CardName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // yuGiCardBindingSource
            // 
            this.yuGiCardBindingSource.DataSource = typeof(YGOEditor.Structure.YuGiCard);
            // 
            // tableRight
            // 
            this.tableRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableRight.ColumnCount = 2;
            this.tableRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableRight.Controls.Add(this.tablePicture, 0, 0);
            this.tableRight.Controls.Add(this.groupCardInfo, 1, 0);
            this.tableRight.Location = new System.Drawing.Point(454, 13);
            this.tableRight.Margin = new System.Windows.Forms.Padding(0);
            this.tableRight.Name = "tableRight";
            this.tableRight.RowCount = 1;
            this.tableRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRight.Size = new System.Drawing.Size(712, 719);
            this.tableRight.TabIndex = 5;
            // 
            // tablePicture
            // 
            this.tablePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePicture.ColumnCount = 1;
            this.tablePicture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePicture.Controls.Add(this.groupPicture, 0, 0);
            this.tablePicture.Controls.Add(this.groupMiniPicture, 0, 1);
            this.tablePicture.Location = new System.Drawing.Point(0, 0);
            this.tablePicture.Margin = new System.Windows.Forms.Padding(0);
            this.tablePicture.Name = "tablePicture";
            this.tablePicture.RowCount = 2;
            this.tablePicture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tablePicture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePicture.Size = new System.Drawing.Size(284, 719);
            this.tablePicture.TabIndex = 0;
            // 
            // groupPicture
            // 
            this.groupPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPicture.Controls.Add(this.picture);
            this.groupPicture.Controls.Add(this.lblFileNamePic);
            this.groupPicture.Controls.Add(this.txtFileNamePic);
            this.groupPicture.Controls.Add(this.lblFileTypePic);
            this.groupPicture.Controls.Add(this.txtFileTypePic);
            this.groupPicture.Location = new System.Drawing.Point(3, 3);
            this.groupPicture.Name = "groupPicture";
            this.groupPicture.Size = new System.Drawing.Size(278, 533);
            this.groupPicture.TabIndex = 0;
            this.groupPicture.TabStop = false;
            this.groupPicture.Text = "Picture";
            // 
            // groupMiniPicture
            // 
            this.groupMiniPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupMiniPicture.Controls.Add(this.miniPicture);
            this.groupMiniPicture.Controls.Add(this.txtFileTypeMiniPic);
            this.groupMiniPicture.Controls.Add(this.lblFileNameMiniPic);
            this.groupMiniPicture.Controls.Add(this.lblFileTypeMiniPic);
            this.groupMiniPicture.Controls.Add(this.txtFileNameMiniPic);
            this.groupMiniPicture.Location = new System.Drawing.Point(3, 542);
            this.groupMiniPicture.Name = "groupMiniPicture";
            this.groupMiniPicture.Size = new System.Drawing.Size(278, 174);
            this.groupMiniPicture.TabIndex = 0;
            this.groupMiniPicture.TabStop = false;
            this.groupMiniPicture.Text = "Mini Picture";
            // 
            // groupCardInfo
            // 
            this.groupCardInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCardInfo.Controls.Add(this.btnClose);
            this.groupCardInfo.Controls.Add(this.btnSave);
            this.groupCardInfo.Controls.Add(this.cbbLang);
            this.groupCardInfo.Controls.Add(this.rtxtDesc);
            this.groupCardInfo.Controls.Add(this.textBox3);
            this.groupCardInfo.Controls.Add(this.txtLevel);
            this.groupCardInfo.Controls.Add(this.textBox1);
            this.groupCardInfo.Controls.Add(this.txtDef);
            this.groupCardInfo.Controls.Add(this.txtType);
            this.groupCardInfo.Controls.Add(this.txtAtk);
            this.groupCardInfo.Controls.Add(this.txtPack);
            this.groupCardInfo.Controls.Add(this.txtAtt);
            this.groupCardInfo.Controls.Add(this.txtOrder);
            this.groupCardInfo.Controls.Add(this.txtDescOffest);
            this.groupCardInfo.Controls.Add(this.txtPass);
            this.groupCardInfo.Controls.Add(this.label3);
            this.groupCardInfo.Controls.Add(this.lblDef);
            this.groupCardInfo.Controls.Add(this.tbtAtk);
            this.groupCardInfo.Controls.Add(this.txtID);
            this.groupCardInfo.Controls.Add(this.lblPack);
            this.groupCardInfo.Controls.Add(this.lblLevel);
            this.groupCardInfo.Controls.Add(this.txtIndex);
            this.groupCardInfo.Controls.Add(this.lblType);
            this.groupCardInfo.Controls.Add(this.lblOrder);
            this.groupCardInfo.Controls.Add(this.lblAtt);
            this.groupCardInfo.Controls.Add(this.LblDescOffset);
            this.groupCardInfo.Controls.Add(this.label1);
            this.groupCardInfo.Controls.Add(this.lblPass);
            this.groupCardInfo.Controls.Add(this.lblDesc);
            this.groupCardInfo.Controls.Add(this.lblLang);
            this.groupCardInfo.Controls.Add(this.label2);
            this.groupCardInfo.Controls.Add(this.lblCardIndex);
            this.groupCardInfo.Location = new System.Drawing.Point(288, 3);
            this.groupCardInfo.Name = "groupCardInfo";
            this.groupCardInfo.Size = new System.Drawing.Size(421, 713);
            this.groupCardInfo.TabIndex = 1;
            this.groupCardInfo.TabStop = false;
            this.groupCardInfo.Text = "Card Detail";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(276, 652);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 49);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(60, 652);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 49);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cbbLang
            // 
            this.cbbLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLang.FormattingEnabled = true;
            this.cbbLang.Items.AddRange(new object[] {
            "eng",
            "fra",
            "ger",
            "ita",
            "jpn",
            "spa"});
            this.cbbLang.Location = new System.Drawing.Point(100, 615);
            this.cbbLang.Name = "cbbLang";
            this.cbbLang.Size = new System.Drawing.Size(94, 28);
            this.cbbLang.TabIndex = 3;
            this.cbbLang.SelectedValueChanged += new System.EventHandler(this.cbbLang_SelectedValueChanged);
            // 
            // rtxtDesc
            // 
            this.rtxtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yuGiCardBindingSource, "CardDesc", true));
            this.rtxtDesc.Location = new System.Drawing.Point(9, 150);
            this.rtxtDesc.Name = "rtxtDesc";
            this.rtxtDesc.Size = new System.Drawing.Size(393, 190);
            this.rtxtDesc.TabIndex = 2;
            this.rtxtDesc.Text = "";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yuGiCardBindingSource, "CardName", true));
            this.textBox3.Location = new System.Drawing.Point(100, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(302, 26);
            this.textBox3.TabIndex = 1;
            // 
            // txtLevel
            // 
            this.txtLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yuGiCardBindingSource, "CardLevel", true));
            this.txtLevel.Location = new System.Drawing.Point(100, 465);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(94, 26);
            this.txtLevel.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(308, 465);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 26);
            this.textBox1.TabIndex = 1;
            // 
            // txtDef
            // 
            this.txtDef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDef.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yuGiCardBindingSource, "CardDef", true));
            this.txtDef.Location = new System.Drawing.Point(308, 565);
            this.txtDef.Name = "txtDef";
            this.txtDef.Size = new System.Drawing.Size(94, 26);
            this.txtDef.TabIndex = 1;
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yuGiCardBindingSource, "CardType", true));
            this.txtType.Location = new System.Drawing.Point(100, 565);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(94, 26);
            this.txtType.TabIndex = 1;
            // 
            // txtAtk
            // 
            this.txtAtk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAtk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yuGiCardBindingSource, "CardAtk", true));
            this.txtAtk.Location = new System.Drawing.Point(308, 515);
            this.txtAtk.Name = "txtAtk";
            this.txtAtk.Size = new System.Drawing.Size(94, 26);
            this.txtAtk.TabIndex = 1;
            // 
            // txtPack
            // 
            this.txtPack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPack.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yuGiCardBindingSource, "CardPack", true));
            this.txtPack.Location = new System.Drawing.Point(308, 415);
            this.txtPack.Name = "txtPack";
            this.txtPack.Size = new System.Drawing.Size(94, 26);
            this.txtPack.TabIndex = 1;
            // 
            // txtAtt
            // 
            this.txtAtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAtt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yuGiCardBindingSource, "CardAtb", true));
            this.txtAtt.Location = new System.Drawing.Point(100, 515);
            this.txtAtt.Name = "txtAtt";
            this.txtAtt.Size = new System.Drawing.Size(94, 26);
            this.txtAtt.TabIndex = 1;
            // 
            // txtOrder
            // 
            this.txtOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yuGiCardBindingSource, "CardOrderId", true));
            this.txtOrder.Location = new System.Drawing.Point(308, 365);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(94, 26);
            this.txtOrder.TabIndex = 1;
            // 
            // txtDescOffest
            // 
            this.txtDescOffest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescOffest.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yuGiCardBindingSource, "CardDescOffset", true));
            this.txtDescOffest.Location = new System.Drawing.Point(100, 365);
            this.txtDescOffest.Name = "txtDescOffest";
            this.txtDescOffest.ReadOnly = true;
            this.txtDescOffest.Size = new System.Drawing.Size(94, 26);
            this.txtDescOffest.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Location = new System.Drawing.Point(100, 415);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(94, 26);
            this.txtPass.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sort";
            // 
            // lblDef
            // 
            this.lblDef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDef.AutoSize = true;
            this.lblDef.Location = new System.Drawing.Point(229, 568);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(70, 20);
            this.lblDef.TabIndex = 0;
            this.lblDef.Text = "Defense";
            // 
            // tbtAtk
            // 
            this.tbtAtk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbtAtk.AutoSize = true;
            this.tbtAtk.Location = new System.Drawing.Point(230, 518);
            this.tbtAtk.Name = "tbtAtk";
            this.tbtAtk.Size = new System.Drawing.Size(55, 20);
            this.tbtAtk.TabIndex = 0;
            this.tbtAtk.Text = "Attack";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yuGiCardBindingSource, "CardId", true));
            this.txtID.Location = new System.Drawing.Point(308, 25);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(94, 26);
            this.txtID.TabIndex = 1;
            // 
            // lblPack
            // 
            this.lblPack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPack.AutoSize = true;
            this.lblPack.Location = new System.Drawing.Point(229, 418);
            this.lblPack.Name = "lblPack";
            this.lblPack.Size = new System.Drawing.Size(44, 20);
            this.lblPack.TabIndex = 0;
            this.lblPack.Text = "Pack";
            // 
            // lblLevel
            // 
            this.lblLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(10, 468);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 20);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Level";
            // 
            // txtIndex
            // 
            this.txtIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIndex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yuGiCardBindingSource, "CardIdx", true));
            this.txtIndex.Location = new System.Drawing.Point(100, 25);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.ReadOnly = true;
            this.txtIndex.Size = new System.Drawing.Size(94, 26);
            this.txtIndex.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(10, 568);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(81, 20);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Card Type";
            // 
            // lblOrder
            // 
            this.lblOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(229, 368);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(67, 20);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "Order Id";
            // 
            // lblAtt
            // 
            this.lblAtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAtt.AutoSize = true;
            this.lblAtt.Location = new System.Drawing.Point(10, 518);
            this.lblAtt.Name = "lblAtt";
            this.lblAtt.Size = new System.Drawing.Size(70, 20);
            this.lblAtt.TabIndex = 0;
            this.lblAtt.Text = "Attribute";
            // 
            // LblDescOffset
            // 
            this.LblDescOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDescOffset.AutoSize = true;
            this.LblDescOffset.Location = new System.Drawing.Point(10, 368);
            this.LblDescOffset.Name = "LblDescOffset";
            this.LblDescOffset.Size = new System.Drawing.Size(94, 20);
            this.LblDescOffset.TabIndex = 0;
            this.LblDescOffset.Text = "Desc Offset";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card ID";
            // 
            // lblPass
            // 
            this.lblPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(10, 418);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(78, 20);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Password";
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(5, 128);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(89, 20);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Description";
            // 
            // lblLang
            // 
            this.lblLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(10, 617);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(81, 20);
            this.lblLang.TabIndex = 0;
            this.lblLang.Text = "Language";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Card Name";
            // 
            // lblCardIndex
            // 
            this.lblCardIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCardIndex.AutoSize = true;
            this.lblCardIndex.Location = new System.Drawing.Point(5, 29);
            this.lblCardIndex.Name = "lblCardIndex";
            this.lblCardIndex.Size = new System.Drawing.Size(86, 20);
            this.lblCardIndex.TabIndex = 0;
            this.lblCardIndex.Text = "Card Index";
            // 
            // tableLeft
            // 
            this.tableLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLeft.ColumnCount = 1;
            this.tableLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLeft.Controls.Add(this.groupCollection, 0, 0);
            this.tableLeft.Location = new System.Drawing.Point(12, 13);
            this.tableLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tableLeft.Name = "tableLeft";
            this.tableLeft.RowCount = 1;
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLeft.Size = new System.Drawing.Size(439, 719);
            this.tableLeft.TabIndex = 6;
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.tableLeft);
            this.Controls.Add(this.tableRight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 800);
            this.Name = "CardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card List";
            this.Load += new System.EventHandler(this.CardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.miniPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.groupCollection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CardList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yuGiCardBindingSource)).EndInit();
            this.tableRight.ResumeLayout(false);
            this.tablePicture.ResumeLayout(false);
            this.groupPicture.ResumeLayout(false);
            this.groupPicture.PerformLayout();
            this.groupMiniPicture.ResumeLayout(false);
            this.groupMiniPicture.PerformLayout();
            this.groupCardInfo.ResumeLayout(false);
            this.groupCardInfo.PerformLayout();
            this.tableLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource yuGiCardBindingSource;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox miniPicture;
        private System.Windows.Forms.Label lblFileNamePic;
        private System.Windows.Forms.TextBox txtFileNamePic;
        private System.Windows.Forms.TextBox txtFileNameMiniPic;
        private System.Windows.Forms.Label lblFileNameMiniPic;
        private System.Windows.Forms.Label lblFileTypePic;
        private System.Windows.Forms.TextBox txtFileTypeMiniPic;
        private System.Windows.Forms.Label lblFileTypeMiniPic;
        private System.Windows.Forms.TextBox txtFileTypePic;
        private System.Windows.Forms.GroupBox groupCollection;
        private System.Windows.Forms.TableLayoutPanel tableRight;
        private System.Windows.Forms.TableLayoutPanel tablePicture;
        private System.Windows.Forms.GroupBox groupPicture;
        private System.Windows.Forms.GroupBox groupMiniPicture;
        private System.Windows.Forms.TableLayoutPanel tableLeft;
        private System.Windows.Forms.GroupBox groupCardInfo;
        private System.Windows.Forms.Label lblCardIndex;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtDef;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtPack;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblDef;
        private System.Windows.Forms.Label lblPack;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.RichTextBox rtxtDesc;
        private System.Windows.Forms.ComboBox cbbLang;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtAtk;
        private System.Windows.Forms.TextBox txtAtt;
        private System.Windows.Forms.TextBox txtDescOffest;
        private System.Windows.Forms.Label tbtAtk;
        private System.Windows.Forms.Label lblAtt;
        private System.Windows.Forms.Label LblDescOffset;
        private System.Windows.Forms.DataGridView CardList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label lblOrder;
    }
}