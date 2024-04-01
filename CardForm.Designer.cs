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
            this.groupCollection = new System.Windows.Forms.GroupBox();
            this.dgCardList = new System.Windows.Forms.DataGridView();
            this.dgvcImageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableRight = new System.Windows.Forms.TableLayoutPanel();
            this.tablePicture = new System.Windows.Forms.TableLayoutPanel();
            this.groupPicture = new System.Windows.Forms.GroupBox();
            this.groupMiniPicture = new System.Windows.Forms.GroupBox();
            this.groupCardInfo = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbbLang = new System.Windows.Forms.ComboBox();
            this.rtxtDesc = new System.Windows.Forms.RichTextBox();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.txtDef = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAtk = new System.Windows.Forms.TextBox();
            this.txtPack = new System.Windows.Forms.TextBox();
            this.txtAtt = new System.Windows.Forms.TextBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.txtDescOffest = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblSort = new System.Windows.Forms.Label();
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
            this.lblCardId = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.lblCardIndex = new System.Windows.Forms.Label();
            this.tableLeft = new System.Windows.Forms.TableLayoutPanel();
            this.bdnCards = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFilter = new System.Windows.Forms.ToolStripButton();
            this.yugiCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvcCardIdx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.miniPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.groupCollection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCardList)).BeginInit();
            this.tableRight.SuspendLayout();
            this.tablePicture.SuspendLayout();
            this.groupPicture.SuspendLayout();
            this.groupMiniPicture.SuspendLayout();
            this.groupCardInfo.SuspendLayout();
            this.tableLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnCards)).BeginInit();
            this.bdnCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yugiCardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFileNameMiniPic
            // 
            this.txtFileNameMiniPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileNameMiniPic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yugiCardBindingSource, "CardImageNameMini", true));
            this.txtFileNameMiniPic.Location = new System.Drawing.Point(117, 77);
            this.txtFileNameMiniPic.MaxLength = 6;
            this.txtFileNameMiniPic.Name = "txtFileNameMiniPic";
            this.txtFileNameMiniPic.Size = new System.Drawing.Size(155, 26);
            this.txtFileNameMiniPic.TabIndex = 5;
            // 
            // lblFileNameMiniPic
            // 
            this.lblFileNameMiniPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileNameMiniPic.AutoSize = true;
            this.lblFileNameMiniPic.Location = new System.Drawing.Point(117, 54);
            this.lblFileNameMiniPic.Name = "lblFileNameMiniPic";
            this.lblFileNameMiniPic.Size = new System.Drawing.Size(92, 20);
            this.lblFileNameMiniPic.TabIndex = 4;
            this.lblFileNameMiniPic.Text = "File Name : ";
            // 
            // txtFileNamePic
            // 
            this.txtFileNamePic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileNamePic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yugiCardBindingSource, "CardImageName", true));
            this.txtFileNamePic.Location = new System.Drawing.Point(111, 460);
            this.txtFileNamePic.MaxLength = 6;
            this.txtFileNamePic.Name = "txtFileNamePic";
            this.txtFileNamePic.Size = new System.Drawing.Size(161, 26);
            this.txtFileNamePic.TabIndex = 3;
            // 
            // lblFileNamePic
            // 
            this.lblFileNamePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFileNamePic.AutoSize = true;
            this.lblFileNamePic.Location = new System.Drawing.Point(6, 463);
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
            this.miniPicture.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.yugiCardBindingSource, "CardImageMini", true));
            this.miniPicture.Location = new System.Drawing.Point(6, 25);
            this.miniPicture.Name = "miniPicture";
            this.miniPicture.Size = new System.Drawing.Size(105, 139);
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
            this.picture.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.yugiCardBindingSource, "CardImage", true));
            this.picture.Location = new System.Drawing.Point(6, 25);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(266, 428);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // groupCollection
            // 
            this.groupCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCollection.Controls.Add(this.dgCardList);
            this.groupCollection.Location = new System.Drawing.Point(3, 3);
            this.groupCollection.Name = "groupCollection";
            this.groupCollection.Size = new System.Drawing.Size(433, 721);
            this.groupCollection.TabIndex = 4;
            this.groupCollection.TabStop = false;
            this.groupCollection.Text = "Collection";
            // 
            // dgCardList
            // 
            this.dgCardList.AllowUserToAddRows = false;
            this.dgCardList.AllowUserToDeleteRows = false;
            this.dgCardList.AllowUserToOrderColumns = true;
            this.dgCardList.AllowUserToResizeRows = false;
            this.dgCardList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCardList.AutoGenerateColumns = false;
            this.dgCardList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCardList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcCardIdx,
            this.dgvcCardId,
            this.dgvcCardName,
            this.dgvcImageName,
            this.CardDesc});
            this.dgCardList.DataSource = this.yugiCardBindingSource;
            this.dgCardList.Location = new System.Drawing.Point(6, 25);
            this.dgCardList.MultiSelect = false;
            this.dgCardList.Name = "dgCardList";
            this.dgCardList.ReadOnly = true;
            this.dgCardList.RowHeadersVisible = false;
            this.dgCardList.RowHeadersWidth = 62;
            this.dgCardList.RowTemplate.Height = 28;
            this.dgCardList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCardList.Size = new System.Drawing.Size(421, 684);
            this.dgCardList.TabIndex = 0;
            // 
            // dgvcImageName
            // 
            this.dgvcImageName.DataPropertyName = "CardImageName";
            this.dgvcImageName.HeaderText = "Image";
            this.dgvcImageName.MinimumWidth = 8;
            this.dgvcImageName.Name = "dgvcImageName";
            this.dgvcImageName.ReadOnly = true;
            this.dgvcImageName.Width = 80;
            // 
            // CardDesc
            // 
            this.CardDesc.DataPropertyName = "CardDesc";
            this.CardDesc.HeaderText = "Description";
            this.CardDesc.MinimumWidth = 8;
            this.CardDesc.Name = "CardDesc";
            this.CardDesc.ReadOnly = true;
            this.CardDesc.Width = 500;
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
            this.tableRight.Location = new System.Drawing.Point(454, 45);
            this.tableRight.Margin = new System.Windows.Forms.Padding(0);
            this.tableRight.Name = "tableRight";
            this.tableRight.RowCount = 1;
            this.tableRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRight.Size = new System.Drawing.Size(712, 727);
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
            this.tablePicture.Size = new System.Drawing.Size(284, 727);
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
            this.groupPicture.Location = new System.Drawing.Point(3, 3);
            this.groupPicture.Name = "groupPicture";
            this.groupPicture.Size = new System.Drawing.Size(278, 539);
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
            this.groupMiniPicture.Controls.Add(this.lblFileNameMiniPic);
            this.groupMiniPicture.Controls.Add(this.txtFileNameMiniPic);
            this.groupMiniPicture.Location = new System.Drawing.Point(3, 548);
            this.groupMiniPicture.Name = "groupMiniPicture";
            this.groupMiniPicture.Size = new System.Drawing.Size(278, 176);
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
            this.groupCardInfo.Controls.Add(this.txtCardName);
            this.groupCardInfo.Controls.Add(this.txtLevel);
            this.groupCardInfo.Controls.Add(this.txtSort);
            this.groupCardInfo.Controls.Add(this.txtDef);
            this.groupCardInfo.Controls.Add(this.txtType);
            this.groupCardInfo.Controls.Add(this.txtAtk);
            this.groupCardInfo.Controls.Add(this.txtPack);
            this.groupCardInfo.Controls.Add(this.txtAtt);
            this.groupCardInfo.Controls.Add(this.txtOrder);
            this.groupCardInfo.Controls.Add(this.txtDescOffest);
            this.groupCardInfo.Controls.Add(this.txtPass);
            this.groupCardInfo.Controls.Add(this.lblSort);
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
            this.groupCardInfo.Controls.Add(this.lblCardId);
            this.groupCardInfo.Controls.Add(this.lblPass);
            this.groupCardInfo.Controls.Add(this.lblDesc);
            this.groupCardInfo.Controls.Add(this.lblLang);
            this.groupCardInfo.Controls.Add(this.lblCardName);
            this.groupCardInfo.Controls.Add(this.lblCardIndex);
            this.groupCardInfo.Location = new System.Drawing.Point(288, 3);
            this.groupCardInfo.Name = "groupCardInfo";
            this.groupCardInfo.Size = new System.Drawing.Size(421, 721);
            this.groupCardInfo.TabIndex = 1;
            this.groupCardInfo.TabStop = false;
            this.groupCardInfo.Text = "Card Detail";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(276, 660);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 49);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(60, 660);
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
            this.cbbLang.Location = new System.Drawing.Point(100, 623);
            this.cbbLang.Name = "cbbLang";
            this.cbbLang.Size = new System.Drawing.Size(94, 28);
            this.cbbLang.TabIndex = 3;
            this.cbbLang.SelectedValueChanged += new System.EventHandler(this.CbbLang_SelectedValueChanged);
            // 
            // rtxtDesc
            // 
            this.rtxtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yugiCardBindingSource, "CardDesc", true));
            this.rtxtDesc.Location = new System.Drawing.Point(9, 150);
            this.rtxtDesc.Name = "rtxtDesc";
            this.rtxtDesc.Size = new System.Drawing.Size(393, 198);
            this.rtxtDesc.TabIndex = 2;
            this.rtxtDesc.Text = "";
            // 
            // txtCardName
            // 
            this.txtCardName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yugiCardBindingSource, "CardName", true));
            this.txtCardName.Location = new System.Drawing.Point(100, 75);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(302, 26);
            this.txtCardName.TabIndex = 1;
            // 
            // txtLevel
            // 
            this.txtLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yugiCardBindingSource, "CardLevel", true));
            this.txtLevel.Location = new System.Drawing.Point(100, 473);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(94, 26);
            this.txtLevel.TabIndex = 1;
            // 
            // txtSort
            // 
            this.txtSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSort.Location = new System.Drawing.Point(308, 473);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(94, 26);
            this.txtSort.TabIndex = 1;
            // 
            // txtDef
            // 
            this.txtDef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDef.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yugiCardBindingSource, "CardDef", true));
            this.txtDef.Location = new System.Drawing.Point(308, 573);
            this.txtDef.Name = "txtDef";
            this.txtDef.Size = new System.Drawing.Size(94, 26);
            this.txtDef.TabIndex = 1;
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yugiCardBindingSource, "CardType", true));
            this.txtType.Location = new System.Drawing.Point(100, 573);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(94, 26);
            this.txtType.TabIndex = 1;
            // 
            // txtAtk
            // 
            this.txtAtk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAtk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yugiCardBindingSource, "CardAtk", true));
            this.txtAtk.Location = new System.Drawing.Point(308, 523);
            this.txtAtk.Name = "txtAtk";
            this.txtAtk.Size = new System.Drawing.Size(94, 26);
            this.txtAtk.TabIndex = 1;
            // 
            // txtPack
            // 
            this.txtPack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPack.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yugiCardBindingSource, "CardPack", true));
            this.txtPack.Location = new System.Drawing.Point(308, 423);
            this.txtPack.Name = "txtPack";
            this.txtPack.Size = new System.Drawing.Size(94, 26);
            this.txtPack.TabIndex = 1;
            // 
            // txtAtt
            // 
            this.txtAtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAtt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yugiCardBindingSource, "CardAtb", true));
            this.txtAtt.Location = new System.Drawing.Point(100, 523);
            this.txtAtt.Name = "txtAtt";
            this.txtAtt.Size = new System.Drawing.Size(94, 26);
            this.txtAtt.TabIndex = 1;
            // 
            // txtOrder
            // 
            this.txtOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yugiCardBindingSource, "CardOrderId", true));
            this.txtOrder.Location = new System.Drawing.Point(308, 373);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(94, 26);
            this.txtOrder.TabIndex = 1;
            // 
            // txtDescOffest
            // 
            this.txtDescOffest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescOffest.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yugiCardBindingSource, "CardDescOffset", true));
            this.txtDescOffest.Location = new System.Drawing.Point(100, 373);
            this.txtDescOffest.Name = "txtDescOffest";
            this.txtDescOffest.ReadOnly = true;
            this.txtDescOffest.Size = new System.Drawing.Size(94, 26);
            this.txtDescOffest.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yugiCardBindingSource, "CardPassword", true));
            this.txtPass.Location = new System.Drawing.Point(100, 423);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(94, 26);
            this.txtPass.TabIndex = 1;
            // 
            // lblSort
            // 
            this.lblSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(229, 479);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(39, 20);
            this.lblSort.TabIndex = 0;
            this.lblSort.Text = "Sort";
            // 
            // lblDef
            // 
            this.lblDef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDef.AutoSize = true;
            this.lblDef.Location = new System.Drawing.Point(229, 576);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(70, 20);
            this.lblDef.TabIndex = 0;
            this.lblDef.Text = "Defense";
            // 
            // tbtAtk
            // 
            this.tbtAtk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbtAtk.AutoSize = true;
            this.tbtAtk.Location = new System.Drawing.Point(230, 526);
            this.tbtAtk.Name = "tbtAtk";
            this.tbtAtk.Size = new System.Drawing.Size(55, 20);
            this.tbtAtk.TabIndex = 0;
            this.tbtAtk.Text = "Attack";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yugiCardBindingSource, "CardId", true));
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
            this.lblPack.Location = new System.Drawing.Point(229, 426);
            this.lblPack.Name = "lblPack";
            this.lblPack.Size = new System.Drawing.Size(44, 20);
            this.lblPack.TabIndex = 0;
            this.lblPack.Text = "Pack";
            // 
            // lblLevel
            // 
            this.lblLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(10, 476);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 20);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Level";
            // 
            // txtIndex
            // 
            this.txtIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIndex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yugiCardBindingSource, "CardIdx", true));
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
            this.lblType.Location = new System.Drawing.Point(10, 576);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(81, 20);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Card Type";
            // 
            // lblOrder
            // 
            this.lblOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(229, 376);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(67, 20);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "Order Id";
            // 
            // lblAtt
            // 
            this.lblAtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAtt.AutoSize = true;
            this.lblAtt.Location = new System.Drawing.Point(10, 526);
            this.lblAtt.Name = "lblAtt";
            this.lblAtt.Size = new System.Drawing.Size(70, 20);
            this.lblAtt.TabIndex = 0;
            this.lblAtt.Text = "Attribute";
            // 
            // LblDescOffset
            // 
            this.LblDescOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDescOffset.AutoSize = true;
            this.LblDescOffset.Location = new System.Drawing.Point(10, 376);
            this.LblDescOffset.Name = "LblDescOffset";
            this.LblDescOffset.Size = new System.Drawing.Size(94, 20);
            this.LblDescOffset.TabIndex = 0;
            this.LblDescOffset.Text = "Desc Offset";
            // 
            // lblCardId
            // 
            this.lblCardId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCardId.AutoSize = true;
            this.lblCardId.Location = new System.Drawing.Point(229, 29);
            this.lblCardId.Name = "lblCardId";
            this.lblCardId.Size = new System.Drawing.Size(64, 20);
            this.lblCardId.TabIndex = 0;
            this.lblCardId.Text = "Card ID";
            // 
            // lblPass
            // 
            this.lblPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(10, 426);
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
            this.lblLang.Location = new System.Drawing.Point(13, 626);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(81, 20);
            this.lblLang.TabIndex = 0;
            this.lblLang.Text = "Language";
            // 
            // lblCardName
            // 
            this.lblCardName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCardName.AutoSize = true;
            this.lblCardName.Location = new System.Drawing.Point(5, 78);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(89, 20);
            this.lblCardName.TabIndex = 0;
            this.lblCardName.Text = "Card Name";
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
            this.tableLeft.Location = new System.Drawing.Point(12, 45);
            this.tableLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tableLeft.Name = "tableLeft";
            this.tableLeft.RowCount = 1;
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLeft.Size = new System.Drawing.Size(439, 727);
            this.tableLeft.TabIndex = 6;
            // 
            // bdnCards
            // 
            this.bdnCards.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bdnCards.BindingSource = this.yugiCardBindingSource;
            this.bdnCards.CountItem = this.bindingNavigatorCountItem;
            this.bdnCards.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bdnCards.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bdnCards.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tsbFilter});
            this.bdnCards.Location = new System.Drawing.Point(0, 0);
            this.bdnCards.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnCards.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnCards.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnCards.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnCards.Name = "bdnCards";
            this.bdnCards.PositionItem = this.bindingNavigatorPositionItem;
            this.bdnCards.Size = new System.Drawing.Size(1178, 38);
            this.bdnCards.TabIndex = 7;
            this.bdnCards.Text = "navigator";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbFilter
            // 
            this.tsbFilter.Image = ((System.Drawing.Image)(resources.GetObject("tsbFilter.Image")));
            this.tsbFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFilter.Name = "tsbFilter";
            this.tsbFilter.Size = new System.Drawing.Size(121, 33);
            this.tsbFilter.Text = "Null Cards";
            this.tsbFilter.Click += new System.EventHandler(this.TsbFilter_Click);
            // 
            // yugiCardBindingSource
            // 
            this.yugiCardBindingSource.DataSource = typeof(YGOEditor.Structure.YuGiCard);
            this.yugiCardBindingSource.Filter = "";
            // 
            // dgvcCardIdx
            // 
            this.dgvcCardIdx.DataPropertyName = "CardIdx";
            this.dgvcCardIdx.HeaderText = "#";
            this.dgvcCardIdx.MinimumWidth = 8;
            this.dgvcCardIdx.Name = "dgvcCardIdx";
            this.dgvcCardIdx.ReadOnly = true;
            this.dgvcCardIdx.Width = 50;
            // 
            // dgvcCardId
            // 
            this.dgvcCardId.DataPropertyName = "CardId";
            this.dgvcCardId.HeaderText = "Id";
            this.dgvcCardId.MinimumWidth = 8;
            this.dgvcCardId.Name = "dgvcCardId";
            this.dgvcCardId.ReadOnly = true;
            this.dgvcCardId.Width = 50;
            // 
            // dgvcCardName
            // 
            this.dgvcCardName.DataPropertyName = "CardName";
            this.dgvcCardName.HeaderText = "Name";
            this.dgvcCardName.MinimumWidth = 8;
            this.dgvcCardName.Name = "dgvcCardName";
            this.dgvcCardName.ReadOnly = true;
            this.dgvcCardName.Width = 250;
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 784);
            this.Controls.Add(this.bdnCards);
            this.Controls.Add(this.tableLeft);
            this.Controls.Add(this.tableRight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 840);
            this.Name = "CardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card List";
            this.Load += new System.EventHandler(this.CardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.miniPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.groupCollection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCardList)).EndInit();
            this.tableRight.ResumeLayout(false);
            this.tablePicture.ResumeLayout(false);
            this.groupPicture.ResumeLayout(false);
            this.groupPicture.PerformLayout();
            this.groupMiniPicture.ResumeLayout(false);
            this.groupMiniPicture.PerformLayout();
            this.groupCardInfo.ResumeLayout(false);
            this.groupCardInfo.PerformLayout();
            this.tableLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdnCards)).EndInit();
            this.bdnCards.ResumeLayout(false);
            this.bdnCards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yugiCardBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource yugiCardBindingSource;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox miniPicture;
        private System.Windows.Forms.Label lblFileNamePic;
        private System.Windows.Forms.TextBox txtFileNamePic;
        private System.Windows.Forms.TextBox txtFileNameMiniPic;
        private System.Windows.Forms.Label lblFileNameMiniPic;
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
        private System.Windows.Forms.Label lblCardId;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.Label lblCardName;
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
        private System.Windows.Forms.DataGridView dgCardList;
        private System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.BindingNavigator bdnCards;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tsbFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCardIdx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcImageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardDesc;
    }
}