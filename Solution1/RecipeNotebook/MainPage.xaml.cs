using Newtonsoft.Json;
using RecipeNotebook.Models;
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

            GetAllRecipes();

        }

        private async void GetAllRecipes()
        {
            HttpClient client = new HttpClient();

            var response =await client.GetStringAsync("https://reciperestapi.azurewebsites.net/api/recipe");

            var recipes = JsonConvert.DeserializeObject<List<Recipe>>(response);

            RecipeListView.ItemsSource = recipes; 
        }
    }
}
