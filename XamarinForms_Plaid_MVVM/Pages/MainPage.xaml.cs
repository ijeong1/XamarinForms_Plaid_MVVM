using Xamarin.Forms;
using XamarinForms_Plaid_MVVM.PageModels;

namespace XamarinForms_Plaid_MVVM.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageModel();
        }
    }
}
