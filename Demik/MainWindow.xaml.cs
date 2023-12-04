using System;
using System.Windows;

namespace Demik
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Заполнение ComboBox с заказчиками
            cmbCustomers.SelectedIndex = 0; // Выберем первого клиента по умолчанию
            GenerateOrderCode();
        }

        private void GenerateOrderCode()
        {
            // Логика генерации кода заказа
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Логика добавления клиента здесь.", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Логика создания заказа
                double orderCost = CalculateOrderCost();
                txtOrderCost.Text = $"${orderCost}";

                MessageBox.Show("Заказ успешно создан!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании заказа: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private double CalculateOrderCost()
        {
            // Логика расчета стоимости заказа
            return 100.0; // Замените это на вашу реальную логику
        }
    }
}
