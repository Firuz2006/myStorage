using System;
using System.Linq;
using System.Threading;
using System.Windows;
using Otchet.DataBase.Contexts;
using Otchet.MainView.BusinessPages;
using Otchet.MainView.Pages.BankPages;
using Otchet.MainView.SimplePages;

namespace Otchet.MainView;

public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
        new Thread(() => Console.WriteLine(new MainDbContext().Categories.Count()))
            .Start(); // это потому что первый запрост фреймворка энтити медленный;
    }

    private void CategoryClick(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = new CategoryPage();
    }

    private void ProductClick(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = new ProductPage();
    }

    private void StorageClick(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = new StoragePage();
    }

    private void FirmClick(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = new FirmPage();
    }

    private void UnitClick(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = new UnitPage();
    }

    private void ClientClick(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = new ClientPage();
    }

    private void BankClick(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = new BankMainPage();
    }

    private void InvoiceClick(object sender, RoutedEventArgs e)
    {
        
    }

    private void SaleClick(object sender, RoutedEventArgs e)
    {
        
    }

    private void ReportClick(object sender, RoutedEventArgs e)
    {
        
    }

    private void DataBaseClick(object sender, RoutedEventArgs e)
    {
        
    }
}