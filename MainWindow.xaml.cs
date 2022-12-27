using System.Windows;
using Пример_таблицы_WPF;

namespace practWorkNumber14
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCrtTable_Click(object sender, RoutedEventArgs e)
        {
            DataValidationWindow dataValidationWindow = new();

            dataValidationWindow.ShowDialog();

            if (dataValidationWindow.kostiil)
                dataGrid.ItemsSource = VisualArray.ToDataTable(dataValidationWindow.data).DefaultView;
        }
    }
}