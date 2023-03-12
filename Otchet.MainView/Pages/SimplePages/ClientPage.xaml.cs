using System.Threading.Tasks;
using System.Windows;
using Otchet.Core.Models;
using Otchet.Repository.SimpleEntitiesRepository;

namespace Otchet.MainView.SimplePages;

public partial class ClientPage
{
    private readonly ClientRepository _client=new();
    
    public ClientPage()
    {
        InitializeComponent();
        _refresh();
    }
    
    private void Clear(object? sender=null, RoutedEventArgs? e=null)
    {
        Name.Clear();
        Phone.Clear();
    }

    private void Delete(object sender, RoutedEventArgs e)
    {
        if (_id==0)return;
        _client.Delete(_id);
        Clear();
        _refresh();
    }

    private void Save(object sender, RoutedEventArgs e)
    {
        if (_id==0)
        {
            _client.Add(new Client{ Name = Name.Text ,Phone = Phone.Text});
        }
        Clear();
        _refresh();
    }

    protected override async Task _refresh()
    {
        MainDataGrid.ItemsSource = await _client.GetClients();
        TableLoaded();
    }

    private void TableLoaded(object sender=null, RoutedEventArgs e=null)
    {
        MainDataGrid.Columns[3].Visibility = Visibility.Hidden;
    }
}