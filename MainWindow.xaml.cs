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

namespace WPF_NET7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            htmlEditor.DocumentLoadComplete += HtmlEditor_DocumentLoadComplete;

            htmlEditor.CSSText = "body {font-family: arial}";
            htmlEditor.FontSizesList = "10pt;12pt;14pt;18pt;22pt";
        }

        private void HtmlEditor_DocumentLoadComplete(object sender, EventArgs e)
        {
            
        }
    }
}