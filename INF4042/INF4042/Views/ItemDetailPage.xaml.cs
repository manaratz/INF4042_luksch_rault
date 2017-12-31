using INF4042.Views;
using System;

using Xamarin.Forms;

namespace INF4042
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item",
                Description = "description"
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        async void UpdateItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UpdateItemPage(viewModel));
        }

        async void RemoveItem_Clicked(object sender, EventArgs e)
        {
            await viewModel.DeleteItem_Clicked();
            await Navigation.PopToRootAsync();
        }
    }
}
