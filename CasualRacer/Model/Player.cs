using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CasualRacer.Model
{
    internal class Player : INotifyPropertyChanged
    {
        private float direction = 0f;

        private float velocity;

        public Vector position = new Vector();

        public float Direction
        {
            get { return direction; }
            set
            {
                if(direction != value)
                {
                    direction = value;
                    //if(PropertyChanged != null)
                    //{
                    //    PropertyChanged(this, new PropertyChangedEventArgs("Direction"));
                    //}

                    //Fragezeichen bedeutet, dass eine Null Abfrage durchgeführt wird!!!
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Direction)));
                }
            }
        }

        public float Velocity
        {
            get { return velocity; }
            set
            {
                if (velocity != value)
                {
                    velocity = value;
                    //if(PropertyChanged != null)
                    //{
                    //    PropertyChanged(this, new PropertyChangedEventArgs("Direction"));
                    //}

                    //Fragezeichen bedeutet, dass eine Null Abfrage durchgeführt wird!!!
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Velocity)));
                }
            }
        }

        public Vector Position
        {
            get { return position; }
            set
            {
                if(position != value)
                {
                    position = value;
                    //if (PropertyChanged != null)
                    //    PropertyChanged(this, new PropertyChangedEventArgs("Position"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Position)));
                }
            }
        }

        public bool Acceleration { get; set; }

        public bool Break { get; set; }

        public bool WheelLeft { get; set; }

        public bool WheelRight { get; set; }

        public Player()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
