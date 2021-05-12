using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using RecipeNotebook.Models;
using System.ComponentModel;
using RecipeNotebook.ViewModel;

namespace RecipeNotebook
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeDetails : ContentPage
    {
        DetailsViewModel viewModel;
        Recipe selectedRecipe;
        public RecipeDetails()
        {
            InitializeComponent();
            
            var viewModel = new DetailsViewModel();
   
 
        }

     
    }
}