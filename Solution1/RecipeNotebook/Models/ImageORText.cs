using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RecipeNotebook.Models
{
    public class ImageORText
    {
        public enum Type { Image, Text };

        public Type type;
        public string data { get; set; }

        public bool isImage { get { return type == Type.Image; } }
        public bool isText { get { return type == Type.Text; } }

    }
}
