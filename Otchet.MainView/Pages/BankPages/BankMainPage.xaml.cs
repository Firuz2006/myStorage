using System.Windows;
using Otchet.MainView.SimplePages;
using Page = System.Windows.Controls.Page;

namespace Otchet.MainView.Pages.BankPages;

public partial class BankMainPage : Page
{
    public BankMainPage()
    {
        InitializeComponent();
    }

    private void CashIn(object sender, RoutedEventArgs e)
    {
        BankMainFrame.Content = new CashInPage();
    }

    private void CashOut(object sender, RoutedEventArgs e)
    {
        BankMainFrame.Content = new CashOutPage();
    }

    private void BankMain(object sender, RoutedEventArgs e)
    {
        BankMainFrame.Content = new BankSecondPage();
    }
}