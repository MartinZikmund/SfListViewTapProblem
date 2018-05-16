using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ItemTappedEventArgs = Syncfusion.ListView.XForms.ItemTappedEventArgs;

namespace SfListViewTapIssue
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public string[] Items => new[] { "Hello", "World" };

        public ICommand TappedCommand => new Command(RemoveListView);

        private void RemoveListView()
        {
            Layout.Children.Clear();
        }

        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            //await Task.Delay(100); <-- this dirty hack works around the problem

            Layout.Children.Clear();
        }
    }
}
