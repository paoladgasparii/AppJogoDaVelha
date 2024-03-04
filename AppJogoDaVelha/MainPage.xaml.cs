
namespace AppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "O";
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn10_Clicked(System.Object sender, System.EventArgs e)
        {
            Button disparador = (Button)sender;

            disparador.IsEnabled = false;

            if(vez == "O")
            {
                disparador.Text = "0";
                vez = "X";
            } 
            else
            {
                disparador.Text = "X";
                vez == "O";
            }

        }
    }  

}
