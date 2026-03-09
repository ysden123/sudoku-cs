using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SudokuApp.Controls
{
    /// <summary>
    /// Interaction logic for CeilControl.xaml
    /// </summary>
    public partial class CeilControl : UserControl
    {
        public CeilControl()
        {
            InitializeComponent();
        }

        private void CeilTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D1 && e.Key <= Key.D9)
            {
                CeilTextBox.Text = (e.Key - Key.D0).ToString();
            }
            else if (e.Key >= Key.NumPad1 && e.Key <= Key.NumPad9)
            {
                CeilTextBox.Text = (e.Key - Key.NumPad0).ToString();
            }
            e.Handled = true;
        }

        public void SetActive(bool isActive)
        {
            if (isActive)
            {
                CeilTextBox.Background = Brushes.LightBlue;
            }
            else
            {
                CeilTextBox.Background = Brushes.White;
            }
        }
    }
}
