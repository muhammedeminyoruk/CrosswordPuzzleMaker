using kare_bulmaca_winform;

namespace CrosswordCreator
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelOrta = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kelimeEkleText = new System.Windows.Forms.TextBox();
            this.notUsedListView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soruCevapGrid = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekleButon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ayarlarTab = new System.Windows.Forms.TabControl();
            this.baslik = new System.Windows.Forms.TabPage();
            this.baslikOzellik = new System.Windows.Forms.Button();
            this.baslikHiza = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kelimeler = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.kelimelerKucukHarf = new System.Windows.Forms.CheckBox();
            this.arkaplanResimPictureBox = new System.Windows.Forms.PictureBox();
            this.kelimelerArkaplanRenkYazi = new System.Windows.Forms.Label();
            this.numaralarOzellik = new System.Windows.Forms.Button();
            this.kelimelerOzellik = new System.Windows.Forms.Button();
            this.kelimelerArkaplanRenk = new System.Windows.Forms.PictureBox();
            this.sorular = new System.Windows.Forms.TabPage();
            this.basliklarHizalama = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.basliklarOzellik = new System.Windows.Forms.Button();
            this.pozisyon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.arkaplan = new System.Windows.Forms.TabPage();
            this.arkaplanRenkYazi = new System.Windows.Forms.Label();
            this.arkaplanRenk = new System.Windows.Forms.PictureBox();
            this.cerceveRenkYazi = new System.Windows.Forms.Label();
            this.cerceveRenk = new System.Windows.Forms.PictureBox();
            this.hucre = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.boyutUygula = new System.Windows.Forms.Button();
            this.bulmacaBoyutu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.hucreBoyutu = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baslikTextbox = new System.Windows.Forms.TextBox();
            this.verticalWordsListView = new System.Windows.Forms.ListView();
            this.horizontalWordsListView = new System.Windows.Forms.ListView();
            this.onizlemeCevaplar = new System.Windows.Forms.CheckBox();
            this.A4 = new System.Windows.Forms.Panel();
            this.panelSoruCevap = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelSoldanSaga = new System.Windows.Forms.Panel();
            this.soldanSagaSorular = new System.Windows.Forms.TextBox();
            this.panelSoldanSagaBaslik = new System.Windows.Forms.Panel();
            this.soldanSagaBaslik = new System.Windows.Forms.Label();
            this.panelYukaridanAsagiya = new System.Windows.Forms.Panel();
            this.yukaridanAsagiyaSorular = new System.Windows.Forms.TextBox();
            this.panelYukaridanAsagiyaBaslik = new System.Windows.Forms.Panel();
            this.yukaridanAsagiyaBaslik = new System.Windows.Forms.Label();
            this.panelBulmaca = new System.Windows.Forms.Panel();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grid1 = new kare_bulmaca_winform.DataGridViewEx();
            this.ustSayilarPanel = new System.Windows.Forms.Panel();
            this.ustSayilarGrid = new System.Windows.Forms.DataGridView();
            this.altSayilarPanel = new System.Windows.Forms.Panel();
            this.altSayilarGrid = new System.Windows.Forms.DataGridView();
            this.boslukPanel = new System.Windows.Forms.Panel();
            this.panelBaslik = new System.Windows.Forms.Panel();
            this.baslikPanelKonum = new System.Windows.Forms.Panel();
            this.baslikA4 = new System.Windows.Forms.Label();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.panelUst = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bulmacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulmacaAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulmacayıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baslikDialog = new System.Windows.Forms.FontDialog();
            this.kelimelerCerceveColorDialog = new System.Windows.Forms.ColorDialog();
            this.kelimelerHucreColorDialog = new System.Windows.Forms.ColorDialog();
            this.kelimelerFontDialog = new System.Windows.Forms.FontDialog();
            this.numaralarFontDialog = new System.Windows.Forms.FontDialog();
            this.kelimelerArkaplanColorDialog = new System.Windows.Forms.ColorDialog();
            this.sorularFontDialog = new System.Windows.Forms.FontDialog();
            this.basliklarFontDialog = new System.Windows.Forms.FontDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelOrta)).BeginInit();
            this.panelOrta.Panel1.SuspendLayout();
            this.panelOrta.Panel2.SuspendLayout();
            this.panelOrta.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notUsedListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruCevapGrid)).BeginInit();
            this.ayarlarTab.SuspendLayout();
            this.baslik.SuspendLayout();
            this.kelimeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arkaplanResimPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelerArkaplanRenk)).BeginInit();
            this.sorular.SuspendLayout();
            this.arkaplan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arkaplanRenk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerceveRenk)).BeginInit();
            this.hucre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.A4.SuspendLayout();
            this.panelSoruCevap.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelSoldanSaga.SuspendLayout();
            this.panelSoldanSagaBaslik.SuspendLayout();
            this.panelYukaridanAsagiya.SuspendLayout();
            this.panelYukaridanAsagiyaBaslik.SuspendLayout();
            this.panelBulmaca.SuspendLayout();
            this.GridPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.ustSayilarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ustSayilarGrid)).BeginInit();
            this.altSayilarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altSayilarGrid)).BeginInit();
            this.panelBaslik.SuspendLayout();
            this.baslikPanelKonum.SuspendLayout();
            this.panelUst.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.panelOrta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(1064, 576);
            this.panel2.TabIndex = 7;
            // 
            // panelOrta
            // 
            this.panelOrta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrta.IsSplitterFixed = true;
            this.panelOrta.Location = new System.Drawing.Point(0, 0);
            this.panelOrta.Name = "panelOrta";
            // 
            // panelOrta.Panel1
            // 
            this.panelOrta.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.panelOrta.Panel1.Controls.Add(this.groupBox2);
            this.panelOrta.Panel1.Controls.Add(this.ayarlarTab);
            this.panelOrta.Panel1.Controls.Add(this.groupBox1);
            this.panelOrta.Panel1.Controls.Add(this.verticalWordsListView);
            this.panelOrta.Panel1.Controls.Add(this.horizontalWordsListView);
            this.panelOrta.Panel1.Controls.Add(this.onizlemeCevaplar);
            this.panelOrta.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelOrta.Panel1MinSize = 320;
            // 
            // panelOrta.Panel2
            // 
            this.panelOrta.Panel2.AutoScroll = true;
            this.panelOrta.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.panelOrta.Panel2.Controls.Add(this.A4);
            this.panelOrta.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelOrta.Size = new System.Drawing.Size(1064, 576);
            this.panelOrta.SplitterDistance = 320;
            this.panelOrta.SplitterWidth = 1;
            this.panelOrta.TabIndex = 0;
            this.panelOrta.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kelimeEkleText);
            this.groupBox2.Controls.Add(this.notUsedListView);
            this.groupBox2.Controls.Add(this.soruCevapGrid);
            this.groupBox2.Controls.Add(this.ekleButon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.GenerateButton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(11, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 284);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kelimeler";
            // 
            // kelimeEkleText
            // 
            this.kelimeEkleText.Location = new System.Drawing.Point(54, 19);
            this.kelimeEkleText.Name = "kelimeEkleText";
            this.kelimeEkleText.Size = new System.Drawing.Size(222, 20);
            this.kelimeEkleText.TabIndex = 0;
            this.kelimeEkleText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kelimeEkleText_KeyDown);
            this.kelimeEkleText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kelimeEkleText_KeyPress);
            // 
            // notUsedListView
            // 
            this.notUsedListView.AllowUserToAddRows = false;
            this.notUsedListView.AllowUserToDeleteRows = false;
            this.notUsedListView.AllowUserToResizeColumns = false;
            this.notUsedListView.AllowUserToResizeRows = false;
            this.notUsedListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notUsedListView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.notUsedListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notUsedListView.ColumnHeadersVisible = false;
            this.notUsedListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.notUsedListView.DefaultCellStyle = dataGridViewCellStyle1;
            this.notUsedListView.Location = new System.Drawing.Point(149, 99);
            this.notUsedListView.MultiSelect = false;
            this.notUsedListView.Name = "notUsedListView";
            this.notUsedListView.ReadOnly = true;
            this.notUsedListView.RowHeadersVisible = false;
            this.notUsedListView.Size = new System.Drawing.Size(137, 179);
            this.notUsedListView.TabIndex = 14;
            this.notUsedListView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Uygun Olmayan ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // soruCevapGrid
            // 
            this.soruCevapGrid.AllowUserToAddRows = false;
            this.soruCevapGrid.AllowUserToDeleteRows = false;
            this.soruCevapGrid.AllowUserToResizeColumns = false;
            this.soruCevapGrid.AllowUserToResizeRows = false;
            this.soruCevapGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.soruCevapGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.soruCevapGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soruCevapGrid.ColumnHeadersVisible = false;
            this.soruCevapGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.soruCevapGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.soruCevapGrid.Location = new System.Drawing.Point(6, 99);
            this.soruCevapGrid.MultiSelect = false;
            this.soruCevapGrid.Name = "soruCevapGrid";
            this.soruCevapGrid.ReadOnly = true;
            this.soruCevapGrid.RowHeadersVisible = false;
            this.soruCevapGrid.Size = new System.Drawing.Size(137, 179);
            this.soruCevapGrid.TabIndex = 14;
            this.soruCevapGrid.TabStop = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Uygun Kelimeler";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // ekleButon
            // 
            this.ekleButon.Location = new System.Drawing.Point(99, 45);
            this.ekleButon.Name = "ekleButon";
            this.ekleButon.Size = new System.Drawing.Size(61, 23);
            this.ekleButon.TabIndex = 2;
            this.ekleButon.TabStop = false;
            this.ekleButon.Text = "Ekle";
            this.ekleButon.UseVisualStyleBackColor = true;
            this.ekleButon.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Uygun Olmayan Kelimeler ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uygun Kelimeler ";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(166, 45);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(110, 23);
            this.GenerateButton.TabIndex = 3;
            this.GenerateButton.TabStop = false;
            this.GenerateButton.Text = "Bulmaca Oluştur";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kelime : ";
            // 
            // ayarlarTab
            // 
            this.ayarlarTab.Controls.Add(this.baslik);
            this.ayarlarTab.Controls.Add(this.kelimeler);
            this.ayarlarTab.Controls.Add(this.sorular);
            this.ayarlarTab.Controls.Add(this.arkaplan);
            this.ayarlarTab.Controls.Add(this.hucre);
            this.ayarlarTab.Location = new System.Drawing.Point(11, 364);
            this.ayarlarTab.Name = "ayarlarTab";
            this.ayarlarTab.SelectedIndex = 0;
            this.ayarlarTab.Size = new System.Drawing.Size(292, 162);
            this.ayarlarTab.TabIndex = 1;
            // 
            // baslik
            // 
            this.baslik.Controls.Add(this.baslikOzellik);
            this.baslik.Controls.Add(this.baslikHiza);
            this.baslik.Controls.Add(this.label5);
            this.baslik.Location = new System.Drawing.Point(4, 22);
            this.baslik.Name = "baslik";
            this.baslik.Padding = new System.Windows.Forms.Padding(3);
            this.baslik.Size = new System.Drawing.Size(284, 136);
            this.baslik.TabIndex = 0;
            this.baslik.Text = "Başlık";
            this.baslik.UseVisualStyleBackColor = true;
            // 
            // baslikOzellik
            // 
            this.baslikOzellik.Location = new System.Drawing.Point(125, 75);
            this.baslikOzellik.Name = "baslikOzellik";
            this.baslikOzellik.Size = new System.Drawing.Size(70, 23);
            this.baslikOzellik.TabIndex = 0;
            this.baslikOzellik.TabStop = false;
            this.baslikOzellik.Text = "Özellik";
            this.baslikOzellik.UseVisualStyleBackColor = true;
            this.baslikOzellik.Click += new System.EventHandler(this.baslikOzellik_Click);
            // 
            // baslikHiza
            // 
            this.baslikHiza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baslikHiza.FormattingEnabled = true;
            this.baslikHiza.Items.AddRange(new object[] {
            "Sol",
            "Orta",
            "Sağ"});
            this.baslikHiza.Location = new System.Drawing.Point(107, 33);
            this.baslikHiza.Name = "baslikHiza";
            this.baslikHiza.Size = new System.Drawing.Size(108, 21);
            this.baslikHiza.TabIndex = 4;
            this.baslikHiza.TabStop = false;
            this.baslikHiza.SelectedIndexChanged += new System.EventHandler(this.baslikHiza_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hizalama : ";
            // 
            // kelimeler
            // 
            this.kelimeler.Controls.Add(this.label8);
            this.kelimeler.Controls.Add(this.kelimelerKucukHarf);
            this.kelimeler.Controls.Add(this.arkaplanResimPictureBox);
            this.kelimeler.Controls.Add(this.kelimelerArkaplanRenkYazi);
            this.kelimeler.Controls.Add(this.numaralarOzellik);
            this.kelimeler.Controls.Add(this.kelimelerOzellik);
            this.kelimeler.Controls.Add(this.kelimelerArkaplanRenk);
            this.kelimeler.Location = new System.Drawing.Point(4, 22);
            this.kelimeler.Name = "kelimeler";
            this.kelimeler.Padding = new System.Windows.Forms.Padding(3);
            this.kelimeler.Size = new System.Drawing.Size(284, 136);
            this.kelimeler.TabIndex = 1;
            this.kelimeler.Text = "Kelimeler";
            this.kelimeler.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Kelimeler Arkaplan Resmi";
            this.label8.Click += new System.EventHandler(this.arkaplanResimPictureBox_Click);
            // 
            // kelimelerKucukHarf
            // 
            this.kelimelerKucukHarf.AutoSize = true;
            this.kelimelerKucukHarf.Location = new System.Drawing.Point(35, 23);
            this.kelimelerKucukHarf.Name = "kelimelerKucukHarf";
            this.kelimelerKucukHarf.Size = new System.Drawing.Size(80, 17);
            this.kelimelerKucukHarf.TabIndex = 6;
            this.kelimelerKucukHarf.TabStop = false;
            this.kelimelerKucukHarf.Text = "Küçük Harf";
            this.kelimelerKucukHarf.UseVisualStyleBackColor = true;
            this.kelimelerKucukHarf.CheckedChanged += new System.EventHandler(this.kelimelerKucukHarf_CheckedChanged);
            // 
            // arkaplanResimPictureBox
            // 
            this.arkaplanResimPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arkaplanResimPictureBox.Location = new System.Drawing.Point(34, 82);
            this.arkaplanResimPictureBox.Name = "arkaplanResimPictureBox";
            this.arkaplanResimPictureBox.Size = new System.Drawing.Size(40, 40);
            this.arkaplanResimPictureBox.TabIndex = 8;
            this.arkaplanResimPictureBox.TabStop = false;
            this.arkaplanResimPictureBox.Click += new System.EventHandler(this.arkaplanResimPictureBox_Click);
            // 
            // kelimelerArkaplanRenkYazi
            // 
            this.kelimelerArkaplanRenkYazi.AutoSize = true;
            this.kelimelerArkaplanRenkYazi.Location = new System.Drawing.Point(51, 56);
            this.kelimelerArkaplanRenkYazi.Name = "kelimelerArkaplanRenkYazi";
            this.kelimelerArkaplanRenkYazi.Size = new System.Drawing.Size(80, 13);
            this.kelimelerArkaplanRenkYazi.TabIndex = 5;
            this.kelimelerArkaplanRenkYazi.Text = "Arkaplan Rengi";
            this.kelimelerArkaplanRenkYazi.Click += new System.EventHandler(this.arkaplanRenk_Click);
            // 
            // numaralarOzellik
            // 
            this.numaralarOzellik.Location = new System.Drawing.Point(152, 51);
            this.numaralarOzellik.Name = "numaralarOzellik";
            this.numaralarOzellik.Size = new System.Drawing.Size(102, 23);
            this.numaralarOzellik.TabIndex = 1;
            this.numaralarOzellik.TabStop = false;
            this.numaralarOzellik.Text = "Numaralar Özellik";
            this.numaralarOzellik.UseVisualStyleBackColor = true;
            this.numaralarOzellik.Click += new System.EventHandler(this.numaralarOzellik_Click);
            // 
            // kelimelerOzellik
            // 
            this.kelimelerOzellik.Location = new System.Drawing.Point(152, 19);
            this.kelimelerOzellik.Name = "kelimelerOzellik";
            this.kelimelerOzellik.Size = new System.Drawing.Size(102, 23);
            this.kelimelerOzellik.TabIndex = 1;
            this.kelimelerOzellik.TabStop = false;
            this.kelimelerOzellik.Text = "Kelimeler Özellik";
            this.kelimelerOzellik.UseVisualStyleBackColor = true;
            this.kelimelerOzellik.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // kelimelerArkaplanRenk
            // 
            this.kelimelerArkaplanRenk.BackColor = System.Drawing.Color.White;
            this.kelimelerArkaplanRenk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kelimelerArkaplanRenk.Location = new System.Drawing.Point(34, 55);
            this.kelimelerArkaplanRenk.Name = "kelimelerArkaplanRenk";
            this.kelimelerArkaplanRenk.Size = new System.Drawing.Size(14, 14);
            this.kelimelerArkaplanRenk.TabIndex = 1;
            this.kelimelerArkaplanRenk.TabStop = false;
            this.kelimelerArkaplanRenk.Click += new System.EventHandler(this.arkaplanRenk_Click);
            // 
            // sorular
            // 
            this.sorular.Controls.Add(this.basliklarHizalama);
            this.sorular.Controls.Add(this.label9);
            this.sorular.Controls.Add(this.basliklarOzellik);
            this.sorular.Controls.Add(this.pozisyon);
            this.sorular.Controls.Add(this.label6);
            this.sorular.Controls.Add(this.button3);
            this.sorular.Location = new System.Drawing.Point(4, 22);
            this.sorular.Name = "sorular";
            this.sorular.Size = new System.Drawing.Size(284, 136);
            this.sorular.TabIndex = 4;
            this.sorular.Text = "Sorular";
            this.sorular.UseVisualStyleBackColor = true;
            // 
            // basliklarHizalama
            // 
            this.basliklarHizalama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.basliklarHizalama.FormattingEnabled = true;
            this.basliklarHizalama.Items.AddRange(new object[] {
            "Sol",
            "Orta",
            "Sağ"});
            this.basliklarHizalama.Location = new System.Drawing.Point(123, 43);
            this.basliklarHizalama.Name = "basliklarHizalama";
            this.basliklarHizalama.Size = new System.Drawing.Size(108, 21);
            this.basliklarHizalama.TabIndex = 11;
            this.basliklarHizalama.TabStop = false;
            this.basliklarHizalama.SelectedIndexChanged += new System.EventHandler(this.basliklarHizalama_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Başlıklar Hizalama : ";
            // 
            // basliklarOzellik
            // 
            this.basliklarOzellik.Location = new System.Drawing.Point(123, 70);
            this.basliklarOzellik.Name = "basliklarOzellik";
            this.basliklarOzellik.Size = new System.Drawing.Size(108, 23);
            this.basliklarOzellik.TabIndex = 9;
            this.basliklarOzellik.TabStop = false;
            this.basliklarOzellik.Text = "Başlıklar Özellik";
            this.basliklarOzellik.UseVisualStyleBackColor = true;
            this.basliklarOzellik.Click += new System.EventHandler(this.basliklarOzellik_Click);
            // 
            // pozisyon
            // 
            this.pozisyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pozisyon.FormattingEnabled = true;
            this.pozisyon.Items.AddRange(new object[] {
            "Yan yana",
            "Alt alta"});
            this.pozisyon.Location = new System.Drawing.Point(123, 16);
            this.pozisyon.Name = "pozisyon";
            this.pozisyon.Size = new System.Drawing.Size(108, 21);
            this.pozisyon.TabIndex = 6;
            this.pozisyon.TabStop = false;
            this.pozisyon.SelectedIndexChanged += new System.EventHandler(this.pozisyon_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pozisyon : ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.Text = "Sorular Özellik";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // arkaplan
            // 
            this.arkaplan.Controls.Add(this.arkaplanRenkYazi);
            this.arkaplan.Controls.Add(this.arkaplanRenk);
            this.arkaplan.Controls.Add(this.cerceveRenkYazi);
            this.arkaplan.Controls.Add(this.cerceveRenk);
            this.arkaplan.Location = new System.Drawing.Point(4, 22);
            this.arkaplan.Name = "arkaplan";
            this.arkaplan.Size = new System.Drawing.Size(284, 136);
            this.arkaplan.TabIndex = 5;
            this.arkaplan.Text = "Arkaplan";
            this.arkaplan.UseVisualStyleBackColor = true;
            // 
            // arkaplanRenkYazi
            // 
            this.arkaplanRenkYazi.AutoSize = true;
            this.arkaplanRenkYazi.Location = new System.Drawing.Point(105, 57);
            this.arkaplanRenkYazi.Name = "arkaplanRenkYazi";
            this.arkaplanRenkYazi.Size = new System.Drawing.Size(88, 13);
            this.arkaplanRenkYazi.TabIndex = 14;
            this.arkaplanRenkYazi.Text = "Boş Nokta Rengi";
            this.arkaplanRenkYazi.Click += new System.EventHandler(this.arkaplanRenk_Click_1);
            // 
            // arkaplanRenk
            // 
            this.arkaplanRenk.BackColor = System.Drawing.Color.Black;
            this.arkaplanRenk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arkaplanRenk.Location = new System.Drawing.Point(88, 56);
            this.arkaplanRenk.Name = "arkaplanRenk";
            this.arkaplanRenk.Size = new System.Drawing.Size(14, 14);
            this.arkaplanRenk.TabIndex = 13;
            this.arkaplanRenk.TabStop = false;
            this.arkaplanRenk.Click += new System.EventHandler(this.arkaplanRenk_Click_1);
            // 
            // cerceveRenkYazi
            // 
            this.cerceveRenkYazi.AutoSize = true;
            this.cerceveRenkYazi.Location = new System.Drawing.Point(105, 35);
            this.cerceveRenkYazi.Name = "cerceveRenkYazi";
            this.cerceveRenkYazi.Size = new System.Drawing.Size(78, 13);
            this.cerceveRenkYazi.TabIndex = 11;
            this.cerceveRenkYazi.Text = "Çerçeve Rengi";
            this.cerceveRenkYazi.Click += new System.EventHandler(this.cerceveRenk_Click);
            // 
            // cerceveRenk
            // 
            this.cerceveRenk.BackColor = System.Drawing.Color.Black;
            this.cerceveRenk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cerceveRenk.Location = new System.Drawing.Point(88, 34);
            this.cerceveRenk.Name = "cerceveRenk";
            this.cerceveRenk.Size = new System.Drawing.Size(14, 14);
            this.cerceveRenk.TabIndex = 7;
            this.cerceveRenk.TabStop = false;
            this.cerceveRenk.Click += new System.EventHandler(this.cerceveRenk_Click);
            // 
            // hucre
            // 
            this.hucre.Controls.Add(this.label3);
            this.hucre.Controls.Add(this.label4);
            this.hucre.Controls.Add(this.pictureBox5);
            this.hucre.Controls.Add(this.boyutUygula);
            this.hucre.Controls.Add(this.bulmacaBoyutu);
            this.hucre.Controls.Add(this.label13);
            this.hucre.Controls.Add(this.label14);
            this.hucre.Controls.Add(this.hucreBoyutu);
            this.hucre.Controls.Add(this.label15);
            this.hucre.Controls.Add(this.pictureBox4);
            this.hucre.Controls.Add(this.label11);
            this.hucre.Controls.Add(this.label12);
            this.hucre.Controls.Add(this.label10);
            this.hucre.Location = new System.Drawing.Point(4, 22);
            this.hucre.Name = "hucre";
            this.hucre.Size = new System.Drawing.Size(284, 136);
            this.hucre.TabIndex = 3;
            this.hucre.Text = "Hücre ";
            this.hucre.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Min : 20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max : 40";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Gray;
            this.pictureBox5.Location = new System.Drawing.Point(14, 114);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(250, 1);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // boyutUygula
            // 
            this.boyutUygula.Location = new System.Drawing.Point(185, 27);
            this.boyutUygula.Name = "boyutUygula";
            this.boyutUygula.Size = new System.Drawing.Size(75, 23);
            this.boyutUygula.TabIndex = 3;
            this.boyutUygula.TabStop = false;
            this.boyutUygula.Text = "Uygula";
            this.boyutUygula.UseVisualStyleBackColor = true;
            this.boyutUygula.Click += new System.EventHandler(this.boyutUygula_Click);
            // 
            // bulmacaBoyutu
            // 
            this.bulmacaBoyutu.Location = new System.Drawing.Point(128, 15);
            this.bulmacaBoyutu.MaxLength = 2;
            this.bulmacaBoyutu.Name = "bulmacaBoyutu";
            this.bulmacaBoyutu.Size = new System.Drawing.Size(42, 20);
            this.bulmacaBoyutu.TabIndex = 1;
            this.bulmacaBoyutu.TabStop = false;
            this.bulmacaBoyutu.Text = "15";
            this.bulmacaBoyutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bulmacaBoyutu_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(136, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Min : 5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(181, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Max : 15";
            // 
            // hucreBoyutu
            // 
            this.hucreBoyutu.Location = new System.Drawing.Point(128, 41);
            this.hucreBoyutu.MaxLength = 2;
            this.hucreBoyutu.Name = "hucreBoyutu";
            this.hucreBoyutu.Size = new System.Drawing.Size(42, 20);
            this.hucreBoyutu.TabIndex = 1;
            this.hucreBoyutu.TabStop = false;
            this.hucreBoyutu.Text = "40";
            this.hucreBoyutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hucreBoyutu_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Hücre Boyutu :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Gray;
            this.pictureBox4.Location = new System.Drawing.Point(14, 69);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(250, 1);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Hücre Boyutu : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Bulmaca Boyutu :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Bulmaca Boyutu : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.baslikTextbox);
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 57);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Başlık";
            // 
            // baslikTextbox
            // 
            this.baslikTextbox.Location = new System.Drawing.Point(16, 20);
            this.baslikTextbox.Name = "baslikTextbox";
            this.baslikTextbox.Size = new System.Drawing.Size(258, 20);
            this.baslikTextbox.TabIndex = 16;
            this.baslikTextbox.TabStop = false;
            this.baslikTextbox.TextChanged += new System.EventHandler(this.baslikTextbox_TextChanged);
            // 
            // verticalWordsListView
            // 
            this.verticalWordsListView.Enabled = false;
            this.verticalWordsListView.Location = new System.Drawing.Point(298, 554);
            this.verticalWordsListView.Name = "verticalWordsListView";
            this.verticalWordsListView.Size = new System.Drawing.Size(5, 5);
            this.verticalWordsListView.TabIndex = 11;
            this.verticalWordsListView.UseCompatibleStateImageBehavior = false;
            this.verticalWordsListView.Visible = false;
            // 
            // horizontalWordsListView
            // 
            this.horizontalWordsListView.Enabled = false;
            this.horizontalWordsListView.Location = new System.Drawing.Point(282, 554);
            this.horizontalWordsListView.Name = "horizontalWordsListView";
            this.horizontalWordsListView.Size = new System.Drawing.Size(5, 5);
            this.horizontalWordsListView.TabIndex = 10;
            this.horizontalWordsListView.TabStop = false;
            this.horizontalWordsListView.UseCompatibleStateImageBehavior = false;
            this.horizontalWordsListView.Visible = false;
            // 
            // onizlemeCevaplar
            // 
            this.onizlemeCevaplar.AutoSize = true;
            this.onizlemeCevaplar.Checked = true;
            this.onizlemeCevaplar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onizlemeCevaplar.Location = new System.Drawing.Point(11, 540);
            this.onizlemeCevaplar.Name = "onizlemeCevaplar";
            this.onizlemeCevaplar.Size = new System.Drawing.Size(162, 17);
            this.onizlemeCevaplar.TabIndex = 2;
            this.onizlemeCevaplar.TabStop = false;
            this.onizlemeCevaplar.Text = "Önizlemede Cevapları Göster";
            this.onizlemeCevaplar.UseVisualStyleBackColor = true;
            this.onizlemeCevaplar.CheckedChanged += new System.EventHandler(this.onizlemeCevaplar_CheckedChanged);
            // 
            // A4
            // 
            this.A4.BackColor = System.Drawing.Color.White;
            this.A4.Controls.Add(this.panelSoruCevap);
            this.A4.Controls.Add(this.panelBulmaca);
            this.A4.Controls.Add(this.panelBaslik);
            this.A4.Dock = System.Windows.Forms.DockStyle.Top;
            this.A4.Location = new System.Drawing.Point(0, 0);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(724, 1130);
            this.A4.TabIndex = 0;
            // 
            // panelSoruCevap
            // 
            this.panelSoruCevap.Controls.Add(this.panel1);
            this.panelSoruCevap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSoruCevap.Location = new System.Drawing.Point(0, 494);
            this.panelSoruCevap.Name = "panelSoruCevap";
            this.panelSoruCevap.Size = new System.Drawing.Size(724, 636);
            this.panelSoruCevap.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(70, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 440);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelSoldanSaga);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelYukaridanAsagiya);
            this.splitContainer1.Size = new System.Drawing.Size(600, 440);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // panelSoldanSaga
            // 
            this.panelSoldanSaga.Controls.Add(this.soldanSagaSorular);
            this.panelSoldanSaga.Controls.Add(this.panelSoldanSagaBaslik);
            this.panelSoldanSaga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSoldanSaga.Location = new System.Drawing.Point(0, 0);
            this.panelSoldanSaga.Name = "panelSoldanSaga";
            this.panelSoldanSaga.Size = new System.Drawing.Size(297, 440);
            this.panelSoldanSaga.TabIndex = 6;
            // 
            // soldanSagaSorular
            // 
            this.soldanSagaSorular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soldanSagaSorular.Location = new System.Drawing.Point(0, 43);
            this.soldanSagaSorular.Multiline = true;
            this.soldanSagaSorular.Name = "soldanSagaSorular";
            this.soldanSagaSorular.Size = new System.Drawing.Size(297, 397);
            this.soldanSagaSorular.TabIndex = 18;
            this.soldanSagaSorular.TabStop = false;
            // 
            // panelSoldanSagaBaslik
            // 
            this.panelSoldanSagaBaslik.Controls.Add(this.soldanSagaBaslik);
            this.panelSoldanSagaBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSoldanSagaBaslik.Location = new System.Drawing.Point(0, 0);
            this.panelSoldanSagaBaslik.Name = "panelSoldanSagaBaslik";
            this.panelSoldanSagaBaslik.Size = new System.Drawing.Size(297, 43);
            this.panelSoldanSagaBaslik.TabIndex = 1;
            // 
            // soldanSagaBaslik
            // 
            this.soldanSagaBaslik.AutoSize = true;
            this.soldanSagaBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soldanSagaBaslik.Location = new System.Drawing.Point(0, 9);
            this.soldanSagaBaslik.Name = "soldanSagaBaslik";
            this.soldanSagaBaslik.Size = new System.Drawing.Size(101, 20);
            this.soldanSagaBaslik.TabIndex = 0;
            this.soldanSagaBaslik.Text = "Soldan Sağa";
            // 
            // panelYukaridanAsagiya
            // 
            this.panelYukaridanAsagiya.Controls.Add(this.yukaridanAsagiyaSorular);
            this.panelYukaridanAsagiya.Controls.Add(this.panelYukaridanAsagiyaBaslik);
            this.panelYukaridanAsagiya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelYukaridanAsagiya.Location = new System.Drawing.Point(0, 0);
            this.panelYukaridanAsagiya.Name = "panelYukaridanAsagiya";
            this.panelYukaridanAsagiya.Size = new System.Drawing.Size(299, 440);
            this.panelYukaridanAsagiya.TabIndex = 7;
            // 
            // yukaridanAsagiyaSorular
            // 
            this.yukaridanAsagiyaSorular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yukaridanAsagiyaSorular.Location = new System.Drawing.Point(0, 43);
            this.yukaridanAsagiyaSorular.Multiline = true;
            this.yukaridanAsagiyaSorular.Name = "yukaridanAsagiyaSorular";
            this.yukaridanAsagiyaSorular.Size = new System.Drawing.Size(299, 397);
            this.yukaridanAsagiyaSorular.TabIndex = 17;
            this.yukaridanAsagiyaSorular.TabStop = false;
            // 
            // panelYukaridanAsagiyaBaslik
            // 
            this.panelYukaridanAsagiyaBaslik.Controls.Add(this.yukaridanAsagiyaBaslik);
            this.panelYukaridanAsagiyaBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelYukaridanAsagiyaBaslik.Location = new System.Drawing.Point(0, 0);
            this.panelYukaridanAsagiyaBaslik.Name = "panelYukaridanAsagiyaBaslik";
            this.panelYukaridanAsagiyaBaslik.Size = new System.Drawing.Size(299, 43);
            this.panelYukaridanAsagiyaBaslik.TabIndex = 2;
            // 
            // yukaridanAsagiyaBaslik
            // 
            this.yukaridanAsagiyaBaslik.AutoSize = true;
            this.yukaridanAsagiyaBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yukaridanAsagiyaBaslik.Location = new System.Drawing.Point(0, 9);
            this.yukaridanAsagiyaBaslik.Name = "yukaridanAsagiyaBaslik";
            this.yukaridanAsagiyaBaslik.Size = new System.Drawing.Size(141, 20);
            this.yukaridanAsagiyaBaslik.TabIndex = 2;
            this.yukaridanAsagiyaBaslik.Text = "Yukarıdan Aşağıya";
            // 
            // panelBulmaca
            // 
            this.panelBulmaca.Controls.Add(this.GridPanel);
            this.panelBulmaca.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBulmaca.Location = new System.Drawing.Point(0, 40);
            this.panelBulmaca.Name = "panelBulmaca";
            this.panelBulmaca.Size = new System.Drawing.Size(724, 454);
            this.panelBulmaca.TabIndex = 1;
            // 
            // GridPanel
            // 
            this.GridPanel.Controls.Add(this.panel5);
            this.GridPanel.Controls.Add(this.ustSayilarPanel);
            this.GridPanel.Controls.Add(this.altSayilarPanel);
            this.GridPanel.Location = new System.Drawing.Point(90, 58);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(178, 158);
            this.GridPanel.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grid1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(43, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(135, 115);
            this.panel5.TabIndex = 4;
            // 
            // grid1
            // 
            this.grid1.AllowUserToAddRows = false;
            this.grid1.AllowUserToDeleteRows = false;
            this.grid1.AllowUserToResizeColumns = false;
            this.grid1.AllowUserToResizeRows = false;
            this.grid1.BackgroundColor = System.Drawing.Color.White;
            this.grid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid1.DefaultCellStyle = dataGridViewCellStyle4;
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.GridColor = System.Drawing.Color.Black;
            this.grid1.Location = new System.Drawing.Point(0, 0);
            this.grid1.MultiSelect = false;
            this.grid1.Name = "grid1";
            this.grid1.RowHeadersVisible = false;
            this.grid1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid1.Size = new System.Drawing.Size(135, 115);
            this.grid1.TabIndex = 16;
            this.grid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellDoubleClick);
            this.grid1.Click += new System.EventHandler(this.grid1_Click);
            // 
            // ustSayilarPanel
            // 
            this.ustSayilarPanel.BackColor = System.Drawing.Color.Transparent;
            this.ustSayilarPanel.Controls.Add(this.ustSayilarGrid);
            this.ustSayilarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustSayilarPanel.Location = new System.Drawing.Point(43, 0);
            this.ustSayilarPanel.Name = "ustSayilarPanel";
            this.ustSayilarPanel.Size = new System.Drawing.Size(135, 43);
            this.ustSayilarPanel.TabIndex = 2;
            // 
            // ustSayilarGrid
            // 
            this.ustSayilarGrid.AllowUserToAddRows = false;
            this.ustSayilarGrid.AllowUserToDeleteRows = false;
            this.ustSayilarGrid.AllowUserToResizeColumns = false;
            this.ustSayilarGrid.AllowUserToResizeRows = false;
            this.ustSayilarGrid.BackgroundColor = System.Drawing.Color.White;
            this.ustSayilarGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ustSayilarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ustSayilarGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ustSayilarGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.ustSayilarGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ustSayilarGrid.Enabled = false;
            this.ustSayilarGrid.EnableHeadersVisualStyles = false;
            this.ustSayilarGrid.GridColor = System.Drawing.Color.White;
            this.ustSayilarGrid.Location = new System.Drawing.Point(0, 0);
            this.ustSayilarGrid.MultiSelect = false;
            this.ustSayilarGrid.Name = "ustSayilarGrid";
            this.ustSayilarGrid.ReadOnly = true;
            this.ustSayilarGrid.RowHeadersVisible = false;
            this.ustSayilarGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ustSayilarGrid.Size = new System.Drawing.Size(135, 43);
            this.ustSayilarGrid.TabIndex = 15;
            this.ustSayilarGrid.TabStop = false;
            // 
            // altSayilarPanel
            // 
            this.altSayilarPanel.Controls.Add(this.altSayilarGrid);
            this.altSayilarPanel.Controls.Add(this.boslukPanel);
            this.altSayilarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.altSayilarPanel.Location = new System.Drawing.Point(0, 0);
            this.altSayilarPanel.Name = "altSayilarPanel";
            this.altSayilarPanel.Size = new System.Drawing.Size(43, 158);
            this.altSayilarPanel.TabIndex = 3;
            // 
            // altSayilarGrid
            // 
            this.altSayilarGrid.AllowUserToAddRows = false;
            this.altSayilarGrid.AllowUserToDeleteRows = false;
            this.altSayilarGrid.AllowUserToResizeColumns = false;
            this.altSayilarGrid.AllowUserToResizeRows = false;
            this.altSayilarGrid.BackgroundColor = System.Drawing.Color.White;
            this.altSayilarGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.altSayilarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.altSayilarGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.altSayilarGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.altSayilarGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.altSayilarGrid.Enabled = false;
            this.altSayilarGrid.GridColor = System.Drawing.Color.White;
            this.altSayilarGrid.Location = new System.Drawing.Point(0, 43);
            this.altSayilarGrid.MultiSelect = false;
            this.altSayilarGrid.Name = "altSayilarGrid";
            this.altSayilarGrid.ReadOnly = true;
            this.altSayilarGrid.RowHeadersVisible = false;
            this.altSayilarGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.altSayilarGrid.Size = new System.Drawing.Size(43, 115);
            this.altSayilarGrid.TabIndex = 15;
            this.altSayilarGrid.TabStop = false;
            // 
            // boslukPanel
            // 
            this.boslukPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.boslukPanel.Location = new System.Drawing.Point(0, 0);
            this.boslukPanel.Name = "boslukPanel";
            this.boslukPanel.Size = new System.Drawing.Size(43, 43);
            this.boslukPanel.TabIndex = 0;
            // 
            // panelBaslik
            // 
            this.panelBaslik.Controls.Add(this.baslikPanelKonum);
            this.panelBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBaslik.Location = new System.Drawing.Point(0, 0);
            this.panelBaslik.Name = "panelBaslik";
            this.panelBaslik.Size = new System.Drawing.Size(724, 40);
            this.panelBaslik.TabIndex = 0;
            // 
            // baslikPanelKonum
            // 
            this.baslikPanelKonum.Controls.Add(this.baslikA4);
            this.baslikPanelKonum.Location = new System.Drawing.Point(70, 0);
            this.baslikPanelKonum.Name = "baslikPanelKonum";
            this.baslikPanelKonum.Size = new System.Drawing.Size(600, 40);
            this.baslikPanelKonum.TabIndex = 0;
            // 
            // baslikA4
            // 
            this.baslikA4.AutoSize = true;
            this.baslikA4.BackColor = System.Drawing.Color.White;
            this.baslikA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslikA4.Location = new System.Drawing.Point(240, 5);
            this.baslikA4.Name = "baslikA4";
            this.baslikA4.Size = new System.Drawing.Size(70, 25);
            this.baslikA4.TabIndex = 5;
            this.baslikA4.Text = "Başlık";
            this.baslikA4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAlt
            // 
            this.panelAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.panelAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Location = new System.Drawing.Point(0, 601);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(1064, 10);
            this.panelAlt.TabIndex = 8;
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.panelUst.Controls.Add(this.menuStrip1);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(1064, 25);
            this.panelUst.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bulmacaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bulmacaToolStripMenuItem
            // 
            this.bulmacaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bulmacaAçToolStripMenuItem,
            this.bulmacayıKaydetToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.yazdırToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.bulmacaToolStripMenuItem.Name = "bulmacaToolStripMenuItem";
            this.bulmacaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.bulmacaToolStripMenuItem.Text = "Bulmaca";
            // 
            // bulmacaAçToolStripMenuItem
            // 
            this.bulmacaAçToolStripMenuItem.Name = "bulmacaAçToolStripMenuItem";
            this.bulmacaAçToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.bulmacaAçToolStripMenuItem.Text = "Bulmaca Aç";
            this.bulmacaAçToolStripMenuItem.Click += new System.EventHandler(this.bulmacaAçToolStripMenuItem_Click);
            // 
            // bulmacayıKaydetToolStripMenuItem
            // 
            this.bulmacayıKaydetToolStripMenuItem.Name = "bulmacayıKaydetToolStripMenuItem";
            this.bulmacayıKaydetToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.bulmacayıKaydetToolStripMenuItem.Text = "Bulmacayı Kaydet";
            this.bulmacayıKaydetToolStripMenuItem.Click += new System.EventHandler(this.bulmacayıKaydetToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pdfToolStripMenuItem,
            this.resimToolStripMenuItem});
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // pdfToolStripMenuItem
            // 
            this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
            this.pdfToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.pdfToolStripMenuItem.Text = "Pdf";
            this.pdfToolStripMenuItem.Click += new System.EventHandler(this.pdfToolStripMenuItem_Click);
            // 
            // resimToolStripMenuItem
            // 
            this.resimToolStripMenuItem.Name = "resimToolStripMenuItem";
            this.resimToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.resimToolStripMenuItem.Text = "Resim";
            this.resimToolStripMenuItem.Click += new System.EventHandler(this.resimToolStripMenuItem_Click);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // baslikDialog
            // 
            this.baslikDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslikDialog.MaxSize = 22;
            this.baslikDialog.ShowColor = true;
            // 
            // kelimelerFontDialog
            // 
            this.kelimelerFontDialog.MaxSize = 18;
            this.kelimelerFontDialog.ShowColor = true;
            // 
            // numaralarFontDialog
            // 
            this.numaralarFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numaralarFontDialog.MaxSize = 18;
            this.numaralarFontDialog.ShowColor = true;
            // 
            // sorularFontDialog
            // 
            this.sorularFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorularFontDialog.MaxSize = 16;
            this.sorularFontDialog.ShowColor = true;
            // 
            // basliklarFontDialog
            // 
            this.basliklarFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basliklarFontDialog.MaxSize = 26;
            this.basliklarFontDialog.ShowColor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelUst);
            this.Controls.Add(this.panelAlt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tek Bulmaca";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panelOrta.Panel1.ResumeLayout(false);
            this.panelOrta.Panel1.PerformLayout();
            this.panelOrta.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelOrta)).EndInit();
            this.panelOrta.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notUsedListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruCevapGrid)).EndInit();
            this.ayarlarTab.ResumeLayout(false);
            this.baslik.ResumeLayout(false);
            this.baslik.PerformLayout();
            this.kelimeler.ResumeLayout(false);
            this.kelimeler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arkaplanResimPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelerArkaplanRenk)).EndInit();
            this.sorular.ResumeLayout(false);
            this.sorular.PerformLayout();
            this.arkaplan.ResumeLayout(false);
            this.arkaplan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arkaplanRenk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerceveRenk)).EndInit();
            this.hucre.ResumeLayout(false);
            this.hucre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.A4.ResumeLayout(false);
            this.panelSoruCevap.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelSoldanSaga.ResumeLayout(false);
            this.panelSoldanSaga.PerformLayout();
            this.panelSoldanSagaBaslik.ResumeLayout(false);
            this.panelSoldanSagaBaslik.PerformLayout();
            this.panelYukaridanAsagiya.ResumeLayout(false);
            this.panelYukaridanAsagiya.PerformLayout();
            this.panelYukaridanAsagiyaBaslik.ResumeLayout(false);
            this.panelYukaridanAsagiyaBaslik.PerformLayout();
            this.panelBulmaca.ResumeLayout(false);
            this.GridPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ustSayilarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ustSayilarGrid)).EndInit();
            this.altSayilarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.altSayilarGrid)).EndInit();
            this.panelBaslik.ResumeLayout(false);
            this.baslikPanelKonum.ResumeLayout(false);
            this.baslikPanelKonum.PerformLayout();
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelAlt;
        private System.Windows.Forms.SplitContainer panelOrta;
        private System.Windows.Forms.ListView verticalWordsListView;
        private System.Windows.Forms.ListView horizontalWordsListView;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.CheckBox onizlemeCevaplar;
        private System.Windows.Forms.TabControl ayarlarTab;
        private System.Windows.Forms.TabPage baslik;
        private System.Windows.Forms.TabPage kelimeler;
        private System.Windows.Forms.Button ekleButon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView soruCevapGrid;
        private System.Windows.Forms.DataGridView notUsedListView;
        private System.Windows.Forms.TabPage sorular;
        private System.Windows.Forms.Label kelimelerArkaplanRenkYazi;
        private System.Windows.Forms.PictureBox kelimelerArkaplanRenk;
        private System.Windows.Forms.TabPage hucre;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button boyutUygula;
        private System.Windows.Forms.TextBox hucreBoyutu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox bulmacaBoyutu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel A4;
        private System.Windows.Forms.Panel panelSoruCevap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelSoldanSaga;
        private System.Windows.Forms.Panel panelSoldanSagaBaslik;
        private System.Windows.Forms.Label soldanSagaBaslik;
        private System.Windows.Forms.Panel panelYukaridanAsagiya;
        private System.Windows.Forms.Panel panelYukaridanAsagiyaBaslik;
        private System.Windows.Forms.Label yukaridanAsagiyaBaslik;
        private System.Windows.Forms.Panel panelBulmaca;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel ustSayilarPanel;
        private System.Windows.Forms.DataGridView ustSayilarGrid;
        private System.Windows.Forms.Panel altSayilarPanel;
        private System.Windows.Forms.DataGridView altSayilarGrid;
        private System.Windows.Forms.Panel boslukPanel;
        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bulmacaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Panel panelBaslik;
        private System.Windows.Forms.Panel baslikPanelKonum;
        private System.Windows.Forms.Label baslikA4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button kelimelerOzellik;
        private System.Windows.Forms.Button baslikOzellik;
        private System.Windows.Forms.ComboBox baslikHiza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FontDialog baslikDialog;
        private System.Windows.Forms.ColorDialog kelimelerCerceveColorDialog;
        private System.Windows.Forms.Button numaralarOzellik;
        private System.Windows.Forms.ColorDialog kelimelerHucreColorDialog;
        private System.Windows.Forms.FontDialog kelimelerFontDialog;
        private System.Windows.Forms.FontDialog numaralarFontDialog;
        private System.Windows.Forms.CheckBox kelimelerKucukHarf;
        private System.Windows.Forms.TabPage arkaplan;
        private System.Windows.Forms.Label cerceveRenkYazi;
        private System.Windows.Forms.PictureBox cerceveRenk;
        private System.Windows.Forms.PictureBox arkaplanResimPictureBox;
        private System.Windows.Forms.Label arkaplanRenkYazi;
        private System.Windows.Forms.PictureBox arkaplanRenk;
        private System.Windows.Forms.ColorDialog kelimelerArkaplanColorDialog;
        private System.Windows.Forms.FontDialog sorularFontDialog;
        private System.Windows.Forms.ComboBox basliklarHizalama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button basliklarOzellik;
        private System.Windows.Forms.ComboBox pozisyon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FontDialog basliklarFontDialog;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox kelimeEkleText;
        private System.Windows.Forms.TextBox baslikTextbox;
        private System.Windows.Forms.TextBox soldanSagaSorular;
        private System.Windows.Forms.TextBox yukaridanAsagiyaSorular;
        private System.Windows.Forms.ToolStripMenuItem bulmacaAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulmacayıKaydetToolStripMenuItem;
        private DataGridViewEx grid1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem pdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimToolStripMenuItem;
    }
}

