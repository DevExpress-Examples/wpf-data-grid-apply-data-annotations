using System.Windows;

namespace Apply_Data_Annotations {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = Products.GetProducts();
        }
    }
}
