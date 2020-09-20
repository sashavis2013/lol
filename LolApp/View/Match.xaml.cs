using LolApp.Controller;
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
using System.Windows.Shapes;
using LolApp.Utils;

namespace LolApp.View
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Match : Grid
    {
        ControllerProfile controller;
        public Match(Constants summoner)
        {
            controller = new ControllerProfile();
            InitializeComponent();
            this.DataContext = controller.GetContext(summoner);
        }
        
        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
