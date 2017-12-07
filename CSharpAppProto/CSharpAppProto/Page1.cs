using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CSharpAppProto
{
	public class Page1 : ContentPage
	{
        List<Label> lblList = new List<Label>();
        public Page1()
        {
            StackLayout layout = new StackLayout();
            Content = layout;
            for (int n = 0; n < 10; n++)
            {
                lblList.Add(new Label());
                lblList[n].Text = "Test: " + n.ToString() + " ......."; lblList[n].VerticalOptions = LayoutOptions.Center; lblList[n].HorizontalOptions = LayoutOptions.Center;
                layout.Children.Add(lblList[n]);
            }           
        }
	}
}