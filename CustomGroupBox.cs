using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace FinalSonHali
{
    public partial class CustomGroupBox : ContainerControl
    {
        /// <summary>
        /// Min ve varsayilan genisligin verildigi yer
        /// </summary>
        public CustomGroupBox()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            //varsaylan genislik
            this.Size = new Size(212, 104);
            //min genislik
            this.MinimumSize = new Size(136, 50);
            // ic bosluklar
            this.Padding = new Padding(5, 28, 5, 5);
        }
        /// <summary>
        /// GroupBox olusturucu metot
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            // Cizme olayini olusturuyorum
            base.OnPaint(e);
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            // groupbox'in basligini olusturuyorum
            Rectangle TitleBox = new Rectangle(3, 0, (int)System.Math.Floor(Width*0.5), 18);
            // groupbox'i olusturuyorum
            Rectangle box = new Rectangle(0, 10, Width - 1, Height - 20);
            G.Clear(Color.Transparent);
            G.SmoothingMode = SmoothingMode.HighQuality;
            //Groupboxu ciziyorum
            G.DrawRectangle(new Pen(Color.FromArgb(182, 180, 186)), box);
            //Groupboxun icini transparent yapiyorum
            G.FillRectangle(Brushes.Transparent, box);
            //Groupboxun basligini ciziyorum
            G.FillRectangle(new SolidBrush(BackColor), TitleBox);
            //Groupboxun basligini boyuyuorum
            G.DrawRectangle(new Pen(Color.Transparent), TitleBox);
            // Group Basligini yazdiriyorum
            G.DrawString(Text, new Font("Calibri", 9, FontStyle.Regular), new SolidBrush(Color.FromArgb(53, 53, 53)), TitleBox, new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            });
            e.Graphics.DrawImage((Image)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }
    }
}
