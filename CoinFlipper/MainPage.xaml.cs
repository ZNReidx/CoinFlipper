namespace CoinFlipper
{
    public partial class MainPage : ContentPage
    {
  

        public MainPage()
        {
            InitializeComponent();
        }

        private void GirarButton_Clicked(System.Object sender, System.EventArgs e)
        {
            //Pegar o que o usuário selecionou
            //Sortear o lado
            //Comparar o que selecionou e o que foi sorteado
            //Trocar imagem

            string ladoSelected = SelecaoPicker.SelectedItem.ToString();
            string ladoDrawn = new Random().Next(2).ToString();
            if (ladoDrawn == "0")
            {
                ladoDrawn = "cara";
                MoedaImage.Source = ladoDrawn + ".png";
            }
            else
            {
                ladoDrawn = "coroa";
                MoedaImage.Source = ladoDrawn + ".png";

            }
            if (ladoSelected == ladoDrawn)
            {
                string resultado = "Você venceu!";
                ResultadoLabel.Text = resultado;
            }
            else
            {
                string resultado = "Você perdeu";
                ResultadoLabel.Text = resultado;
            }
            
            
        }
    }

}
