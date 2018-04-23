using System.Windows;

namespace Apply_Data_Annotations {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.DataSource = ProductList.GetData();
        }
    }
}
