using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LS.Application.Common.Interfaces.Services;
using LS.Domain.Entities;
using LS.MAUIClient.Pages.Common;
using LS.MAUIClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.MAUIClient.ViewModels.Rectangles
{
    public partial class RectanglePageViewModel:BaseViewModel
    {
        private readonly IRectangleService _rectangleService;
        public RectanglePageViewModel()
        { 
        }
        public RectanglePageViewModel(IRectangleService rectangleService)
        {
            _rectangleService = rectangleService; 
        }
        [ObservableProperty]
        List<Rectangle> rectangleList=new();
        [ObservableProperty]
        private string search;
        public void ReloadList()
        {
            RectangleList=_rectangleService.GetList(Search); 
        }
        [RelayCommand]
        public async void GoToAddRectangle()
        {
            await Shell.Current.GoToAsync(Routes.AddRectanglePageRoute, new ShellNavigationQueryParameters
    {
        { "Id", "test" }
    });
        }
        [RelayCommand]
        public void SearchList()
        {
            ReloadList();
        }
    }
}
