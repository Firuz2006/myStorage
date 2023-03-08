using System;
using System.Linq;
using System.Threading;
using System.Windows;
using Otchet.DataBase.Contexts;
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
            
    }

    private void FirmClick(object sender, RoutedEventArgs e)
    {
            
    }

    private void UnitClick(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = new UnitPage();
    }
}