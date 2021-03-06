﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UIPlaceholderSample.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UIPlaceholderSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel ViewModel => this.DataContext as MainPageViewModel;
        public ObservableCollection<int> Items = new ObservableCollection<int>();
        public MainPage()
        {
            this.InitializeComponent();

            //addign fake data
            Items.Add(1);
            Items.Add(2);
            Items.Add(3);
            Items.Add(4);
            Items.Add(5);
            Items.Add(6);

            Loaded += MainPage_Loaded;
        }

        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.LoadDifferentStates();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.LoadDifferentStates();
        }
    }
}
