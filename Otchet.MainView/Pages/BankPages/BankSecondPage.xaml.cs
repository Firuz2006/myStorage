using System.Threading.Tasks;
using System.Windows;
using Otchet.Core.Models;
using Otchet.Repository.CashRepository;
using Otchet.Repository.SimpleEntitiesRepository;

namespace Otchet.MainView.SimplePages;

public partial class BankSecondPage
{
    private readonly BankRepository _bank=new();
    
    public BankSecondPage()
    {
        InitializeComponent();
        _refresh();
    }
    
    private void Clear(object? sender=null, RoutedEventArgs? e=null)
    {
        Name.Clear();
    }

    private void Delete(object sender, RoutedEventArgs e)
    {
        if (_id==0)return;
        _bank.Remove(_id);
        Clear();
        _refresh();
    }

    private async void Save(object sender, RoutedEventArgs e)
    {
        if (_id==0)
        {
            _bank.CreateBank(Name.Text);
        }
        Clear();
        await _refresh();
    }

    protected override async Task _refresh()
    {
        MainDataGrid.ItemsSource = _bank.GetBanks();
        TableLoaded(null!,null!);
    }

    private void TableLoaded(object sender, RoutedEventArgs e)
    {
    }
}