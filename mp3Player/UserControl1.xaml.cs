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
    /// Interação lógica para UserControl1.xam
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public  event EventHandler playSongEvent;
        public event EventHandler pauseSongEvent;
        public UserControl1()
        {
            InitializeComponent();
        }


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (playSongEvent != null)
            {
                this.playSongEvent(this, e);
            }
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            if (pauseSongEvent != null)
            {
                this.pauseSongEvent(this, e);
            }
        }
    }
}
