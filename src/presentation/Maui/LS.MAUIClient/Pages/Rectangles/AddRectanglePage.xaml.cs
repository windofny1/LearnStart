using LS.MAUIClient.ViewModels;
using LS.MAUIClient.ViewModels.Rectangles;

namespace LS.MAUIClient.Pages.Rectangles;


partial class AddRectanglePage : ContentPage, IQueryAttributable
{
	public Guid? QueryId { get; set; }
    private readonly AddRectangleViewModel _addRectangleViewModel;

	public void ApplyQueryAttributes(IDictionary<string, object> query)
	{
        QueryId = null;

        if (query.ContainsKey(nameof(QueryId)))
		{
            QueryId = (Guid?)query[nameof(QueryId)];
        }		
    }
        public AddRectanglePage(AddRectangleViewModel addRectangleViewModel)
	{
		InitializeComponent();
		BindingContext = _addRectangleViewModel = addRectangleViewModel;
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (QueryId != null)
        {
            _addRectangleViewModel.EditId = QueryId;
            _addRectangleViewModel.LoadRectangle(QueryId.Value);
        }
        else
        {
            _addRectangleViewModel.EditId = null;
        }
    }
}