using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MemoryLeakTest {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage {
        ContentPage page;
        public Page3(ContentPage page) {
            InitializeComponent();
            this.page = page;
        }

        private void Button_Clicked(object sender, EventArgs e) {
            Navigation.PushAsync(page);
        }

        private void Button_Clicked2(object sender, EventArgs e) {
            FFImageLoading.ImageService.Instance.InvalidateMemoryCache();
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
        }
    }
}