using System.Threading.Tasks;
using System.Windows;
using Otchet.Core.Models;
using Otchet.Repository.SimpleEntitiesRepository;

namespace Otchet.MainView.SimplePages;

public partial class CategoryPage
{
    private readonly CategoryRepository _category=new();
    
    public CategoryPage()
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
        _category.Delete(_id);
        Clear();
    }

    private void Save(object sender, RoutedEventArgs e)
    {
        if (_id==0)
        {
            _category.Add(new Category{ Name = Name.Text });
        }
        Clear();
    }

    protected override async Task _refresh()
    {
        MainDataGrid.ItemsSource = await _category.GetCategory();
    }
}