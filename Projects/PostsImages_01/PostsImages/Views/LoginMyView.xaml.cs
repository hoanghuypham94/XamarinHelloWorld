using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using PostsImages.Models;
using Prism.Navigation;
using Xamarin.Forms;

namespace PostsImages.Views
{
    public partial class LoginMyView : ContentPage
    {
       
        public LoginMyView()
        {
            InitializeComponent();
        }

    }
    
    //public void BTNTwitter(object sender, EventArgs args)
    //{
    //       //http://dev.twitter.com/apps
    //    var auth = new OAuth1Authenticator(
    //            consumerKey: "wls4oNSNjtUTaEhzJs825g",
    //            consumerSecret: "cawXz62nwLygGLCEQO1WeK6L2BbKIjI1pwxrRA9LRY",
    //            requestTokenUrl: new Uri("https://api.twitter.com/oauth/request_token"),
    //            authorizeUrl: new Uri("https://api.twitter.com/oauth/authorize"),
    //            accessTokenUrl: new Uri("https://api.twitter.com/oauth/access_token"),
    //            callbackUrl: new Uri("http://mobile.twitter.com"));
    
    //    var ui = auth.GetUI();

    //    auth.Completed += TwitterAuth_Completed;

    //    PresentViewController(ui, true, null);
    //}
        
    //partial void UIButton41_TouchUpInside(UIButton sender)
    //{
    //    // http://dev.twitter.com/apps
    //    var auth = new OAuth1Authenticator(
    //            consumerKey: "wls4oNSNjtUTaEhzJs825g",
    //            consumerSecret: "cawXz62nwLygGLCEQO1WeK6L2BbKIjI1pwxrRA9LRY",
    //            requestTokenUrl: new Uri("https://api.twitter.com/oauth/request_token"),
    //            authorizeUrl: new Uri("https://api.twitter.com/oauth/authorize"),
    //            accessTokenUrl: new Uri("https://api.twitter.com/oauth/access_token"),
    //            callbackUrl: new Uri("http://mobile.twitter.com"));

    //    var ui = auth.GetUI();

    //    auth.Completed += TwitterAuth_Completed;

    //    PresentViewController(ui, true, null);
    //}

    //async void TwitterAuth_Completed(object sender, AuthenticatorCompletedEventArgs e)
    //{
    //    if (e.IsAuthenticated)
    //    {
    //        var request = new OAuth1Request("GET",
    //                       new Uri("https://api.twitter.com/1.1/account/verify_credentials.json"),
    //                       null,
    //                       e.Account);

    //        var response = await request.GetResponseAsync();

    //        var json = response.GetResponseText();

    //        var twitterUser = JsonConvert.DeserializeObject<TwitterUser>(json);

    //        NameLabel.Text = twitterUser.name;
    //        IdLabel.Text = twitterUser.id.ToString();
    //        DescriptionLabel.Text = twitterUser.description;
    //        PictureImage.Image = UIImage.LoadFromData(NSData.FromUrl(new NSUrl(twitterUser.profile_image_url_https)));
    //        CoverImage.Image = UIImage.LoadFromData(NSData.FromUrl(new NSUrl(twitterUser.profile_banner_url)));
    //    }

    //    DismissViewController(true, null);
    //}
}
