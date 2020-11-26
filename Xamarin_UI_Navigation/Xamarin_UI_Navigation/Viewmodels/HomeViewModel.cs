using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_UI_Navigation.Models;

namespace Xamarin_UI_Navigation.Viewmodels
{
    public class HomeViewModel
    {
        public HomeViewModel() {
            BarAndHotelsMenuOption.Title = "Bar and Hotels"; 
            BarAndHotelsMenuOption.Image = "beer";
            FineDiningMenuOption.Title = "Fine Dining";
            FineDiningMenuOption.Image = "cutlery";
            CafesMenuOption.Title = "Cafes";
            CafesMenuOption.Image = "cafe";
            NearbyMenuOption.Title = "Nearby";
            NearbyMenuOption.Image = "nearby";
            FastFoodsMenuOption.Title = "Fast Foods";
            FastFoodsMenuOption.Image = "hamburguer";
            FeaturedFoodsMenuOption.Title = "Featured Foods";
            FeaturedFoodsMenuOption.Image = "pizza";

        }
        public MenuOption BarAndHotelsMenuOption { get; set; } = new MenuOption(); 
        public MenuOption FineDiningMenuOption { get; set; } = new MenuOption(); 
        public MenuOption CafesMenuOption { get; set; } = new MenuOption(); 
        public MenuOption NearbyMenuOption { get; set; } = new MenuOption(); 
        public MenuOption FastFoodsMenuOption { get; set; } = new MenuOption(); 
        public MenuOption FeaturedFoodsMenuOption { get; set; } = new MenuOption();
    }
}
