using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace PlicCompanion
{
    /// <summary>
    /// Interaction logic for Analysis.xaml
    /// </summary>
    public partial class Analysis : Window
    {
        public Analysis()
        {
            InitializeComponent();



        }

        private void print_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            FlowDocument doc = new FlowDocument(new Paragraph(new Run("Your analysis")));
            doc.Name = "FlowDoc";
            IDocumentPaginatorSource idpSource = doc;
            printDlg.PrintDocument(idpSource.DocumentPaginator, "Printing Analysis");

        }

        private FlowDocument CreateFlowDocument()
        {
            // Create a FlowDocument  
            FlowDocument doc = new FlowDocument();
            // Create a Section  
            Section sec = new Section();
            // Create first Paragraph  
            Paragraph p1 = new Paragraph();
            // Create and add a new Bold, Italic and Underline  
            Bold bld = new Bold();
            bld.Inlines.Add(new Run("First Paragraph"));
            Italic italicBld = new Italic();
            italicBld.Inlines.Add(bld);
            Underline underlineItalicBld = new Underline();
            underlineItalicBld.Inlines.Add(italicBld);
            // Add Bold, Italic, Underline to Paragraph  
            p1.Inlines.Add(underlineItalicBld);
            // Add Paragraph to Section  
            sec.Blocks.Add(p1);
            // Add Section to FlowDocument  
            doc.Blocks.Add(sec);
            return doc;
        }
    }
}
