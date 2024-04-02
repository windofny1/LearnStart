using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LS.Application.Common.Interfaces.Services;
using LS.Domain.Entities;
using LS.Infrastracture.Services;
using LS.MAUIClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.MAUIClient.ViewModels
{
    public partial class MainPageViewModel: BaseViewModel
    {
        int count = 0;
        [ObservableProperty]
        public string labelCountText = "";

        private readonly IRectangleService _rectangleService;
        [ObservableProperty]
        private Rectangle rectangle=new();
        public MainPageViewModel(IRectangleService rectangleService)
        {
            _rectangleService = rectangleService;
        }
        [RelayCommand]
        public void ButtonClick()
        { 
            count++;
            _rectangleService.Add(new Rectangle()
            {
                Height = rectangle.Height,
                Width = rectangle.Width,
                Name = rectangle.Name
            });
            _rectangleService.Add(rectangle);

            if (count == 1)
                LabelCountText = $"Clicked {count} time";
            else
                LabelCountText = $"Clicked {count} times";
        }
            public MainPageViewModel()
        {
           
        }
    }
}
