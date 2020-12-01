using System.Collections.Generic;
using System.ComponentModel;

namespace UTF4_EJER2
{

    class Superheroe : INotifyPropertyChanged
    {
        //no va lo del propfull asi que a mano 

        private string Nombre;
        private string Imagen;
        private bool Vengador;
        private bool Xmen;
        private bool Heroe;
        private bool Villano;



        public string nombre
        {
            get { return Nombre; }
            set
            {
                Nombre = value;
                this.NotifyPropertyChanged("nombre");
            }

        }
        public string imagen
        {
            get { return Imagen; }
            set
            {
                Imagen = value;
                this.NotifyPropertyChanged("imagen");
            }

        }
        public bool vengador
        {
            get { return Vengador; }
            set
            {
                Vengador = value;
                this.NotifyPropertyChanged("vengador");
            }

        }
        public bool heroe
        {
            get { return Heroe; }
            set
            {
                Heroe = value;
                this.NotifyPropertyChanged("heroe");
            }

        }
        public bool villano
        {
            get { return Villano; }
            set
            {
                Villano = value;
                this.NotifyPropertyChanged("villano");
            }

        }
        public bool xmen
        {
            get { return Xmen; }
            set
            {
                Xmen = value;
                this.NotifyPropertyChanged("xmen");
            }

        }

        public Superheroe()
        {
            
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe, bool villano)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
            Villano = villano;
        }



        public static List<Superheroe> GetSamples()
        {
            List<Superheroe> ejemplos = new List<Superheroe>();

            Superheroe ironman = new Superheroe("Ironman", @"https://sm.ign.com/ign_latam/screenshot/default/ybbpqktez5whedr0-1592031889_31aa.jpg", true, false, true, false);
            Superheroe kingpin = new Superheroe("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false, false, true);
            Superheroe spiderman = new Superheroe("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true, true, false);

            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);

            return ejemplos;
        }
        //Implementación de la interfaz INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}