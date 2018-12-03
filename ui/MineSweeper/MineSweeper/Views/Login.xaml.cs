﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MineSweeper.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
        }

        private void PassportSignInButton_Click(object sender, RoutedEventArgs e)
        {
            //默认成功登录
            //todo 之后

            Frame.Navigate(typeof(MainPage), null);
        }


        private void RegisterButtonTextBlock_OnPointerPressed(object sender, RoutedEventArgs e)
        {
            //跳转到注册界面
            Frame.Navigate(typeof(Register), null);
        }

        private void UsernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UserpasswordTextBox_TextChanged(object sender,TextChangedEventArgs e)
        {

        }
    }
}
