using System.Threading.Tasks;
using System.Windows;
using Otchet.Core.Models;
using Otchet.Repository.SimpleEntitiesRepository;

namespace Otchet.MainView.SimplePages;

public partial class FirmPage
{
    private readonly FirmRepository _firm=new();
    
    public FirmPage()
    {
        InitializeComponent();
        _refresh();
    }
    
    private void Clear(object? sender=null, RoutedEventArgs? e=null)
    {
        Name.Clear();
        Address.Clear();
        Phone.Clear();
    }

    private void Delete(object sender, RoutedEventArgs e)
    {
        if (_id==0)return;
        _firm.Delete(_id);
        Clear();
        _refresh();
    }

    private void Save(object sender, RoutedEventArgs e)
    {
        if (_id==0)
        {
            _firm.Add(new Firm{ Name = Name.Text , Address = Address.Text,Phone = Phone.Text});
        }
        Clear();
        _refresh();
    }

    protected override async Task _refresh()
    {
        MainDataGrid.ItemsSource = await _firm.GetFirm();
        TableLoaded(null!,null!);
    }

    private void TableLoaded(object sender, RoutedEventArgs e)
    {
        MainDataGrid.Columns[4].Visibility = Visibility.Hidden;
    }
}