﻿using Core;
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

namespace DesktopClient
{
    /// <summary>
    /// Interaction logic for CreateEmployeeView.xaml
    /// </summary>
    public partial class CreateEmployeeView : UserControl
    {
        public CreateEmployeeView()
        {
            InitializeComponent();
        }

        private void BtnSaveEmployee_Click(object sender, RoutedEventArgs e)
        {
            Mediator.GetInstance().OnCreateEmployeeClicked();
        }
    }
}