using SudokuApp.Controls;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SudokuApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // For debug, beginning
        CeilControl? ceilControl;
        BlockControl? blockControl;

        // For debug, end

        public MainWindow()
        {
            InitializeComponent();

            //Content = new SmallBlockControl();

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            if (fvi != null && fvi.FileVersion != null)
            {
                string version = fvi.FileVersion;
                Title = $"{Title} {version}";
            }
        }

        private void CreateOneCeil_Click(object sender, RoutedEventArgs e)
        {
            ceilControl = new CeilControl();
            CC.Content = ceilControl;
        }

        private void SetFocus_Click(object sender, RoutedEventArgs e)
        {
            ceilControl?.Focus();
            ceilControl?.SetActive(true);
        }

        private void CreateOneBlock_Click(object sender, RoutedEventArgs e)
        {
            blockControl=new BlockControl();
            CC.Content = blockControl;
        }
    }
}