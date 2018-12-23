# XImgBtn
An Image View with Tap Gesture Recognizer (Different image sources for Up and Pressed Conditions) and Tap/Click Animation for Xamarin Forms

The Control has 2 image sources in addition to the Default "Source" Property.
here is how to use the control:

1. Add The NuGet Package from : https://www.nuget.org/packages/XImgBtn/1.0.2

2. Reference the assembly in your Xaml Code:

        xmlns:xib="clr-namespace:XImgBtn;assembly=XImgBtn"
  
3.Now you can use the control like this:

        <xib:XImgBtnView x:Name="xib1"
                         Source="bkbtnup.png"
                         ImgSrcPressed="bkbtnpressed.png" 
                         ImgSrcUp="bkbtnup.png"
                         XibId="1" 
                         StrParam="XBtn1"
                         WidthRequest="120"
                         HeightRequest="120"
                         HorizontalOptions="Center"
                         VerticalOptions="Center"/>
                         
4. you can pass the desired variables to the click handler using "XibId" (to pass an Int) & "StrParam" (to pass a string) 
  when you have multiple XimgBtns
  
5. Here is how you can Handle The Tap Event:

        private void BtnTapped(object sender, XIBEventArgs args)
        {
        
        }
        
        
  the XIBEventArgs class is drived from EventArgs class and is used for passing the 2 Variables: 
  
        args.XId   and   args.XMsg

6 Take a look At the Sample

7. ❤ Xamarin and Good Luck  😉
