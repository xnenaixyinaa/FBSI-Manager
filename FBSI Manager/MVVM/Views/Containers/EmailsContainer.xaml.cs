﻿using System;
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

namespace FBSI_Manager
{
    /// <summary>
    /// Interaction logic for EmailsContainer.xaml
    /// </summary>
    public partial class EmailsContainer : UserControl
    {
        public EmailsContainer()
        {
            InitializeComponent();
        }
        private void SelectItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            Container.Children.Add(new EmailView());
        }

        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}