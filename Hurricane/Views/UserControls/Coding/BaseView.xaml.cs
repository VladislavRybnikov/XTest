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

namespace Hurricane.Views.UserControls.Coding
{
    /// <summary>
    /// Логика взаимодействия для BaseView.xaml
    /// </summary>
    public partial class BaseView : UserControl
    {
        private Grid _currentGrid;
        public BaseView(string name,Grid currentGrid)
        {
            InitializeComponent();
            NameTest.Text = name;
            _currentGrid = currentGrid;
            StaertTest.Click += StaertTest_Click;
        }

        private void StaertTest_Click(object sender, RoutedEventArgs e)
        {
            if (NameTest.Text.ToLower().Equals("Abramsone".ToLower()))
            {
                _currentGrid.Children.Clear();
                _currentGrid.Children.Add(new AbramsoneView());
            }
          
        }
    }
}
