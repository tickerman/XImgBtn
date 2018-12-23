using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XImgBtn
{
    public class XImgBtnView : Image
    {
        #region BindableProperties
        public static readonly BindableProperty ImgSrcUpProperty = BindableProperty.Create("ImgSrcUp", typeof(string), typeof(XImgBtnView), "");
        public string ImgSrcUp
        {
            get { return ((string)GetValue(ImgSrcUpProperty)); }
            set
            {
                SetValue(ImgSrcUpProperty, value);
            }
        }
        public static readonly BindableProperty ImgSrcPressedProperty = BindableProperty.Create("ImgSrcPressed", typeof(string), typeof(XImgBtnView), "");
        public string ImgSrcPressed
        {
            get { return ((string)GetValue(ImgSrcPressedProperty)); }
            set
            {
                SetValue(ImgSrcPressedProperty, value);
            }
        }
        public static readonly BindableProperty StrParamProperty = BindableProperty.Create("StrParam", typeof(string), typeof(XImgBtnView), "");
        public string StrParam
        {
            get { return ((string)GetValue(StrParamProperty)); }
            set
            {
                SetValue(StrParamProperty, value);
            }
        }
        public static readonly BindableProperty XibIdProperty = BindableProperty.Create("XibId", typeof(int), typeof(XImgBtnView), 0);
        public int XibId
        {
            get { return ((int)GetValue(XibIdProperty)); }
            set
            {
                SetValue(XibIdProperty, value);
            }
        }
        public static readonly BindableProperty XibScaleProperty = BindableProperty.Create("XibScale", typeof(double), typeof(XImgBtnView), 1D);
        public double XibScale
        {
            get { return ((double)GetValue(XibScaleProperty)); }
            set { SetValue(XibScaleProperty, (double)value); }
        }
        public EventHandler<XIBEventArgs> BtnTapped { get; set; }
        #endregion BindableProperties

        #region Private Variables
        private TapGestureRecognizer Tgr;
        public bool TapinProcess { get; private set; }
        #endregion Private Variables
        public XImgBtnView()
        {
            Source = ImgSrcUp;
            Tgr = new TapGestureRecognizer();
            Tgr.Tapped += new EventHandler(async (s, e) => await Btn_TapedAsync(s, e));
            GestureRecognizers.Add(Tgr);
        }
        private async Task Btn_TapedAsync(object s, EventArgs e)
        {
            if (!TapinProcess)
            {
                TapinProcess = true;
                Source = ImgSrcPressed;
                await this.ScaleTo((XibScale * .7), 50, Easing.CubicIn);

                Source = ImgSrcUp;
                await this.ScaleTo(XibScale, 20, Easing.CubicIn);

                BtnTapped?.Invoke(this, new XIBEventArgs { XId = XibId, XMsg = StrParam });
                TapinProcess = false;
            }
        }
    }
    public class XIBEventArgs : EventArgs
    {
        public int XId { get; set; }
        public string XMsg { get; set; }
    }
}