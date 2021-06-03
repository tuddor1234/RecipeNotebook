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

            //items.Add(new ImageORText(){data = "1" , type = ImageORText.Type.Text});
            //items.Add(new ImageORText(){data = "https://www.cnet.com/a/img/-qQkzFVyOPEoBRS7K5kKS0GFDvk=/940x0/2020/04/16/7d6d8ed2-e10c-4f91-b2dd-74fae951c6d8/bazaart-edit-app.jpg", type = ImageORText.Type.Image});
            //items.Add(new ImageORText(){data = "1" , type = ImageORText.Type.Text});
            //items.Add(new ImageORText(){data = "1" , type = ImageORText.Type.Text});
            //items.Add(new ImageORText(){data = "https://www.cnet.com/a/img/-qQkzFVyOPEoBRS7K5kKS0GFDvk=/940x0/2020/04/16/7d6d8ed2-e10c-4f91-b2dd-74fae951c6d8/bazaart-edit-app.jpg", type = ImageORText.Type.Image });
            //items.Add(new ImageORText(){data = "1" , type = ImageORText.Type.Text});
           

            ////var text = "Test".ToString(); // { type = ImageORText.Type.text, data = "Test" };
            ////items.Add(text);

            ////var image = new ImageORText() { IsText = false, data = "https://upload.wikimedia.org/wikipedia/commons/a/a7/Epic_Games_logo.png" };
            ////items.Add(image);


        }

        public async void GetXMLFile(Recipe recipe)
        {
            viewModel.GetXMLFile(recipe);
        }

        //public void AddImage(string path)
        //{
        //    items.Add(new Image() { Source = path });
        //}
        
        //public  void AddText(string text)
        //{
        //    items.Add(new Label() { Text = text });
        //}

    }
}