using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILikeThings {
    class Car {
        private int _NumberOfDoors;
        private string _Color;

        public Car() {
            _NumberOfDoors = 2;
            Color = "silver";
        }

        public int NumberOfDoors {
            set {
                _NumberOfDoors = value;
            }
            get {
                return _NumberOfDoors;
            }
        }

        public string Color {
            get {
                return _Color;
            }
            set {
                _Color = value;
            }
        }


    }
}
