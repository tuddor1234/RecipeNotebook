using Newtonsoft.Json;
using RecipeNotebook.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace RecipeNotebook.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string name = "TEST";
        public string Name
        {
            get => name;
            set
            {
                if (name == value)
                    return;

                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string DisplayName => $"Recipe : {Name}";

        ObservableCollection<Recipe> recipeList = new ObservableCollection<Recipe>();
        public ObservableCollection<Recipe> RecipeList { get { return recipeList; } }

        public MainViewModel()
        {
            LoadAllRecipes();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    
        private async void LoadAllRecipes()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("https://reciperestapi.azurewebsites.net/api/recipe");

            var recipes = JsonConvert.DeserializeObject<List<Recipe>>(response);

            foreach(var r in recipes)
            {
                recipeList.Add(r);
            }
        }


 


    }
}
