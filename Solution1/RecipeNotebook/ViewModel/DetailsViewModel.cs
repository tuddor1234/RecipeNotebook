using RecipeNotebook.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace RecipeNotebook.ViewModel
{
  
    public class DetailsViewModel
    {
     
        public ObservableCollection<Recipe> SelectedRecipes { get; set; }

    

      


        public DetailsViewModel()
        {
           
        }


    }
}
