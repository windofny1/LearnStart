using LS.MAUIClient.ViewModels;

namespace LS.MAUIClient.Pages;

public partial class AddRectanglePage : ContentPage
{
    private readonly AddRectangleViewModel _addRectangleViewModel;
    public AddRectanglePage(AddRectangleViewModel addRectangleViewModel)
	{
		InitializeComponent();
		BindingContext = _addRectangleViewModel = addRectangleViewModel;
	}
}