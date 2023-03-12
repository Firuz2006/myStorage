using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Otchet.Core.Models;
using Otchet.Repository.BusinessProcessRepository;
using Otchet.Repository.SimpleEntitiesRepository;

namespace Otchet.MainView.BusinessPages;

public partial class ProductPage
{
    private readonly UnitRepository _unit=new();
    private readonly CategoryRepository _category = new();
    private readonly ProductRepository _product = new();
    private Product? _selectedProduct;
    public ProductPage()
    {
        InitializeComponent();
        _refresh();
        
    }
    
    private void Clear(object? sender=null, RoutedEventArgs? e=null)
    {
        Name.Clear();
        _selectedProduct = null;
    }

    private void Delete(object sender, RoutedEventArgs e)
    {
        if (_id==0)return;
        _product.Delete(_id);
        Clear();
    }

    private async void Save(object sender, RoutedEventArgs e)
    {
        var category = (Category)_cbCategory.SelectedItem;
        var unit = (Unit)_cbUnit.SelectedItem;
        if (_id==0)
        {
            _product.Add(new Product{ Name = Name.Text,CategoryId = category.Id,UnitId = unit.Id,Unit = null,Category = null});
        }
        else
        {
            await _product.Update(_selectedProduct!);
        }
        Clear();
        _refresh();
    }

    protected override async Task _refresh()
    {
            MainDataGrid.ItemsSource = await _product.GetProducts();
            _cbCategory.ItemsSource = await _category.GetCategory();
            _cbUnit.ItemsSource = await _unit.GetUnits();
            TableLoaded();
    }

    private void DataGridCellClick(object sender, MouseButtonEventArgs e)
    {
        _selectedProduct = (Product)MainDataGrid.Items.CurrentItem;
        _cbCategory.SelectedItem = _cbCategory.Items.Cast<Category>().Single(c => c.Id == _selectedProduct.CategoryId);
        _cbUnit.SelectedItem = _cbUnit.Items.Cast<Unit>().Single(c => c.Id == _selectedProduct.UnitId);
        Name.Text = _selectedProduct.Name;
        _id = _selectedProduct.Id;
    }

    private void TableLoaded(object sender=null, RoutedEventArgs e=null)
    {
        MainDataGrid.Columns[2].Visibility=Visibility.Hidden;
        MainDataGrid.Columns[4].Visibility=Visibility.Hidden;
        MainDataGrid.Columns[6].Visibility=Visibility.Hidden;
        MainDataGrid.Columns[7].Visibility=Visibility.Hidden;
    }
}