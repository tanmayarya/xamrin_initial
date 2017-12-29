using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace helloworld
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            image.Source = ImageSource.FromResource("helloworld.Images.Screen Shot 2017-12-28 at 9.03.57 AM.png");
        }
    }
}
