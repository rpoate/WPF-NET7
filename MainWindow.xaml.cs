using Microsoft.VisualBasic;
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

            ToolStripButton SaveButton = new ToolStripButton
            {
                Text = "Save HTML",
                Padding = new Padding(3)
            };
            SaveButton.Click += SaveButton_Click;

            ToolStripComboBox TemplateCombo = new ToolStripComboBox
            {
                Padding = new Padding(3),
            };

            TemplateCombo.Items.AddRange(new object[] { "Template 1", "Template 2", "Template 3" });
            TemplateCombo.SelectedIndexChanged += TemplateCombo_SelectedIndexChanged;

            htmlEditor.ToolStripItems.AddRange(new ToolStripItem[] { SaveButton, TemplateCombo });

            htmlEditor.BackColor = System.Drawing.Color.LightGray;
            htmlEditor.CSSText = "BODY {font-family: Tahoma; background-color: #d3d3d3; border-top: 1px solid #000; padding-top: .3em;}" +
                "TABLE, TD {border-color: #FCFCFC !important}";
        }

        private void TemplateCombo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (htmlEditor.IsDirty && 
                System.Windows.MessageBox.Show("Save contents before updating template?", "Save?", MessageBoxButton.YesNo ) == MessageBoxResult.Yes)
            {
                // do save stuff
            }
            htmlEditor.DocumentHTML = (string)((ToolStripComboBox)sender).SelectedItem;
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            System.Windows.MessageBox.Show("Code to save HTML here \r\n\r\n" + htmlEditor.DocumentHTML);
        }

        private void HtmlEditor_DocumentLoadComplete(object sender, EventArgs e)
        {

        }
    }
}