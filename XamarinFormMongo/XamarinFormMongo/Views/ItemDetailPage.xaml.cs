using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinFormMongo.Models;
using XamarinFormMongo.ViewModels;

namespace XamarinFormMongo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Gorev()
            {
                GorevAdi = "Item 1",
                Aciklama = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}