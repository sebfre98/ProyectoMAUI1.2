using SQLiteDemo.ViewModels;

namespace SQLiteDemo.Views;

public partial class SedeListPage : ContentPage
{
    private SedeListPageViewModel _viewMode;
    public SedeListPage(SedeListPageViewModel viewModel)
	{
		InitializeComponent();
        _viewMode = viewModel;
        this.BindingContext = viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewMode.GetSedeListCommand.Execute(null);
    }
}