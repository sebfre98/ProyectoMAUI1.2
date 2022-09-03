using SQLiteDemo.ViewModels;

namespace SQLiteDemo.Views;

public partial class AddUpdateSedeDetail : ContentPage
{
    public AddUpdateSedeDetail(AddUpdateSedeDetailViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}