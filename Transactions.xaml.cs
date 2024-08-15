using System.Collections.Generic;
using System.Windows.Controls;

namespace NotSoEpicApp
{
    public partial class Transactions : Page
    {
        public Transactions()
        {
            InitializeComponent();
            LoadAndDisplayTransactions();
        }

        private void LoadAndDisplayTransactions()
        {
            List<Transaction> transactions = TransactionManager.LoadTransactionsFromFiles();

            TransactionsListBox.ItemsSource = transactions;
        }

        private void BackToMainButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void TransactionsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Transaction selectedTransaction = (Transaction)TransactionsListBox.SelectedItem;
            if (selectedTransaction != null)
            {
                DescriptionTextBlock.Text = selectedTransaction.Description;
            }
            else
            {
                DescriptionTextBlock.Text = "Select a transaction to see the description.";
            }
        }
    }
}
