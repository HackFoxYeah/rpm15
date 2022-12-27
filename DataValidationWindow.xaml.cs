using SupSpace;
using System;
using System.Windows;

namespace practWorkNumber14
{    
    public partial class DataValidationWindow : Window
    {
        public DataValidationWindow()
        {
            InitializeComponent();
        }

        public bool kostiil;

        public float[,] data;       

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                uint columns = uint.Parse(tbCA.Text),
                        rows = uint.Parse(tbSA.Text);
                int max = int.Parse(tbMaxValue.Text),
                    min = int.Parse(tbMinValue.Text);

                Random rnd = new();

                data = new float[rows, columns];

                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        data[i, j] = rnd.Next(min, max + 1);
                    }
                }

                kostiil = true;
                Close();
            }
            catch (Exception expression)
            {
                MessageBoxResult error = MessageBox.Show("Упс, вы ввели чот не то\n" + expression.Message, "Ошибочка возникла!", MessageBoxButton.OKCancel);

                if (error == MessageBoxResult.OK)
                {
                    return;
                }
                else if (error == MessageBoxResult.Cancel)
                {
                    MessageBox.Show("Закрытие программы...", "Закрываю типо");
                    Close();
                }
            }
        }
    }
}
