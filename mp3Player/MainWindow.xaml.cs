using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mp3Player
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TagLib.File currentFile;
        private MediaPlayer mediaPlayer = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();
            UserControl1.playSongEvent += UserControl1_playSongEvent;
            UserControl1.pauseSongEvent += UserControl1_pauseSongEvent;
        }

        private void UserControl1_pauseSongEvent(object? sender, EventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void UserControl1_playSongEvent(object? sender, EventArgs e)
        {

            mediaPlayer.Play();
        }

       

        private void Button_File_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (fileDlg.ShowDialog() == true)
            {
                mediaPlayer.Open(new Uri(fileDlg.FileName));
                                
                currentFile = TagLib.File.Create(fileDlg.FileName);

                nowPlaying.Text = currentFile.Tag.Title;
                FileNameTextBox.Text = currentFile.Tag.Title;
                AlbumTextBox.Text = currentFile.Tag.Album;
                ArtistTextBox.Text = currentFile.Tag.FirstAlbumArtist;
//                YearTextBox.Text = (currentFile.Tag.Year).ToString;
//                imageBox = currentFile.Tag.

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
 //           currentFile.Tag.Title = FileNameTextBox.Text;
        }
    }
}

