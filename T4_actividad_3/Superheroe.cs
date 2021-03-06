﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_actividad_3
{
    class Superheroe : INotifyPropertyChanged
    {
        private string _nombre;
        private string _imagen;
        private bool _vengador;
        private bool _xmen;
        private bool _heroe;
        private bool _villano;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    NotifyPropertyChanged("Nombre");
                }
            }
        }

        public string Imagen
        {
            get { return _imagen; }
            set
            {
                if (_imagen != value)
                {
                    _imagen = value;
                    NotifyPropertyChanged("Imagen");
                }
            }
        }
        public bool Vengador
        {
            get { return _vengador; }
            set
            {
                if (_vengador != value)
                {
                    _vengador = value;
                    NotifyPropertyChanged("Vengador");
                }
            }
        }
        public bool Xmen
        {
            get { return _xmen; }
            set
            {
                if (_xmen != value)
                {
                    _xmen = value;
                    NotifyPropertyChanged("Xmen");
                }
            }
        }
        public bool Heroe
        {
            get { return _heroe; }
            set
            {
                if (_heroe != value)
                {
                    _heroe = value;
                    NotifyPropertyChanged("Heroe");
                }
            }
        }
        public bool Villano
        {
            get { return _villano; }
            set
            {
                if (_villano != value)
                {
                    _villano = value;
                    NotifyPropertyChanged("Villano");
                    if ((Boolean)value == true)
                    {
                        Xmen = false;
                        Vengador = false;
                    }
                }
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

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
