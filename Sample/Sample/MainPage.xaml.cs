using Xamarin.Forms;
using XImgBtn;

namespace Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            xib1.BtnTapped += BtnTapped;
        }

        private void BtnTapped(object sender, XIBEventArgs args)
        {
            statusLabel.Text = $"Button Pressed Id:{args.XId} , String Parameter:{args.XMsg}";

            //switch (id)
            //{
            //    case 1:
            //        // ToDo ...
            //        break;
            //    .
            //    .
            //    .
            //
            //    default:
            //        // ToDo ...
            //        break;
            //}
        }
    }
}
