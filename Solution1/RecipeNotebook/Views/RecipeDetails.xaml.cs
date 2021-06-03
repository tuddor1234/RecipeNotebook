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
using System.Net.Http;
using System.Collections.ObjectModel;

namespace RecipeNotebook
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeDetails : ContentPage
    {

        DetailsViewModel viewModel;

        ObservableCollection<ImageORText> items; /* new ObservableCollection<ImageORText>();*/
        public ObservableCollection<ImageORText>  Items { get { return viewModel.items; } }


        public RecipeDetails()
        {
            InitializeComponent();

            //  viewModel = new DetailsViewModel(this);
            viewModel = new DetailsViewModel();


            Description.ItemsSource = Items;
        }

        public async void GetXMLFile(Recipe recipe)
        {
            viewModel.GetXMLFile(recipe);
        }
    }
}