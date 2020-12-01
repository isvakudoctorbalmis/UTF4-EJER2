

using System.Collections.Generic;

using System.Windows;


namespace UTF4_EJER2
{
    
    public partial class MainWindow : Window
    {
        

        List <Superheroe> superheroes;
        Superheroe superheroe;
        
        public MainWindow()
        {

            InitializeComponent();
            this.superheroes = Superheroe.GetSamples();

            superheroe = new Superheroe { heroe = true };
            verGrid.DataContext = superheroes[0];
            CrearGrid.DataContext = superheroe;
            TotalTextBlock.Text = superheroes.Count.ToString();
            posicionTextBlock.Text = "1";
            
        }

        private void izqflechaImage_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            int posicion, total;
            total = superheroes.Count;
            posicion = int.Parse(posicionTextBlock.Text);

            if (posicion  > total)
                drflechaImage.Visibility = Visibility.Collapsed;
            else
                drflechaImage.Visibility = Visibility.Visible;
            if (posicion-1 == 1)
                izqflechaImage.Visibility = Visibility.Collapsed;
            else
                izqflechaImage.Visibility = Visibility.Visible;
            if (posicion <= 1)
                return;
            verGrid.DataContext = superheroes[posicion - 2];
            posicionTextBlock.Text = (posicion-1).ToString();
           

        }

        private void drflechaImage_PreviewMouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            int total, posicion;
            total = superheroes.Count ;
            posicion = int.Parse(posicionTextBlock.Text);

            if (posicion == total)
                izqflechaImage.Visibility = Visibility.Collapsed;
            else
                 izqflechaImage.Visibility = Visibility.Visible;

            if (posicion + 1 == total)
                drflechaImage.Visibility = Visibility.Collapsed;
            else
                drflechaImage.Visibility = Visibility.Visible;

            if (posicion+1 > total)
                return;
            verGrid.DataContext = superheroes[posicion ];
            posicionTextBlock.Text = (posicion + 1).ToString();
            
          
        }

        private void acepButton_Click(object sender, RoutedEventArgs e)
        {

            superheroes.Add(superheroe);
            superheroe = new Superheroe{ heroe=true};
            CrearGrid.DataContext = superheroe;
            int total = superheroes.Count;
            TotalTextBlock.Text = total.ToString();


        }

        private void limpButton_Click(object sender, RoutedEventArgs e)
        {
            superheroe = new Superheroe { heroe = true };

        }

        private void VengadoresCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            superheroe.vengador = false;
            superheroe.xmen = false;
        }
    }
}
