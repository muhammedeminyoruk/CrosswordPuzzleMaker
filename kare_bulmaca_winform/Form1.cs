using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using kare_bulmaca_winform;

namespace CrosswordCreator
{
    public partial class Form1 : Form
    {

        private readonly List<string> _words = new List<string>();

        private List<string> _order;

        Crossword.Crossword _board;
        Random _rand = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (InnerTrim(kelimeEkleText.Text.Trim()) != "")
            {
                if (kelimeBuyukluk == "büyük")
                {
                    var word = InnerTrim(kelimeEkleText.Text.Trim().ToUpper());
                    if (_words.Contains(word))
                    {
                        MessageBox.Show("Cevap olarak aynı kelime var lütfen farklı bir kelime giriniz", "Uyarı");
                        return;
                    }
                    else
                    {
                        _words.Add(word);
                        soruCevapGrid.Rows.Add(word);
                    }
                }
                if (kelimeBuyukluk == "küçük")
                {
                    var word = kelimeEkleText.Text.Trim().ToLower();
                    if (_words.Contains(word))
                    {
                        MessageBox.Show("Cevap olarak aynı kelime var lütfen farklı bir kelime giriniz", "Uyarı");
                        return;
                    }
                    else
                    {
                        _words.Add(word);
                        soruCevapGrid.Rows.Add(word);
                    }
                }
                kelimeEkleText.Clear();
                soruCevapGrid.ClearSelection();
                notUsedListView.ClearSelection();
                GenerateButton.PerformClick();
                kelimeEkleText.Focus();
            }
            else
            {
                kelimeEkleText.Text = "";
                kelimeEkleText.Focus();
            }
        }

        public static string InnerTrim(string input)
        {
            return input.Trim().Replace(" ", string.Empty);
        }

        static int Comparer(string a, string b)
        {
            var temp = a.Length.CompareTo(b.Length);
            return temp == 0 ? a.CompareTo(b) : temp;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            _words.Sort(Comparer);
            _words.Reverse();
            _order = _words;
            GenCrossword();
            kelimeEkleText.Focus();
            

            foreach (DataGridViewRow row in soruCevapGrid.Rows)
            {
                foreach (DataGridViewRow row1 in notUsedListView.Rows)
                {
                    if (row.Cells[0].Value.ToString().ToUpper() == row1.Cells[0].Value.ToString().ToUpper())
                    {
                        if(row.Index != -1)
                        {
                            soruCevapGrid.Rows.Remove(row);
                        }
                    }
                }
            }
            /*
            foreach (DataGridViewRow row in notUsedListView.Rows)
            {
                foreach (DataGridViewRow row1 in soruCevapGrid.Rows)
                {
                    if (row.Cells[0].Value.ToString().ToUpper() == row1.Cells[0].Value.ToString().ToUpper())
                    {
                        if (row.Index != -1)
                        {
                            notUsedListView.Rows.Remove(row);
                        }
                    }
                }
            }
            */

            kelimeEkleText.Focus();
        }
        


        void GenCrossword()
        {
            horizontalWordsListView.Items.Clear();
            verticalWordsListView.Items.Clear();
            notUsedListView.Rows.Clear(); ;
            _board.Reset();
            ClearBoard();
            
            foreach (var word in _order)
            {
                //var wordToInsert = ((bool)RTLRadioButton.IsChecked) ? word.Reverse().Aggregate("",(x,y) => x + y) : word;

                switch (_board.AddWord(word))
                {
                    case 0:
                        horizontalWordsListView.Items.Add(word);
                        int say = 0;
                        foreach (DataGridViewRow row in soruCevapGrid.Rows)
                        {
                            if (row.Cells[0].Value.ToString().ToUpper() == word.ToUpper())
                                say++;
                        }
                        if(say == 0)
                        {
                            soruCevapGrid.Rows.Add(word);
                        }
                        break;
                    case 1:
                        verticalWordsListView.Items.Add(word);
                        int say1 = 0;
                        foreach (DataGridViewRow row in soruCevapGrid.Rows)
                        {
                            if (row.Cells[0].Value.ToString().ToUpper() == word.ToUpper())
                                say1++;
                        }
                        if (say1 == 0)
                        {
                            soruCevapGrid.Rows.Add(word);
                        }
                        break;
                    default:
                        notUsedListView.Rows.Add(word);
                        break;

                }
            }
            ActualizeData();
        }

        private Color kontrolRenk = Color.White;
        private Color kontrolArkaplanRenk = Color.Black;

