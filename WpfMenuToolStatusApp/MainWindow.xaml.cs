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

namespace WpfMenuToolStatusApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MenuItem itemEdit = new();
            itemEdit.Header = "Edit";
            menuMain.Items.Add(itemEdit);

            MenuItem itemCopy = new();
            itemCopy.Header = "Copy";
            itemEdit.Items.Add(itemCopy);

            ContextMenu contextMenu = new();
            MenuItem item1 = new();
            item1.Header = "Item1";
            contextMenu.Items.Add(item1);

            //txtBox.ContextMenu = contextMenu;
        }
    }
}
