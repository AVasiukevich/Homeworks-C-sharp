using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MyMediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double position; //Для ToolTip
        DispatcherTimer dispatcherTimer;
        ObservableCollection<ListVideo> listVideo;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listVideo = new ObservableCollection<ListVideo> ();
            lsb_exp.ItemsSource = listVideo;
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
        }
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            lb_time_end.Content = String.Format("{0:00}:{1:00}:{2:00}", media_main.Position.Hours,
                media_main.Position.Minutes, media_main.Position.Seconds);
            slr_video.Value = media_main.Position.TotalSeconds;
        }
        private void exp_main_Collapsed(object sender, RoutedEventArgs e)
        {
            exp_main.Background = null;

        }
        private void exp_main_Expanded(object sender, RoutedEventArgs e)
        {
            exp_main.Background = Brushes.Gray;
        }
        private void btn_Start_Click(object sender, RoutedEventArgs e)
        {
            media_main.Play();
            media_main.Volume = (double)slr_sound.Value;
        }
        private void btn_Stop_Click(object sender, RoutedEventArgs e)
        {
            media_main.Stop();
        }
        private void btn_Pause_Click(object sender, RoutedEventArgs e)
        {
            media_main.Pause();
        }
        private void media_main_MediaOpened(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Start();
            slr_video.Maximum = media_main.NaturalDuration.TimeSpan.TotalSeconds;
            lb_time_all.Content = String.Format("{0:00}:{1:00}:{2:00}", media_main.NaturalDuration.TimeSpan.Hours,
                media_main.NaturalDuration.TimeSpan.Minutes, media_main.NaturalDuration.TimeSpan.Seconds);
        }
        private void slr_sound_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(media_main != null)
                media_main.Volume = (double)slr_sound.Value;
        }
        private void slr_video_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //if (dispatcherTimer.IsEnabled)
            //{
                media_main.Position = new TimeSpan(0, 0, 0, (int)slr_video.Value);
                dispatcherTimer.Start();
            //}
        }
        private void slr_video_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            dispatcherTimer.Stop();
        }
        private void menu_open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Videos Files |*.wmv;*.amv; *.asf; *.avi; *.cue; *.divx; *.dv; *.flv; *.gxf; *.m4v; " +
                  " *.mkv; *.mov; *.mp2; *.mp2v; *.mp4; *.mp4v; *.mpa; *.mpe; *.mpeg; *.mpeg1; *.mpeg2; *.mpeg4; *.mpg; *.mpv2";
            if (dialog.ShowDialog() == true)
            {
                media_main.Source = new Uri(dialog.FileName);
                this.Title = dialog.SafeFileName;
                media_main.Play();
                listVideo.Clear();
                listVideo.Add(new ListVideo() { Name = dialog.SafeFileName, Path = dialog.FileName });
                lsb_exp.SelectedIndex = 0;
            }
        }
        private void menu_add_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Videos Files |*.wmv;*.amv; *.asf; *.avi; *.cue; *.divx; *.dv; *.flv; *.gxf; *.m4v; " +
                  " *.mkv; *.mov; *.mp2; *.mp2v; *.mp4; *.mp4v; *.mpa; *.mpe; *.mpeg; *.mpeg1; *.mpeg2; *.mpeg4; *.mpg; *.mpv2";
            if (dialog.ShowDialog() == true)
            {
                listVideo.Add(new ListVideo() { Name = dialog.SafeFileName, Path = dialog.FileName });
            }
        }
        private void media_main_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (lsb_exp.Items.Count > 1 && lsb_exp.SelectedIndex < lsb_exp.Items.Count - 1)
            {
                media_main.Source = new Uri(listVideo[lsb_exp.SelectedIndex + 1].Path);
                this.Title = listVideo[lsb_exp.SelectedIndex + 1].Name;
                media_main.Play();
            }
            else if (lsb_exp.Items.Count > 1 && lsb_exp.SelectedIndex == lsb_exp.Items.Count - 1)
            {
                media_main.Source = new Uri(listVideo[0].Path);
                this.Title = listVideo[0].Name;
                media_main.Play();
            }
            else
                media_main.Stop();
        }
        private void btn_Sound_Click(object sender, RoutedEventArgs e)
        {
            if (media_main.IsMuted)
            {
                sound_path.Data = (Geometry)Application.Current.Resources["sound_3Style0"];
                media_main.IsMuted = false;
            }
            else
            {
                sound_path.Data = (Geometry)Application.Current.Resources["sound_0Style0"];
                media_main.IsMuted = true;
            }
        }
        private void lsb_exp_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(lsb_exp.SelectedItem != null)
            {
                media_main.Source = new Uri(listVideo[lsb_exp.SelectedIndex].Path);
                this.Title = listVideo[lsb_exp.SelectedIndex].Name;
                media_main.Play();
            }
        }
        private void menu_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void slr_video_MouseMove(object sender, MouseEventArgs e)
        {
            if (position == 0)
                position = e.GetPosition(slr_video).X;

            double x = slr_video.Maximum * e.GetPosition(slr_video).X / slr_video.ActualWidth;
            TimeSpan y = TimeSpan.FromSeconds(x);
            slr_video_tool.HorizontalOffset = e.GetPosition(slr_video).X - position;
            slr_video_tool.Content = String.Format("{0:00}:{1:00}:{2:00}", y.Hours,
               y.Minutes, y.Seconds);
        }
        private void slr_video_tool_Loaded(object sender, RoutedEventArgs e)
        {
            position = 0;
        }
        private void btn_Stop_MouseMove(object sender, MouseEventArgs e)
        {
            Button select = sender as Button;
            if(select != null)
            {
                select.Effect = null;
                select.Effect = (Effect)Application.Current.Resources["LightControlShadowEffectMove"];
            }
        }

        private void btn_Stop_MouseLeave(object sender, MouseEventArgs e)
        {
            Button select = sender as Button;
            if (select != null)
            {
                select.Effect = (Effect)Application.Current.Resources["LightControlShadowEffect"];
            }
        }
    }
}
