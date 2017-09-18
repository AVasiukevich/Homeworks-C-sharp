using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyLoginer
{
    class MyProgressBar : UserControl
    {
        private ProgressBar progressbar;
        public MyProgressBar() : base()
        {
            progressbar = new ProgressBar();
            progressbar.Style = ProgressBarStyle.Marquee;
            progressbar.MarqueeAnimationSpeed = 50;
        }
        private Bitmap bm;
        public int Value
        {
            get { return progressbar.Value; }
            set
            {
                progressbar.Value = value;
                Refresh();
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            progressbar.Size = Size;
        }
        public void MyPaint()
        {
            bm = new Bitmap(Size.Width, Size.Height);
            Graphics gr = CreateGraphics();
            progressbar.DrawToBitmap(bm, new Rectangle(0, 0, Size.Width, Size.Height));
            gr.DrawImage(bm, 0, 0);
            gr.DrawString("Идет загрузка...", Font, new SolidBrush(ForeColor), new PointF(140, 5));
        }
    }
}
