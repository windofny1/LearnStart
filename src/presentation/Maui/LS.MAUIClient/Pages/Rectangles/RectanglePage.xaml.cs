using LS.MAUIClient.ViewModels.Rectangles;

namespace LS.MAUIClient.Pages.Rectangles;

public partial class RectanglePage : ContentPage
{
    private readonly RectanglePageViewModel _rectanglePageViewModel;
    public RectanglePage(RectanglePageViewModel rectanglePageViewModel)
    {
        InitializeComponent();
        BindingContext = _rectanglePageViewModel = rectanglePageViewModel;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _rectanglePageViewModel.ReloadList();
    }
}