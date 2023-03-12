using System.Threading.Tasks;
using System.Windows;
using Otchet.Core.Models;
using Otchet.Repository.CashRepository;
using Otchet.Repository.SimpleEntitiesRepository;

namespace Otchet.MainView.Pages.BankPages;

public partial class CashInPage
{
    private readonly BankRepository _bankRepository = new();
    private readonly ClientRepository _clientRepository = new();
    public CashInPage()
    {
        InitializeComponent();
        _refresh();
    }

    protected override async Task _refresh()
    {
        Clients.ItemsSource = await _clientRepository.GetClients();
        CbBank.ItemsSource = await _bankRepository.GetBanks();
    }

    private void Submit(object sender, RoutedEventArgs e)
    {
        _bankRepository.Pay(((Bank)CbBank.SelectedItem).Id, decimal.Parse(OneDollarIs.Text),
            (UsdRb.IsChecked == true || TjsRb.IsChecked == false), decimal.Parse(Money.Text));
    }

    private void IncomeClick(object sender, RoutedEventArgs e)
    {
        TypeLabel.Content = "Дополнительный доход";
        Notes.Visibility = Visibility.Visible;
        Clients.Visibility = Visibility.Hidden;
    }
    private void ClientClick(object sender, RoutedEventArgs e)
    {
        TypeLabel.Content = "Оплата от клиента";
        Notes.Visibility = Visibility.Hidden;
        Clients.Visibility = Visibility.Visible;
    }
}