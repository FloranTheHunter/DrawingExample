using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public  class TPanel : Panel
    {
        public TPanel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true); 
        }
    }

    public partial class Form1 : Form
    {
        Graphics g,
            graphics;

        Bitmap surface;
        Color
            back = Color.White,
            brush = Color.Black,
            current;

        Pen p;        

        bool isDown = false;
        int
            x = -1,
            y = -1;

        float size = 5;

        public Form1()
        {
            InitializeComponent();
            SizeSlider.Value = (int)size;

            current = Color.FromArgb(255, Red.Value, Green.Value, Blue.Value);

            //g = panel1.CreateGraphics();            

            p = new Pen(Color.Black, size);
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            panel1.BackColor = back;
            BackBox.BackColor = back;
            BrushBox.BackColor = brush;            
            CurrentBox.BackColor = current;
            //----------
            surface = new Bitmap(panel1.Width, panel1.Height);
            graphics = Graphics.FromImage(surface);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            panel1.BackgroundImage = surface;
            panel1.BackgroundImageLayout = ImageLayout.None;            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            x = -1;
            y = -1;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            Bitmap animage = new Bitmap(panel1.Width, panel1.Height);
            using (Graphics gr = Graphics.FromImage(animage))
            {
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.CompositingQuality = CompositingQuality.HighQuality;
                gr.DrawImage(surface, new Rectangle(0, 0, surface.Width, surface.Height));
            }

            surface = animage;

            graphics = Graphics.FromImage(surface);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            panel1.BackgroundImage = surface;
            panel1.BackgroundImageLayout = ImageLayout.None;
        }

        private void Red_Changed(object sender, EventArgs e)
        {            
            current = Color.FromArgb(Red.Value, Green.Value, Blue.Value);
            CurrentBox.BackColor = current;
        }

        private void Green_Changed(object sender, EventArgs e)
        {
            current = Color.FromArgb(Red.Value, Green.Value, Blue.Value);
            CurrentBox.BackColor = current;
        }

        private void Blue_Changed(object sender, EventArgs e)
        {
            current = Color.FromArgb(Red.Value, Green.Value, Blue.Value);
            CurrentBox.BackColor = current;
        }        

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown && x != -1 && y != -1)
            {
                graphics.DrawLine(p, x, y, e.Location.X, e.Location.Y);                
                //g.DrawEllipse(p, e.Location.X - size / 4, e.Location.Y - size / 4, size / 2, size / 2);
                
                x = e.X;
                y = e.Y;
                panel1.Invalidate();
            }                
        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            p.Width = size;
            p.Color = Color.FromArgb(Red.Value, Green.Value, Blue.Value);
            BrushBox.BackColor = current;
            brush = back;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int width = panel1.Size.Width;
            int height = panel1.Size.Height;

            Bitmap bm = new Bitmap(width, height);
            panel1.DrawToBitmap(bm, new Rectangle(0, 0, width, height));
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            fileDialog.ShowDialog();


            bm.Save(fileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);            

        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            back = Color.FromArgb(Red.Value, Green.Value, Blue.Value);


            SolidBrush brush = new SolidBrush(back);
            graphics.FillRectangle(brush, 0, 0, panel1.Width, panel1.Height);
            panel1.BackColor = back;
            BackBox.BackColor = back;  
        }

        private void SetColor_Click(object sender, EventArgs e)
        {            

            p.Width = size;
            p.Color = Color.FromArgb(Red.Value, Green.Value, Blue.Value);
            BrushBox.BackColor = current;
            brush = current;
        }

        private void SizeChangedE(object sender, EventArgs e)
        {            
            TrackBar s = (TrackBar)sender;
            p.Width = size;
            size = s.Value;
        }
    }
}
