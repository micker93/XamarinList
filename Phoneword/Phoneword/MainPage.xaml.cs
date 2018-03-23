using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;


namespace Phoneword
{
	public partial class MainPage : ContentPage
	{
        string inputname = "";
        int inputage = 0;
        string inputadress = "";

        ObservableCollection<tes> test = new ObservableCollection<tes>() {};
        public MainPage()
		{
            

            InitializeComponent();
            

        }

        public void ButtonClick(object sender,EventArgs args)
        {
            
            var username = name.Text;
            var userage = age.Text;
            var useradress = adress.Text;
            string convert = Convert.ToString(inputage);

           

            inputname = username;
            convert = userage;
            inputadress = useradress;

            int convertback = Convert.ToInt32(convert);
            test.Add(new tes{DisplayName=inputname,Age=convertback,Adress=inputadress,Time=DateTime.Now} );

            Testview.ItemsSource = test;
         
        }

        private void Remove_Clicked(object sender,EventArgs e)
        {
            var button = sender as Button;
            var person = button.BindingContext as tes;

            test.Remove(person);
        }

        public void Clear_Entry(object sender,EventArgs e)
        {
           

        }
    }
}