        void ActualizeData()
        {
            var count = _board.N * _board.M;

            var board = _board.GetBoard;
            
            for (var i = 0; i < _board.N; i++)
            {
                for (var j = 0; j < _board.M; j++)
                {
                    var letter = board[i, j] == '*' ? ' ' : board[i, j];
                    if (letter != ' ')
                    {
                        count--;
                    }

                    DataGridViewCell c = grid1[i, j];
                    if(arkaplanResimPictureBox.Image != null)
                    {
                        if (letter != ' ' && c.Style.BackColor != Color.Transparent)
                        {
                            c.Style.BackColor = Color.Transparent;
                            c.Value = letter.ToString();

                        }
                    }
                    if (arkaplanResimPictureBox.Image == null)
                    {
                        if (letter != ' ' && c.Style.BackColor != kontrolRenk)
                        {
                            c.Style.BackColor = kontrolRenk;
                            c.Value = letter.ToString();

                        }
                    }

                }
            }
        }

        void GenOrder()
        {
            _order = _words.Where(word => _rand.NextDouble() > 0.3).ToList();// (_words);
        }

        void ClearBoard()
        {

            for (var i = 0; i < _board.N; i++)
            {
                for (var j = 0; j < _board.M; j++)
                {
                    DataGridViewCell c = grid1[j, i];
                    c.Style.BackColor = kontrolArkaplanRenk;
                    c.Value = "";

                }
            }
        }


