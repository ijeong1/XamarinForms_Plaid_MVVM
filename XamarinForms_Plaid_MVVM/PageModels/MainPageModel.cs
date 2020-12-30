using System;
using System.Diagnostics;
using System.Web;
using Xamarin.Forms;
using XamarinForms_Plaid_MVVM.PageModels.Base;

namespace XamarinForms_Plaid_MVVM.PageModels
{
    public class MainPageModel : PageModelBase
    {
        private UrlWebViewSource _source;

        public MainPageModel()
        {
            var publickey = "YOUR_PLAID_KEY";
            var env = "sandbox"; // YOUR PLAID ENVIRONMENT STRING {sandbox, development, production}
            var product = "auth"; //transactions, auth, identity, income, assets, investments, liabilities
            var clientName = "YOUR_CLIENT_NAME";
            var url = "https://cdn.plaid.com/link/v2/stable/link.html?isWebview=true&key=" + publickey + "&env=" + env + "&product=" + product + "&selectAccount=true&clientName=" + clientName + "&isMobile=true";

            Source = new UrlWebViewSource() { Url = url };
        }

        public Command NavigatingCommand => new Command<WebNavigatingEventArgs>((eventArgs) => NavigatingEventHandler(eventArgs));

        public UrlWebViewSource Source
        {
            get => _source;
            set
            {
                _source = value;
                NotifyPropertyChanged(nameof(Source));
            }
        }

        private void NavigatingEventHandler(WebNavigatingEventArgs args)
        {
            if (args.Url.ToLower().Contains("plaidlink:"))
            {
                args.Cancel = true;
            }
            else
            {
                args.Cancel = false;
            }

            var linkScheme = "plaidlink";
            var scheme = new Uri(args.Url);
            var param = HttpUtility.ParseQueryString(args.Url);

            var actionScheme = scheme.Scheme;
            var actionType = scheme.Host;

            if (actionScheme == linkScheme)
            {
                switch (actionType)
                {
                    case "connected":
                        Debug.WriteLine("Successfully Connected");
                        break;
                    case "exit":
                        Debug.WriteLine("Exit");
                        break;
                    case "event":
                        Debug.WriteLine($"Event name: {param["event_name"]}");
                        break;
                    default:
                        Debug.WriteLine($"Link action detected: {actionType}");
                        break;
                }
            }

        }

    }
}
