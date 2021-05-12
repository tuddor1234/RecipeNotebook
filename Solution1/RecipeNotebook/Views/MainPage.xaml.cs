using Newtonsoft.Json;
using RecipeNotebook.Models;
using RecipeNotebook.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RecipeNotebook
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var viewModel = new MainViewModel();
            BindingContext = viewModel;

            RecipesView.ItemsSource = viewModel.RecipeList;

        }


        private async void RecipeListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
        
            var detailPage = new RecipeDetails();

            var tappedRecipe = e.Item as Recipe;
            detailPage.BindingContext = tappedRecipe;

            await Navigation.PushAsync(detailPage);

        }


    }
}
