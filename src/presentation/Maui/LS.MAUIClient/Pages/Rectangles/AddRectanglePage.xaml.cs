using LS.MAUIClient.ViewModels;
using LS.MAUIClient.ViewModels.Rectangles;

namespace LS.MAUIClient.Pages.Rectangles;

[QueryProperty(nameof(Id), "Id")]
partial class AddRectanglePage : ContentPage
{
    //public string Id { get; set; } // this string causes exception System.Reflection.AmbiguousMatchException
    private readonly AddRectangleViewModel _addRectangleViewModel;
    public AddRectanglePage(AddRectangleViewModel addRectangleViewModel)
	{
		InitializeComponent();
		BindingContext = _addRectangleViewModel = addRectangleViewModel;
	}
}