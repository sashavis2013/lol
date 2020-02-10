﻿using LolApp.Controller;
using LolApp.View;
using LolApp.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LolApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ControllerMain controller;
        ViewModelMain viewModel;
        public MainWindow()
        {
            controller = new ControllerMain();
            viewModel = new ViewModelMain();
            InitializeComponent();
            this.DataContext = viewModel;
        }
        private void ButtonSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(viewModel.Region))
                return;
            if (string.IsNullOrEmpty(viewModel.SummonerName))
                return;

            //if (controller.getSummoner(viewModel.SummonerName))
            //{
                WindowProfile profile = new WindowProfile();
                profile.Show();
                this.Close();
        //}
        //    else
        //    {
        //        MessageBox.Show("Not Found");
        //    }





            



}

        private void cmdMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
