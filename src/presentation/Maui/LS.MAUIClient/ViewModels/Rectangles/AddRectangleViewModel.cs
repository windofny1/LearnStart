using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LS.Application.Common.Interfaces.Services;
using LS.Domain.Entities;
using LS.MAUIClient.ViewModels.Base;
using LS.MAUIClient.ViewModels.Rectangles.EntityViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.MAUIClient.ViewModels.Rectangles
{
    public partial class AddRectangleViewModel: BaseViewModel
    {
     
        [ObservableProperty]
        private RectangleViewModel rectangle = new();
        public Guid? EditId { get; set; }
        private readonly IRectangleService _rectangleService;
        public AddRectangleViewModel()
        {

        }
        public AddRectangleViewModel(IRectangleService rectangleService)
        {
            _rectangleService = rectangleService;
        }
        [RelayCommand]
        public async Task SaveRectangle()
        {
            var rect = new LS.Domain.Entities.Rectangle()
            { 
                Height = Rectangle.Height,
                Width = Rectangle.Width,
                Name = Rectangle.Name
            };
            if (EditId != null)
            {
                rect.Id = EditId.Value;
                _rectangleService.Update(rect);               
            }
            else
            {
                rect.Id = Guid.NewGuid();
                _rectangleService.Add(rect);
            }         

            await Shell.Current.GoToAsync(".."); 
        }
        public void LoadRectangle(Guid id)
        {
            var currentRectangle= _rectangleService.GetById(id);
            if (currentRectangle != null)
            {
                Rectangle = new();
                Rectangle.Id = currentRectangle.Id;
                Rectangle.Height = currentRectangle.Height;
                Rectangle.Width = currentRectangle.Width;
                Rectangle.Name = currentRectangle.Name;
            }
        }
      
    }
}
