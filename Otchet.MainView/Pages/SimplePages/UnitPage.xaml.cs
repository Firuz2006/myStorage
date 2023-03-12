using System.Threading.Tasks;
using System.Windows;
using Otchet.Core.Models;
using Otchet.Repository.SimpleEntitiesRepository;

namespace Otchet.MainView.SimplePages;

public partial class UnitPage
{
    private readonly UnitRepository _unit=new();
    
    public UnitPage()
    {
        InitializeComponent();
#pragma warning disable CS4014
        _refresh();
#pragma warning restore CS4014
    }
    
    private void Clear(object? sender=null, RoutedEventArgs? e=null)
    {
        Name.Clear();
    }

    private void Delete(object sender, RoutedEventArgs e)
    {
        if (_id==0)return;
        _unit.Delete(_id);
        Clear();
    }

    private async void Save(object sender, RoutedEventArgs e)
    {
        if (_id==0)
        {
            _unit.Add(new Unit{ Name = Name.Text });
        }
        Clear();
        await _refresh();
    }

    protected sealed override async Task _refresh()
    {
        MainDataGrid.ItemsSource = await _unit.GetUnits();
        TableLoaded();
    }
    
    private void TableLoaded(object sender=null!, RoutedEventArgs e=null!)
    {
        MainDataGrid.Columns[2].Visibility = Visibility.Hidden;
    }
}