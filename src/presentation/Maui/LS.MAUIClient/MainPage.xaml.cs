using LS.MAUIClient.ViewModels;

namespace LS.MAUIClient
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel _mainPageViewModel;
        public MainPage(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            BindingContext = _mainPageViewModel = mainPageViewModel;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
        }
    }

}
