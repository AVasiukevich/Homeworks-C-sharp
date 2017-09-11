using Mosaic.MyForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Mosaic
{
    public partial class MainForm : Form
    {
        #region FIELD
        bool check; // Флаг чтоб при перемешивании не проверялось на победу
        List<PictureBox> listImage;
        List<Image> listRecovery;
        Bitmap bmp;
        private int row;
        FormSettingMosaic formSetting;
        FormHelp formHelp;
        #endregion
        public string MainImage
        {
            get { return pcb_main.ImageLocation; }
        }
        #region METHODS
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {           
            row = 3;
            listImage = new List<PictureBox>();
            listRecovery = new List<Image>();
        }
        private void MainMenu_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF";
            if (open.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(Image.FromFile(open.FileName), pcb_main.Width, pcb_main.Height);
                pcb_main.ImageLocation = open.FileName;
            }
        }
        private void MainMenu_Setting_Click(object sender, EventArgs e)
        {
            if (formSetting != null) formSetting.Close();
            formSetting = new FormSettingMosaic();
            if(formSetting.ShowDialog() == DialogResult.OK)
            {
                row = (int)Math.Sqrt(formSetting.CountRectangle);
            }
        }
        private void MainMenu_Help_Click(object sender, EventArgs e)
        {
            if (formHelp != null) formHelp.Close();
            formHelp = new FormHelp();
            formHelp.Show(this);
        }
        private void MainMenu_Mix_Click(object sender, EventArgs e)
        {
            if (pcb_main.Image == null)
                return;
            listRecovery.Clear();
            check = false;
            pcb_main.Visible = false;
            int size = (int)(pcb_main.Width / row);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Bitmap newPicPart = (Bitmap)bmp.Clone(new Rectangle(size * j, size * i, size, size), PixelFormat.DontCare);
                    newPicPart.Tag = i * row + j;
                    PictureBox newPicBox = new PictureBox();
                    newPicBox.Location = new Point(size * j, size * i + MainMenu.Height);
                    newPicBox.Image = (i == row - 1 && j == row - 1) ? null : newPicPart;
                    newPicBox.Size = new Size(size, size);
                    newPicBox.BorderStyle = BorderStyle.FixedSingle;
                    newPicBox.Tag = newPicPart.Tag;
                    this.Controls.Add(newPicBox);
                    newPicBox.Click += NewPicBox_Click;
                    listImage.Add(newPicBox);
                }
            }
            for (int i = 0; i < 400 * row; i++)
            {
                NewPicBox_Click(listImage[Randomer.Next(0, listImage.Count - 1)], EventArgs.Empty);
            }
            for (int i = 0; i < listImage.Count; i++)
            {
                listRecovery.Add(listImage[i].Image);
            }
            MainMenu_Image.Enabled = false;
            MainMenu_Setting.Enabled = false;
            check = true;
        }
        private void NewPicBox_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic != null)
            {
                int index = listImage.IndexOf(pic);
                if (index - row >= 0 && listImage[index - row].Image == null)
                    Swap(pic, listImage[index - row]);
                else if (index - 1 >= 0 && listImage[index - 1].Image == null && index % row != 0)
                    Swap(pic, listImage[index - 1]);
                else if (index + 1 <= listImage.Count - 1 && listImage[index + 1].Image == null && index % row != row - 1)
                    Swap(pic, listImage[index + 1]);
                else if (index + row <= listImage.Count - 1 && listImage[index + row].Image == null)
                    Swap(pic, listImage[index + row]);
            }
            if(check == true)
                Check();
        }
        /// <summary>
        /// Метод для замены картинок в прямоугольниках
        /// </summary>
        /// <param name="first">Первый прямоугольник</param>
        /// <param name="second">Второй прямоугольник, пустой</param>
        private void Swap(PictureBox first, PictureBox second)
        {
            Image temp = second.Image;
            second.Image = first.Image;
            first.Image = temp;
        }
        /// <summary>
        /// Метод проверки на победу
        /// </summary>
        private void Check()
        {
            for (int i = 0; i < listImage.Count - 1; i++)
            {
                if (listImage[i].Image == null || listImage[i].Tag != listImage[i].Image.Tag)
                    return;
            }
            pcb_main.Visible = true;
            MessageBox.Show("Вы выиграли! Поздравляем!", "Победа!");
        }
        private void MainMenu_Return_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listImage.Count; i++)
            {
                listImage[i].Image = listRecovery[i];
            }
        }
        #endregion
    }
}
