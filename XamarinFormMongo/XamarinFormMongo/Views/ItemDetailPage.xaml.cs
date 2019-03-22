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
        private int sayac = 0;
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            swOnay.IsToggled = viewModel.Item.YapilmaTarihi.HasValue;
            BindingContext = this.viewModel = viewModel;
            swOnay.Toggled += async (sender, e) =>
             {
                 if (e.Value)
                 {
                     this.viewModel.Item.YapilmaTarihi = DateTime.Now;
                 }
                 else
                 {
                     this.viewModel.Item.YapilmaTarihi = null;
                 }
                 MessagingCenter.Send(this, "UpdateItem", this.viewModel.Item);
                 await DisplayAlert("Görev Güncelleme", "Görev güncellendi", "Ok");
                 await Navigation.PopAsync(true);
             };

            btnSay.Clicked += (sender, e) =>
            {
                btnSay.Text = $"{++sayac}";
            };
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