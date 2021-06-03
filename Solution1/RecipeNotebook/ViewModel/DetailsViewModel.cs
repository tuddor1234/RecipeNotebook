using RecipeNotebook.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Xamarin.Forms;

namespace RecipeNotebook.ViewModel
{

    public class DetailsViewModel
    {
        public ObservableCollection<ImageORText> items = new ObservableCollection<ImageORText>();

        public DetailsViewModel()
        {
           
        }

        public async void GetXMLFile(Recipe r)
        {
            //if (rd == null)
            //    return;

            HttpClient client = new HttpClient();
            string APIPath = "https://reciperestapi.azurewebsites.net/api/recipe";

            var response = await client.GetStringAsync(APIPath + $"/{r.ID}");

            string stringDoc = @"<?xml version=""1.0"" encoding=""utf - 8""?>" + response;

            XDocument doc = XDocument.Parse(stringDoc);

            ProcessXMLFile(doc);
        }


        private void ProcessXMLFile(XDocument doc)
        {
            foreach (XElement xe in doc.Descendants("Recipe"))
            {
                foreach (XElement childEllement in xe.Descendants())
                {
                    if(childEllement.Name == "Text")
                    {
                        items.Add(new ImageORText() { data = childEllement.Value, type = ImageORText.Type.Text });
                    }
                    else if (childEllement.Name == "Image")
                    {
                        items.Add(new ImageORText() { data = childEllement.Value, type = ImageORText.Type.Image });
                    }
                }

            }

        }


    }

}
