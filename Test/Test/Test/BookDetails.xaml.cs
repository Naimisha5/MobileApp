using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test
{
 [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class BookDetails : ContentPage
  { 
     private BookModel selectedBook { get; set; }
        public BookDetails (BookModel selectedBookModel)
        {
            InitializeComponent();
            selectedBook = selectedBookModel;
            ImageLable.Source = selectedBook.Image;
            Name.Text = selectedBook.Name;
            Author.Text = selectedBook.Author;
            Price.Text = selectedBook.Price.ToString();
            Rating.Text = selectedBook.Rating.ToString();
            Description.Text = selectedBook.Description;
        }
        async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PopAsync();
            await DisplayAlert("Alert", "The Book is not available", "OK");
        }
  }
}