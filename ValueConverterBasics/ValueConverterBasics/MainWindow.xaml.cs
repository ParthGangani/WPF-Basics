using System.Windows;

namespace ValueConverterBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool LicenseExpired { get; set; } = false;

        public bool HasThickBorder { get; set; } = true;

        public bool BoolProperty { get; set; }

        public int Grade { get; set; } = 50;

        public bool ShowAds { get; set; } = true;

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }
    }
}
