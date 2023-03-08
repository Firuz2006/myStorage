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
        _refresh();
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

    private void Save(object sender, RoutedEventArgs e)
    {
        if (_id==0)
        {
            _unit.Add(new Unit{ Name = Name.Text });
        }
        Clear();
        _refresh();
    }

    protected override async Task _refresh()
    {
        MainDataGrid.ItemsSource = await _unit.GetUnits();
    }
}