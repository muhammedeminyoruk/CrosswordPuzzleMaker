using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kare_bulmaca_winform
{
    public class DataGridViewEx : DataGridView
    {
        private System.Drawing.Image _backgroundPic;

        public override System.Drawing.Image BackgroundImage
        {
            get { return _backgroundPic; }
            set { _backgroundPic = value; }
        }

        protected override void PaintBackground(System.Drawing.Graphics graphics,
            System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle gridBounds)
        {
            base.PaintBackground(graphics, clipBounds, gridBounds);

            if (((this.BackgroundImage != null)))
            {
                graphics.FillRectangle(Brushes.Black, gridBounds);
                graphics.DrawImage(this.BackgroundImage, gridBounds);
            }
        }
        public void SetCellsNormal()
        {

        }
        public void SetCellsTransparent()
        {
            for (var i = 0; i < this.Columns.Count; i++)
            {
                for (var j = 0; j < this.Rows.Count; j++)
                {
                    DataGridViewCell c = this[i, j];
                    if (!string.IsNullOrEmpty(c.Value as string))
                    {
                        c.Style.BackColor = Color.Transparent;
                    }
                }
            }
            /*
            foreach (DataGridViewColumn col in this.Columns)
            {
                col.DefaultCellStyle.BackColor = Color.Transparent;
            }
            */
        }
    }
}
