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

namespace WPFUserControl
{
    /// <summary>
    /// Логика взаимодействия для RhombusControl.xaml
    /// </summary>
    public partial class RhombusControl : UserControl
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public ImageSource coloredSource { get; set; }
        public ImageSource BlackWhiteSource =>
            (coloredSource == null) ? null : new FormatConvertedBitmap((BitmapSource)coloredSource, PixelFormats.Gray8, null, 1);

        public RhombusControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Btn_Action_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Description, Header, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
