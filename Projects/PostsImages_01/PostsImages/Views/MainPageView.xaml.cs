using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Plugin.Media;
using PostsImages.Models;
using PostsImages.Services;
using Xamarin.Forms;

namespace PostsImages.Views
{
    public partial class MainPageView : ContentPage
    {
        public MainPageView()
        {
            InitializeComponent();
            if (UserInfo.imageByte != null)
            {
                var stream1 = new MemoryStream(UserInfo.imageByte);
                
                image.Source = ImageSource.FromStream(() => stream1);

                
                //PdfImage.Source = image.Source;
                if (UserInfo.Kindphoto == 1)
                {
                    image.Rotation = 90;
                    //PdfImage.Rotation = 90;
                }
            }
        }

        //async void OnPickPhotoButtonClicked(object sender, EventArgs e)
        //{
        //    UserInfo.Kindphoto = 0;
        //    Stream imageStream = null;

        //    (sender as Button).IsEnabled = false;

        //    Stream stream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync();
        //    //if (stream != null)
        //    //{
        //    //    image.Source = ImageSource.FromStream(() => stream);

        //    //}

        //    imageStream = stream;
        //    BinaryReader br = new BinaryReader(imageStream);
        //    UserInfo.imageByte = br.ReadBytes((int)imageStream.Length);

        //    //UserInfo.Name = GetImageBytes((StreamImageSource) ImageSource.FromResource(image.Source,));

        //    //PdfImage.Source = image.Source;
        //    var stream1 = new MemoryStream(UserInfo.imageByte);
        //    image.Source = ImageSource.FromStream(() => stream1);

        //    var stream2 = new MemoryStream(UserInfo.imageByte);
        //    PdfImage.Source = ImageSource.FromStream(() => stream2);

        //    //(sender as Button).IsEnabled = true;
        //    image.Rotation = 0;

        //}

        //public byte[] imageByte;
        

        private async void OnTakePhotoButtonClicked(object sender, EventArgs e)
        {
            UserInfo.Kindphoto = 1;
            Stream imageStream = null;
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,
                Directory = "Sample",
                Name = "test.jpg",

            });

            if (file == null)
                return;

            await DisplayAlert("File Location", file.Path, "OK");

            string local = file.Path;
            UserInfo.ImageSource = local;

            

            image.Source = ImageSource.FromStream(() =>
           {
               var stream = file.GetStream();
               //file.Dispose();

               return stream;
           });

            //PdfImage.Source = image.Source;

            //PdfImage.Source = ImageSource.FromStream(() =>
            //{
            //    var stream = file.GetStream();
            //    //file.Dispose();
            //    return stream;
            //});

            var test = file;
            imageStream = file.GetStream();
            BinaryReader br = new BinaryReader(imageStream);
            UserInfo.imageByte = br.ReadBytes((int)imageStream.Length);

            //UserInfo.Name = GetImageBytes((StreamImageSource) ImageSource.FromResource(image.Source,));
            image.Rotation = 90;

            var stream1 = new MemoryStream(UserInfo.imageByte);
            //PdfImage.Source = ImageSource.FromStream(() => stream1);
            //PdfImage.Rotation = 90;

            //byte[] imageAsBytes = imageByte;
            //var stream1 = new MemoryStream(imageAsBytes);
            //PdfImage.Source = ImageSource.FromStream(() => new MemoryStream(imageAsBytes));

            //imagePanel.Children.Add(PdfImage);
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            byte[] result = null;
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                result = ms.ToArray();
            }


            return result;
        }

        private byte[] GetImageBytes(StreamImageSource imagesource)
        {
            byte[] ImageBytes;
            using (var memoryStream = new System.IO.MemoryStream())
            {
                var stream = imagesource.Stream.Invoke(new System.Threading.CancellationToken()).Result;
                stream.CopyTo(memoryStream);
                stream = null;
                ImageBytes = memoryStream.ToArray();
            }
            return ImageBytes;
        }

             
            //var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            //       { Name = "pic.jpg"});
            //if (file == null) return;
            //imageStream = file.GetStream();
            
            
    }
}
