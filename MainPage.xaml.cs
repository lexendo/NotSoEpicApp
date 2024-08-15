using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace NotSoEpicApp
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Submit_Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleTextBox.Text))
            {
                MessageBox.Show("Please enter a valid title.");
                return;
            }

            if (!decimal.TryParse(AmountTextBox.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            if (!DatePicker.SelectedDate.HasValue)
            {
                MessageBox.Show("Please select a valid date.");
                return;
            }

            bool isIncome = amount >= 0;

            Transaction transaction = new Transaction
            {
                Title = TitleTextBox.Text,
                Description = DescriptionTextBox.Text,
                Amount = amount,
                Date = DatePicker.SelectedDate.Value,
                IsIncome = isIncome
            };

            SaveTransactionToFile(transaction);

            TitleTextBox.Clear();
            AmountTextBox.Clear();
            DescriptionTextBox.Clear();
            DatePicker.SelectedDate = DateTime.Now;

            MessageBox.Show("Transaction saved successfully!");
        }

        private void SaveTransactionToFile(Transaction transaction)
        {
            string directoryPath = Path.Combine(Environment.CurrentDirectory, "Transactions");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string fileName = $"{transaction.Title}.txt";
            string filePath = Path.Combine(directoryPath, fileName);

            int fileNumber = 1;
            while (File.Exists(filePath))
            {
                fileName = $"{transaction.Title}_{fileNumber}.txt";
                filePath = Path.Combine(directoryPath, fileName);
                fileNumber++;
            }

            string[] lines = {
        $"Title: {transaction.Title}",
        $"Amount: {transaction.Amount}",
        $"IsIncome: {transaction.IsIncome}",
        $"Description: {transaction.Description}",
        $"Date: {transaction.Date.ToShortDateString()}"
    };

            File.WriteAllLines(filePath, lines);
        }

        private void TransactionsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Transactions());
        }

        private void ChartsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Charts());
        }
    }
}
