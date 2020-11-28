
using System.Collections.Generic;

using System.Windows;


namespace UTF4_EJER2
{
    
    public partial class MainWindow : Window
    {
        

        List <Superheroe> superheroes;
        
        public MainWindow()
        {

            this.superheroes = Superheroe.GetSamples();
            verGrid.DataContext = superheroes;
            TotalTextBlock.Text = superheroes.Count.ToString();

            InitializeComponent();
        }
    }
}
