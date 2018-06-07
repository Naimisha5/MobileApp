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
	public partial class BooksPage : ContentPage
	{
		public BooksPage ()
		{
			InitializeComponent ();
            var books = GetMockBook();
            bookList.ItemsSource = books;
        }
        private List<BookModel> GetMockBook()
        {
            var books = new List<BookModel>
            {
                new BookModel()
                {
                Name = "Name: Think and Grow Rich",
                Author = "Author: Nepolean Hill",
                Price = 160,
                Rating= 4,
                Image="Thinkandgrowrich.jpg",
                Description="Summary: Think And Grow Rich has earned itself the reputation of being considered a textbook for actionable techniques that can help one get better at doing anything, not just by rich and wealthy, but also by people doing wonderful work in their respective fields."
                },
                new BookModel()
                {
                Name = "Name: Immortal Talks",
                Author = "Author: Shunya",
                Price = 250,
                Rating = 3,
                Image="Immortaltasks.jpg",
                Description="Summary: The book starts with two monks secretly observing a group of tribal people in a forested mountain. It appeared that the jungle dwellers were talking to something that was visible for them but invisible for everyone else. "
                },
                new BookModel()
                {
                Name = "Name: The Blue Umbrella",
                Author = "Author: Ruskin Bond",
                Price = 128,
                Rating= 4,
                Image="theblueumbrella.jpg",
                Description="Summary: The Umbrella was like a flower, a great blue flower that had sprung up on the dry brown hillside.In exchange for her lucky leopard's claw pendant, Binya acquires a beautiful blue umbrella that makes her the envy of everyone in her village, especially Ram Bharosa, the shop-keeper. "           
                }
            };
            return books;
        }
        private void bookList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedBook = e.SelectedItem as BookModel;
            Navigation.PushAsync(new BookDetails(selectedBook));
        }
    }
}