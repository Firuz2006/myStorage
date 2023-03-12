using System.Threading.Tasks;
using System.Windows;
using Otchet.Core.Models;
using Otchet.Repository.SimpleEntitiesRepository;

namespace Otchet.MainView.SimplePages;

public partial class StoragePage
{
    private readonly StorageRepository _storage=new();
    
    public StoragePage()
    {
        InitializeComponent();
        _refresh();
    }
    
    private void Clear(object? sender=null, RoutedEventArgs? e=null)
    {
        Name.Clear();
        Address.Clear();
    }

    private void Delete(object sender, RoutedEventArgs e)
    {
        if (_id==0)return;
        _storage.Delete(_id);
        Clear();
        _refresh();
    }

    private void Save(object sender, RoutedEventArgs e)
    {
        if (_id==0)
        {
            _storage.Add(new Storage{ Name = Name.Text , Address = Address.Text});
        }
        Clear();
        _refresh();
    }

    protected override async Task _refresh()
    {
        MainDataGrid.ItemsSource = await _storage.GetStorage();
        TableLoaded(null!,null!);
    }

    private void TableLoaded(object sender, RoutedEventArgs e)
    {
        MainDataGrid.Columns[3].Visibility = Visibility.Hidden;
        MainDataGrid.Columns[4].Visibility = Visibility.Hidden;
    }
}