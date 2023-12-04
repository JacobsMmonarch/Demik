using System.Windows;
using System.Windows.Controls;

namespace Demik
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Попробуйте преобразовать введенные значения в числа и выполнить сложение
            if (int.TryParse(TextBox1.Text, out int value1) && int.TryParse(TextBox2.Text, out int value2))
            {
                // Сложение
                int result = value1 + value2;

                // Установка результата в третий TextBox
                ResultTextBox.Text = result.ToString();
            }
            else
            {
                // Если введенные значения не являются числами, выведите сообщение об ошибке или предпримите необходимые действия
                ResultTextBox.Text = "Invalid input";
            }
        }

        private void ResultTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