        private void RTLRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            kelimeEkleText.Focus();
        }
        
        

        private int boardGenislikTut = 0;
        private int boardYukseklikTut = 0;

        private String kelimeBuyukluk = "büyük";

        private int bulmacaBoyutuDegiskeni = 15, hucreBoyutuDegiskeni = 40;

        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ContextMenuStrip mnu = new ContextMenuStrip();
                ToolStripMenuItem mnuCopyAll = new ToolStripMenuItem("Kopyala");
                mnuCopyAll.Click += new EventHandler(mnuCopyAll_Click);
                mnu.Items.AddRange(new ToolStripItem[] { mnuCopyAll });
                soruCevapGrid.ContextMenuStrip = mnu;

                ContextMenuStrip mnu1 = new ContextMenuStrip();
                ToolStripMenuItem mnuCopyAll1 = new ToolStripMenuItem("Kopyala");
                mnuCopyAll1.Click += new EventHandler(mnuCopyAll_Click1);
                mnu1.Items.AddRange(new ToolStripItem[] { mnuCopyAll1 });
                notUsedListView.ContextMenuStrip = mnu1;
            }
            catch
            {
            }
            
            _board = new Crossword.Crossword(bulmacaBoyutuDegiskeni, bulmacaBoyutuDegiskeni);
            sutunOlustur(bulmacaBoyutuDegiskeni);
            satirOlustur(bulmacaBoyutuDegiskeni);
            arkaplanRenklendir(kontrolArkaplanRenk);
            baslikA4YerAyarla();
            sutunGenislikAyarla(hucreBoyutuDegiskeni);
            satirYukseklikAyarla(hucreBoyutuDegiskeni);
            okunabilirYap();
            boardBoyutuAyarla();
            boslukPanelBoyutuAyarla(hucreBoyutuDegiskeni);
            ustSayilarGridPanelBoyutuAyarla(hucreBoyutuDegiskeni);
            altSayilarGridPanelBoyutuAyarla(hucreBoyutuDegiskeni);
            sayilarDoldur();
            gridPanelBoyutuAyarla(hucreBoyutuDegiskeni);
            boardCerceveRengiAyarla(kontrolArkaplanRenk);
            boardYeriniAyarla();
            grid1.ClearSelection();
            
            baslikTabDoldur();

            kelimeEkleText.Focus();
            
        }

        private void mnuCopyAll_Click(object sender, EventArgs e)
        {
            try
            {
                var newline = System.Environment.NewLine;
                var tab = "\t";
                var clipboard_string = new StringBuilder();
                
                foreach (DataGridViewRow row in soruCevapGrid.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (i == (row.Cells.Count - 1))
                            clipboard_string.Append(row.Cells[i].Value + newline);
                        else
                            clipboard_string.Append(row.Cells[i].Value + tab);
                    }
                }

                Clipboard.SetDataObject(clipboard_string.ToString());
            }
            catch
            {
            }

        }
        private void mnuCopyAll_Click1(object sender, EventArgs e)
        {
            try
            {
                var newline = System.Environment.NewLine;
                var tab = "\t";
                var clipboard_string = new StringBuilder();

                foreach (DataGridViewRow row in notUsedListView.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (i == (row.Cells.Count - 1))
                            clipboard_string.Append(row.Cells[i].Value + newline);
                        else
                            clipboard_string.Append(row.Cells[i].Value + tab);
                    }
                }

                Clipboard.SetDataObject(clipboard_string.ToString());
            }
            catch
            {
            }

        }
        private void baslikTabDoldur()
        {
            baslikHiza.Text = "Sol";
            pozisyon.Text = "Yan yana";
            baslikTextbox.Text = "Başlık";

            basliklarHizalama.Text = "Sol";
            soruBasliklariHizala();
        }

        private void sayilarDoldur()
        {
            for (int i = 0; i < ustSayilarGrid.ColumnCount; i++)
            {
                ustSayilarGrid.Rows[0].Cells[i].Value = i + 1;
            }
            for (int i = 0; i < altSayilarGrid.RowCount; i++)
            {
                altSayilarGrid.Rows[i].Cells[0].Value = i + 1;
            }
            altSayilarGrid.ClearSelection();
            ustSayilarGrid.ClearSelection();
        }
        
        private void baslikA4YerAyarla()
        {
            float x = (Convert.ToInt32(baslikPanelKonum.Width) - Convert.ToInt32(baslikA4.Width)) / 2;
            float y = (Convert.ToInt32(baslikPanelKonum.Height) - Convert.ToInt32(baslikA4.Height))-3;

            baslikA4.Location = new Point(x: Convert.ToInt32(x), y: Convert.ToInt32(y));
        }

        private void boardYeriniAyarla()
        {
            float x = (Convert.ToInt32(panelBulmaca.Width) - Convert.ToInt32(GridPanel.Width)) / 2;

            GridPanel.Location = new Point(x: Convert.ToInt32(x - 10), y: Convert.ToInt32(0));
        }

        private void sutunOlustur(int sutunSayisi)
        {
            altSayilarGrid.Columns.Add("Column", "Hücre");
            for (int i = 0; i < sutunSayisi; i++)
            {
                grid1.Columns.Add("Column", "Hücre");
                ustSayilarGrid.Columns.Add("Column", "");
            }
        }

        private void satirOlustur(int satirSayisi)
        {
            ustSayilarGrid.Rows.Add();
            for (int i = 0; i < satirSayisi; i++)
            {
                grid1.Rows.Add();
                altSayilarGrid.Rows.Add();
            }
        }

        private void arkaplanRenklendir(Color renk)
        {
            grid1.BackgroundColor = renk;
            grid1.DefaultCellStyle.BackColor = renk;

            ustSayilarGrid.BackgroundColor = Color.White;
            ustSayilarGrid.DefaultCellStyle.BackColor = Color.White;

            altSayilarGrid.BackgroundColor = Color.White;
            altSayilarGrid.DefaultCellStyle.BackColor = Color.White;
        }

        private void sutunGenislikAyarla(int sutunGenislik)
        {
            foreach (DataGridViewColumn c in grid1.Columns)
            {
                boardGenislikTut += sutunGenislik;
                c.Width = sutunGenislik;
            }
            foreach (DataGridViewColumn c in altSayilarGrid.Columns)
            {
                c.Width = sutunGenislik;
            }
            foreach (DataGridViewColumn c in ustSayilarGrid.Columns)
            {
                c.Width = sutunGenislik;
            }
        }

        private void satirYukseklikAyarla(int satirYukseklik)
        {
            foreach (DataGridViewRow r in grid1.Rows)
            {
                boardYukseklikTut += satirYukseklik;
                r.Height = satirYukseklik;
            }
            foreach (DataGridViewRow r in altSayilarGrid.Rows)
            {
                r.Height = satirYukseklik;
            }
            foreach (DataGridViewRow r in ustSayilarGrid.Rows)
            {
                r.Height = satirYukseklik;
            }
        }

        private void okunabilirYap()
        {
            /*
            for (int row = 0; row < grid1.Rows.Count; row++)
            {
                for (int col = 0; col < grid1.Columns.Count; col++)
                {
                    grid1[col, row].ReadOnly = true;
                }
            }
            */
        }

        private void boardBoyutuAyarla()
        {
            grid1.Width = boardGenislikTut;
            grid1.Height = boardYukseklikTut;
        }


        private void gridPanelBoyutuAyarla(int hucreBoyutu)
        {
            GridPanel.Width = boardGenislikTut + hucreBoyutu + 2;
            GridPanel.Height = boardYukseklikTut + hucreBoyutu + 2;
            panelBulmaca.Height = boardYukseklikTut + hucreBoyutu + 2;
        }

        private void boslukPanelBoyutuAyarla(int hucreBoyutu)
        {
            boslukPanel.Height = hucreBoyutu + 1;
            boslukPanel.Width = hucreBoyutu + 1;
        }

        private void ustSayilarGridPanelBoyutuAyarla(int hucreBoyutu)
        {
            ustSayilarPanel.Height = hucreBoyutu + 1;
        }

        private void altSayilarGridPanelBoyutuAyarla(int hucreBoyutu)
        {
            altSayilarPanel.Width = hucreBoyutu + 1;
        }

        private void boardCerceveRengiAyarla(Color renk)
        {
            grid1.GridColor = renk;
        }
        


        private void baslikHiza_SelectedIndexChanged(object sender, EventArgs e)
        {
            baslikHizala();
        }

        private void baslikHizala()
        {
            if (baslikHiza.Text.ToUpper() == "SOL")
            {
                float y = (Convert.ToInt32(baslikPanelKonum.Height) - Convert.ToInt32(baslikA4.Height))-3;

                baslikA4.Location = new Point(x: Convert.ToInt32(0), y: Convert.ToInt32(y));
            }
            if (baslikHiza.Text.ToUpper() == "ORTA")
            {
                float x = (Convert.ToInt32(baslikPanelKonum.Width) - Convert.ToInt32(baslikA4.Width)) / 2;
                float y = (Convert.ToInt32(baslikPanelKonum.Height) - Convert.ToInt32(baslikA4.Height))-3;

                baslikA4.Location = new Point(x: Convert.ToInt32(x), y: Convert.ToInt32(y));
            }
            if (baslikHiza.Text.ToUpper() == "SAĞ")
            {
                float x = (Convert.ToInt32(baslikPanelKonum.Width) - Convert.ToInt32(baslikA4.Width));
                float y = (Convert.ToInt32(baslikPanelKonum.Height) - Convert.ToInt32(baslikA4.Height))-3;

                baslikA4.Location = new Point(x: Convert.ToInt32(x), y: Convert.ToInt32(y));
            }
        }

        private void baslikTextbox_TextChanged(object sender, EventArgs e)
        {
            baslikA4.Text = baslikTextbox.Text;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void baslikOzellik_Click(object sender, EventArgs e)
        {
            baslikDialog.ShowDialog();
            baslikA4.Font = baslikDialog.Font;
            baslikA4.ForeColor = baslikDialog.Color;
            baslikHizala();
        }
        private Color cerceveRengiDegiskeni = Color.Black;
        private void cerceveRenk_Click(object sender, EventArgs e)
        {
            kelimelerCerceveColorDialog.ShowDialog();
            grid1.GridColor = kelimelerCerceveColorDialog.Color;
            cerceveRenk.BackColor = kelimelerCerceveColorDialog.Color;
            cerceveRengiDegiskeni = kelimelerCerceveColorDialog.Color;
        }

        private void arkaplanRenk_Click(object sender, EventArgs e)
        {
            kelimelerHucreColorDialog.ShowDialog();
            if (kelimelerHucreColorDialog.Color == arkaplanRenk.BackColor)
            {
                MessageBox.Show("Kelimelerin olduğu arkaplan rengi ile boşta olan arkaplan rengi aynı olamaz.", "Uyarı");
            }
            else
            {
                if(arkaplanResimPictureBox.Image != null)
                {
                    grid1.BackgroundImage = null;
                    arkaplanResimPictureBox.Image = null;
                    grid1.Refresh();

                    for (var i = 0; i < grid1.RowCount; i++)
                    {
                        for (var j = 0; j < grid1.ColumnCount; j++)
                        {
                            DataGridViewCell c = grid1[i, j];
                            if (!string.IsNullOrEmpty(c.Value as string))
                            {
                                c.Style.BackColor = kelimelerHucreColorDialog.Color;
                            }
                        }
                    }

                }
                if (arkaplanResimPictureBox.Image == null)
                {
                    for (var i = 0; i < grid1.RowCount; i++)
                    {
                        for (var j = 0; j < grid1.ColumnCount; j++)
                        {
                            DataGridViewCell c = grid1[i, j];
                            if (kontrolRenk == c.Style.BackColor)
                            {
                                c.Style.BackColor = kelimelerHucreColorDialog.Color;
                            }
                        }
                    }
                }
                kelimelerArkaplanRenk.BackColor = kelimelerHucreColorDialog.Color;
                kontrolRenk = kelimelerHucreColorDialog.Color;

                cevaplariGosterGizle();

            }
        }

        private Color hucreForeColor = Color.Black;
        private void button2_Click_1(object sender, EventArgs e)
        {
            kelimelerFontDialog.ShowDialog();

            for (var i = 0; i < grid1.RowCount; i++)
            {
                for (var j = 0; j < grid1.ColumnCount; j++)
                {
                    DataGridViewCell c = grid1[i, j];
                    c.Style.Font = kelimelerFontDialog.Font;
                    c.Style.ForeColor = kelimelerFontDialog.Color;
                }
            }

            grid1.DefaultCellStyle.Font = kelimelerFontDialog.Font;
            grid1.DefaultCellStyle.ForeColor = kelimelerFontDialog.Color;
            hucreForeColor = kelimelerFontDialog.Color;
            
        }

        private void numaralarOzellik_Click(object sender, EventArgs e)
        {
            numaralarFontDialog.ShowDialog();
            ustSayilarGrid.DefaultCellStyle.Font = numaralarFontDialog.Font;
            ustSayilarGrid.DefaultCellStyle.ForeColor = numaralarFontDialog.Color;
            altSayilarGrid.DefaultCellStyle.Font = numaralarFontDialog.Font;
            altSayilarGrid.DefaultCellStyle.ForeColor = numaralarFontDialog.Color;
        }
        

        private void kelimelerKucukHarf_CheckedChanged(object sender, EventArgs e)
        {
            if (kelimelerKucukHarf.Checked)
            {
                for (var i = 0; i < grid1.RowCount; i++)
                {
                    for (var j = 0; j < grid1.ColumnCount; j++)
                    {
                        DataGridViewCell c = grid1[i, j];
                        if (!string.IsNullOrEmpty(c.Value as string))
                        {
                            c.Value = c.Value.ToString().ToLower();
                        }
                    }
                }
                kelimeBuyukluk = "küçük";

                for(int k = 0; k < _words.Count; k++)
                {
                    _words[k] = _words[k].ToLower();
                }

                for (int l = 0; l < soruCevapGrid.RowCount; l++)
                {
                    soruCevapGrid.Rows[l].Cells[0].Value = soruCevapGrid.Rows[l].Cells[0].Value.ToString().ToLower();
                }

                for (int m = 0; m < notUsedListView.RowCount; m++)
                {
                    notUsedListView.Rows[m].Cells[0].Value = notUsedListView.Rows[m].Cells[0].Value.ToString().ToLower();
                }
            }
            else
            {
                for (var i = 0; i < grid1.RowCount; i++)
                {
                    for (var j = 0; j < grid1.ColumnCount; j++)
                    {
                        DataGridViewCell c = grid1[i, j];
                        if (!string.IsNullOrEmpty(c.Value as string))
                        {
                            c.Value = c.Value.ToString().ToUpper();
                        }

                    }
                }
                kelimeBuyukluk = "büyük";
                for (int k = 0; k < _words.Count; k++)
                {
                    _words[k] = _words[k].ToUpper();
                }

                for (int l = 0; l < soruCevapGrid.RowCount; l++)
                {
                    soruCevapGrid.Rows[l].Cells[0].Value = soruCevapGrid.Rows[l].Cells[0].Value.ToString().ToUpper();
                }

                for (int m = 0; m < notUsedListView.RowCount; m++)
                {
                    notUsedListView.Rows[m].Cells[0].Value = notUsedListView.Rows[m].Cells[0].Value.ToString().ToUpper();
                }
            }
        }

        private void arkaplanRenk_Click_1(object sender, EventArgs e)
        {
            kelimelerArkaplanColorDialog.ShowDialog();
            if (kelimelerArkaplanRenk.BackColor == kelimelerArkaplanColorDialog.Color)
            {
                MessageBox.Show("Kelimelerin olduğu arkaplan rengi ile boşta olan arkaplan rengi aynı olamaz.", "Uyarı");
            }
            else
            {
                if(arkaplanResimPictureBox.Image != null)
                {
                    for (var i = 0; i < grid1.RowCount; i++)
                    {
                        for (var j = 0; j < grid1.ColumnCount; j++)
                        {
                            DataGridViewCell c = grid1[i, j];
                            if (Color.Transparent != c.Style.BackColor)
                            {
                                c.Style.BackColor = kelimelerArkaplanColorDialog.Color;
                            }
                        }
                    }
                }
                if(arkaplanResimPictureBox.Image == null)
                {
                    for (var i = 0; i < grid1.RowCount; i++)
                    {
                        for (var j = 0; j < grid1.ColumnCount; j++)
                        {
                            DataGridViewCell c = grid1[i, j];
                            if (kontrolRenk != c.Style.BackColor)
                            {
                                c.Style.BackColor = kelimelerArkaplanColorDialog.Color;
                            }
                        }
                    }
                }

                arkaplanRenk.BackColor = kelimelerArkaplanColorDialog.Color;
                kontrolArkaplanRenk = kelimelerArkaplanColorDialog.Color;
                /*
                for (var i = 0; i < grid1.RowCount; i++)
                {
                    for (var j = 0; j < grid1.ColumnCount; j++)
                    {
                        DataGridViewCell c = grid1[i, j];
                        if (c.Value != null)
                        {
                            c.Style.BackColor = kontrolRenk;
                        }
                    }
                }
                */
            }
        }
        
        private void pozisyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pozisyon.Text == "Yan yana")
            {
                splitContainer1.Orientation = Orientation.Vertical;
                splitContainer1.SplitterDistance = 298;
            }
            if (pozisyon.Text == "Alt alta")
            {
                splitContainer1.Orientation = Orientation.Horizontal;
                splitContainer1.SplitterDistance = 218;
            }
        }

        private void basliklarHizalama_SelectedIndexChanged(object sender, EventArgs e)
        {
            soruBasliklariHizala();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sorularFontDialog.ShowDialog();
            soldanSagaSorular.Font = sorularFontDialog.Font;
            soldanSagaSorular.ForeColor = sorularFontDialog.Color;
            yukaridanAsagiyaSorular.Font = sorularFontDialog.Font;
            yukaridanAsagiyaSorular.ForeColor = sorularFontDialog.Color;
        }

        private void basliklarOzellik_Click(object sender, EventArgs e)
        {
            basliklarFontDialog.ShowDialog();
            soldanSagaBaslik.Font = basliklarFontDialog.Font;
            soldanSagaBaslik.ForeColor = basliklarFontDialog.Color;
            yukaridanAsagiyaBaslik.Font = basliklarFontDialog.Font;
            yukaridanAsagiyaBaslik.ForeColor = basliklarFontDialog.Color;
            soruBasliklariHizala();
        }

        private void soruBasliklariHizala()
        {
            if (basliklarHizalama.Text.ToUpper() == "SOL")
            {
                float y = (Convert.ToInt32(panelSoldanSagaBaslik.Height) - Convert.ToInt32(soldanSagaBaslik.Height)) / 2;
                float y1 = (Convert.ToInt32(panelYukaridanAsagiyaBaslik.Height) - Convert.ToInt32(yukaridanAsagiyaBaslik.Height)) / 2;

                soldanSagaBaslik.Location = new Point(x: Convert.ToInt32(0), y: Convert.ToInt32(y));
                yukaridanAsagiyaBaslik.Location = new Point(x: Convert.ToInt32(0), y: Convert.ToInt32(y1));
            }
            if (basliklarHizalama.Text.ToUpper() == "ORTA")
            {
                float x = (Convert.ToInt32(panelSoldanSagaBaslik.Width) - Convert.ToInt32(soldanSagaBaslik.Width)) / 2;
                float y = (Convert.ToInt32(panelSoldanSagaBaslik.Height) - Convert.ToInt32(soldanSagaBaslik.Height)) / 2;
                float x1 = (Convert.ToInt32(panelYukaridanAsagiyaBaslik.Width) - Convert.ToInt32(yukaridanAsagiyaBaslik.Width)) / 2;
                float y1 = (Convert.ToInt32(panelYukaridanAsagiyaBaslik.Height) - Convert.ToInt32(yukaridanAsagiyaBaslik.Height)) / 2;

                soldanSagaBaslik.Location = new Point(x: Convert.ToInt32(x), y: Convert.ToInt32(y));
                yukaridanAsagiyaBaslik.Location = new Point(x: Convert.ToInt32(x1), y: Convert.ToInt32(y1));
            }
            if (basliklarHizalama.Text.ToUpper() == "SAĞ")
            {
                float x = (Convert.ToInt32(panelSoldanSagaBaslik.Width) - Convert.ToInt32(soldanSagaBaslik.Width));
                float y = (Convert.ToInt32(panelSoldanSagaBaslik.Height) - Convert.ToInt32(soldanSagaBaslik.Height)) / 2;
                float x1 = (Convert.ToInt32(panelYukaridanAsagiyaBaslik.Width) - Convert.ToInt32(yukaridanAsagiyaBaslik.Width));
                float y1 = (Convert.ToInt32(panelYukaridanAsagiyaBaslik.Height) - Convert.ToInt32(yukaridanAsagiyaBaslik.Height)) / 2;

                soldanSagaBaslik.Location = new Point(x: Convert.ToInt32(x), y: Convert.ToInt32(y));
                yukaridanAsagiyaBaslik.Location = new Point(x: Convert.ToInt32(x1), y: Convert.ToInt32(y1));
            }
        }

        private void onizlemeCevaplar_CheckedChanged(object sender, EventArgs e)
        {
            cevaplariGosterGizle();
        }

        private void cevaplariGosterGizle()
        {
            if (onizlemeCevaplar.Checked)
            {
                for (var i = 0; i < grid1.RowCount; i++)
                {
                    for (var j = 0; j < grid1.ColumnCount; j++)
                    {
                        DataGridViewCell c = grid1[i, j];
                        c.Style.ForeColor = hucreForeColor;
                    }
                }
            }
            else
            {
                for (var i = 0; i < grid1.RowCount; i++)
                {
                    for (var j = 0; j < grid1.ColumnCount; j++)
                    {
                        DataGridViewCell c = grid1[i, j];
                        c.Style.ForeColor = c.Style.BackColor;
                    }
                }
            }
        }

        private void bulmacaBoyutu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void hucreBoyutu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kelimeEkleText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        
        
        public static byte[] imageToByteArray(System.Drawing.Image imageori)
        {
            using (var ms = new MemoryStream())
            {
                imageori.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult yazdirmaIslemi;
            yazdirmaIslemi = printPreviewDialog1.ShowDialog();
            if (yazdirmaIslemi == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {

                kelimeEkleText.Focus();
                soldanSagaSorular.BorderStyle = BorderStyle.None;
                yukaridanAsagiyaSorular.BorderStyle = BorderStyle.None;

                MemoryStream ms = new MemoryStream();
                Bitmap resim = new Bitmap(A4.Width, A4.Height);
                A4.DrawToBitmap(resim, new System.Drawing.Rectangle(0, 0, A4.Width, A4.Height));
                System.Drawing.Rectangle m = e.MarginBounds;


                soldanSagaSorular.BorderStyle = BorderStyle.FixedSingle;
                yukaridanAsagiyaSorular.BorderStyle = BorderStyle.FixedSingle;

                if ((double)resim.Width / (double)resim.Height > (double)m.Width / (double)m.Height) // image is wider
                {
                    m.Height = (int)((double)resim.Height / (double)resim.Width * (double)m.Width);
                }
                else
                {
                    m.Width = (int)((double)resim.Width / (double)resim.Height * (double)m.Height);
                }
                e.Graphics.DrawImage(resim, m);
            }
            catch (Exception)
            {
            }
        }

        private void cevaplarSutunOlustur()
        {
            soruCevapGrid.Columns.Add("Column", "Hücre");
            notUsedListView.Columns.Add("Column", "Hücre");
        }

        private void kelimeEkleText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ekleButon.PerformClick();
            }
        }

        public String puzzle_file;
        private void bulmacaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text File | *.txt";
                if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
                {
                    soruCevapGrid.Rows.Clear();
                    _words.Clear();

                    ekleButon.PerformClick();
                    var reader = new StreamReader(openFileDialog.FileName, true);

                    while (!reader.EndOfStream)
                    {
                        var word = reader.ReadLine().Trim();
                        //soruCevapGrid.Rows.Add(word.ToUpper());
                        _words.Add(word.ToUpper());
                    }
                }
            }
            catch
            {
            }
            GenerateButton.PerformClick();
            kelimeEkleText.Focus();
        }

        private void bulmacayıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "bulmaca.txt";
            save.Title = "Bulmaca Kayıt";
            save.Filter = "Text Dosyası (*.txt) | *.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                for (int i = 0; i < soruCevapGrid.RowCount; i++)
                {
                    writer.WriteLine(soruCevapGrid.Rows[i].Cells[0].Value.ToString());
                }
                for (int j = 0; j < notUsedListView.RowCount; j++)
                {
                    writer.WriteLine(notUsedListView.Rows[j].Cells[0].Value.ToString());
                }
                writer.Dispose();
                writer.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid1.BackgroundImage = null;
            arkaplanResimPictureBox.Image = null;
        }
        
        private void arkaplanResimPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Kelimeler Arkaplan Resmi";
            openFileDialog.Filter = "Resim Dosyası (*.png, *.bmp, *.jpg) | *.png; *.bmp; *.jpg";
            if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                grid1.BackgroundImage = null;
                arkaplanResimPictureBox.Image = null;
                grid1.BackgroundImage = System.Drawing.Image.FromFile(openFileDialog.FileName);
                arkaplanResimPictureBox.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                grid1.SetCellsTransparent();
                grid1.Refresh();
                kelimelerArkaplanRenk.BackColor = Color.White;
            }
        }

        private void resimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Bulmaca Resim Kayıt";
            sfd.Filter = "Resim Dosyası (*.png;*.bmp;*.jpg) |*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }

                kelimeEkleText.Focus();
                soldanSagaSorular.BorderStyle = BorderStyle.None;
                yukaridanAsagiyaSorular.BorderStyle = BorderStyle.None;

                Bitmap resim = new Bitmap(A4.Width, A4.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                System.Drawing.Rectangle rectBounds1 = new System.Drawing.Rectangle(0, 0, A4.Width, A4.Height);
                A4.DrawToBitmap(resim, rectBounds1);
                
                resim.Save(sfd.FileName, format);
                
                soldanSagaSorular.BorderStyle = BorderStyle.FixedSingle;
                yukaridanAsagiyaSorular.BorderStyle = BorderStyle.FixedSingle;
                
            }
        }

        private void pdfToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Bulmaca Pdf Kayıt";
                sfd.Filter = "Pdf Dosyası (*.pdf) | *.pdf";
                string sfdname = sfd.FileName;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    kelimeEkleText.Focus();
                    soldanSagaSorular.BorderStyle = BorderStyle.None;
                    yukaridanAsagiyaSorular.BorderStyle = BorderStyle.None;

                    var doc = new iTextSharp.text.Document();

                    MemoryStream ms = new MemoryStream();
                    Bitmap img2 = new Bitmap(A4.Width, A4.Height);
                    A4.DrawToBitmap(img2, new System.Drawing.Rectangle(0, 0, A4.Width, A4.Height));

                    iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(img2, System.Drawing.Imaging.ImageFormat.Png);

                    var jpeg = new Jpeg(img);
                    jpeg.ScaleToFit(doc.PageSize.Width - (doc.LeftMargin + doc.RightMargin), doc.PageSize.Height - (doc.BottomMargin + doc.TopMargin));
                    jpeg.SetAbsolutePosition(doc.BottomMargin, doc.TopMargin);

                    doc.Add(jpeg);
                    doc.Close();

                    soldanSagaSorular.BorderStyle = BorderStyle.FixedSingle;
                    yukaridanAsagiyaSorular.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            catch { }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        

        private void grid1_Click(object sender, EventArgs e)
        {
            grid1.CurrentCell.Style.SelectionBackColor = kontrolArkaplanRenk;
            grid1.CurrentCell.Style.SelectionForeColor = hucreForeColor;
        }

        private void grid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = kontrolRenk;
        }

        private void boyutUygula_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(bulmacaBoyutu.Text) != bulmacaBoyutuDegiskeni && Convert.ToInt32(hucreBoyutu.Text) == hucreBoyutuDegiskeni)
            {
                if (Convert.ToInt32(bulmacaBoyutu.Text) >= 5 && Convert.ToInt32(bulmacaBoyutu.Text) <= 15)
                {
                    DialogResult dialogResult = MessageBox.Show(this, "Giriş yapılan kelimeler silinecektir onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Yes)
                    {
                        bulmacaBoyutuDegiskeni = Convert.ToInt32(bulmacaBoyutu.Text);
                        boardGenislikTut = 0;
                        boardYukseklikTut = 0;

                        horizontalWordsListView.Items.Clear();
                        verticalWordsListView.Items.Clear();

                        
                        _words.Clear();
                        kelimeEkleText.Clear();
                        ClearBoard();

                        //------------------------------------------------------------
                        _board = new Crossword.Crossword(bulmacaBoyutuDegiskeni, bulmacaBoyutuDegiskeni);
                        soruCevapGrid.Rows.Clear();
                        soruCevapGrid.Columns.Clear();
                        notUsedListView.Rows.Clear();
                        notUsedListView.Columns.Clear();
                        grid1.Columns.Clear();
                        grid1.Rows.Clear();
                        altSayilarGrid.Rows.Clear();
                        ustSayilarGrid.Rows.Clear();
                        altSayilarGrid.Columns.Clear();
                        ustSayilarGrid.Columns.Clear();
                        sutunOlustur(bulmacaBoyutuDegiskeni);
                        satirOlustur(bulmacaBoyutuDegiskeni);
                        arkaplanRenklendir(kontrolArkaplanRenk);
                        sutunGenislikAyarla(hucreBoyutuDegiskeni);
                        satirYukseklikAyarla(hucreBoyutuDegiskeni);
                        cevaplarSutunOlustur();

                        okunabilirYap();
                        boardBoyutuAyarla();
                        boslukPanelBoyutuAyarla(hucreBoyutuDegiskeni);
                        ustSayilarGridPanelBoyutuAyarla(hucreBoyutuDegiskeni);
                        altSayilarGridPanelBoyutuAyarla(hucreBoyutuDegiskeni);
                        sayilarDoldur();
                        gridPanelBoyutuAyarla(hucreBoyutuDegiskeni);
                        boardCerceveRengiAyarla(cerceveRengiDegiskeni);
                        boardYeriniAyarla();
                        grid1.ClearSelection();

                        baslikTabDoldur();
                        kelimeEkleText.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Bulmaca boyutu min : 5 max : 15 olabilir.", "Uyarı");
                }
            }
            if(Convert.ToInt32(bulmacaBoyutu.Text) == bulmacaBoyutuDegiskeni && Convert.ToInt32(hucreBoyutu.Text) != hucreBoyutuDegiskeni)
            {
                if(Convert.ToInt32(hucreBoyutu.Text) >= 20 && Convert.ToInt32(hucreBoyutu.Text) <= 40)
                {
                    hucreBoyutuDegiskeni = Convert.ToInt32(hucreBoyutu.Text);
                    boardGenislikTut = 0;
                    boardYukseklikTut = 0;
                    sutunGenislikAyarla(hucreBoyutuDegiskeni);
                    satirYukseklikAyarla(hucreBoyutuDegiskeni);
                    boardBoyutuAyarla();
                    boslukPanelBoyutuAyarla(hucreBoyutuDegiskeni);
                    ustSayilarGridPanelBoyutuAyarla(hucreBoyutuDegiskeni);
                    altSayilarGridPanelBoyutuAyarla(hucreBoyutuDegiskeni);
                    gridPanelBoyutuAyarla(hucreBoyutuDegiskeni);
                    boardYeriniAyarla();
                }
                else
                {
                    MessageBox.Show("Hücre boyutu min : 20 max : 40 olabilir.", "Uyarı");
                }
            }
        }
    }
}
