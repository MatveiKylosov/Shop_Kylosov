using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Shop_Кылосов
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<object> AllItems = Classes.RepoItems.AllItems();

        public MainWindow()
        {
            InitializeComponent();
            CreateUI();
        }

        public void CreateUI()
        {
            foreach (object Item in AllItems)
                parent.Children.Add(new Elements.Item(Item));
        }

        private void KeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F && Keyboard.Modifiers == ModifierKeys.Control)
                Search.Visibility = Search.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var child in parent.Children)
            {
                if (!(child is Elements.Item itemElement))
                    continue;

                bool PriceMatch = false, NameMatch = false, AddMatch = false;

                if (int.TryParse(itemElement.tb_Price.Content.ToString().Remove(0, 5), out int fPrice) & int.TryParse(PriceObject.Text.ToString(), out int sPrice))
                    PriceMatch = fPrice == sPrice;

                NameMatch = !string.IsNullOrEmpty(NameObject.Text) & itemElement.tb_Name.Content.ToString().ToLower().Contains(NameObject.Text.ToLower());

                AddMatch = (!string.IsNullOrEmpty(AddObject.Text) & itemElement.tb_Characteristic.Content.ToString().ToLower().Contains(AddObject.Text.ToLower()));



                if ((string.IsNullOrEmpty(PriceObject.Text) || PriceMatch) &&
                    (string.IsNullOrEmpty(NameObject.Text)  || NameMatch ) &&
                    (string.IsNullOrEmpty(AddObject.Text)   || AddMatch  ))
                    itemElement.BorderItem.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6497bf"));
                else
                    itemElement.BorderItem.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5a5a5a"));
                Search.Visibility = Search.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
            }
        }
    }
}


/*
         private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var child in parent.Children)
            {
                if (!(child is Elements.Item itemElement))
                    continue;

                int fPrice = 0, sPrice = 0;

                if (
                        (int.TryParse(itemElement.tb_Price.Content.ToString().Remove(0, 5), out fPrice) & int.TryParse(PriceObject.Text.ToString(), out sPrice) &
                        fPrice == sPrice) & 
                        (
                            (!string.IsNullOrEmpty(NameObject.Text) & itemElement.tb_Name.Content.ToString().ToLower().Contains(NameObject.Text.ToLower())) ||
                            (!string.IsNullOrEmpty(AddObject.Text) & itemElement.tb_Characteristic.Content.ToString().ToLower().Contains(AddObject.Text.ToLower()))
                        )
                    )
                {
                    
                    itemElement.BorderItem.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6497bf"));
                }
                else
                {
                    itemElement.BorderItem.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5a5a5a"));
                }


            }

            Search.Visibility = Search.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
        }
 */