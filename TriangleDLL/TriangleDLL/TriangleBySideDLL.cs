using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this coding is used to determine various parameters such as
//area, perimeter and angle of a triangle by using the side value given by the user

namespace TriangleDLL
{
    public class TriangleBySideDLL //class by side
    {
        private double _sideA; 
        private double _sideB;
        private double _sideC;

        public double SideA
        {
            get { return _sideA; }
            set { _sideA = value; }
        }

        public double SideB
        {
            get { return _sideB; }
            set { _sideB = value; }
        }

        public double SideC
        {
            get { return _sideC; }
            set { _sideC = value; }
        }

        /// <summary>
        /// contructor for triangle calculator by sides (3 sides)
        /// one constructor only because there are no parameter (=0)
        /// </summary>
        public TriangleBySideDLL() //constructor
        {
            _sideA = 0;
            _sideB = 0;
            _sideC = 0;
        }

        /// <summary>
        /// there are various parameters can be calculate by using specific formula (side, perimeter, area, angle)
        /// </summary>
        /// <param name="sideA"> The first length of the triangle of the formula </param> 
        /// <param name="sideB"> The second length of the triangle of the formula </param> 
        /// <param name="sideC"> The third length of the triangle of the formula </param> 
        /// <returns> the formula for each parameters using sideA, sideB, and sideC </returns>
        public double Perimeter() //method to find triangle perimeter
        {
            return _sideA + _sideB + _sideC;
        }

        private double S() //method to find triangle half perimeter
        {
            //return (_sideA + _sideB + _sideC)/2;

            return Perimeter() / 2;
        }

        public double Area() //method to find triangle area
        {
            /*return Math.Sqrt(((_sideA + _sideB + _sideC) / 2) 
                * (((_sideA + _sideB + _sideC) / 2) - _sideA) 
                * (((_sideA + _sideB + _sideC) / 2) - _sideB) 
                * (((_sideA + _sideB + _sideC) / 2) - _sideC)); */

            return Math.Sqrt(S() * (S() - _sideA) * (S() - _sideB) * (S() - _sideC));
        }

        //for angleBC
        public double AngleBC() //method to find angle between side B and side C
        {
            return ((Math.Acos(((_sideB * _sideB) + (_sideC * _sideC) - (_sideA * _sideA)) / (2 * _sideB * _sideC))) * 180) / Math.PI;
        }

        //for angleAC
        public double AngleAC() //method to find angle between side A and side C
        {
            return ((Math.Acos(((_sideA * _sideA) + (_sideC * _sideC) - (_sideB * _sideB)) / (2 * _sideA * _sideC))) * 180) / Math.PI;
        }

        //for angleAB
        public double AngleAB() //method to find angle between side A and side B
        {
            return ((Math.Acos(((_sideA * _sideA) + (_sideB * _sideB) - (_sideC * _sideC)) / (2 * _sideA * _sideB))) * 180) / Math.PI;
        }

        public string Reality() //method to determine the reality of the triangle
        {
            if ((_sideA > _sideB) && (_sideA > _sideC)) //if side A was the longest
            {
                if (_sideB + _sideC > _sideA)
                {
                    return "Real";
                }
                if (_sideB + _sideC == _sideA)
                {
                    return "Null";
                }

                if (_sideB + _sideC < _sideA)
                {
                    return "Imaginary";
                }

            }

            if ((_sideB > _sideA) && (_sideB > _sideC)) //if side B was the longest
            {
                if (_sideA + _sideC > _sideB)
                {
                    return "Real";
                }
                if (_sideA + _sideC == _sideB)
                {
                    return "Null";
                }

                if (_sideA + _sideC < _sideB)
                {
                    return "Imaginary";
                }

            }

            if ((_sideC > _sideB) && (_sideC > _sideA)) //if side C was the longest
            {
                if (_sideB + _sideA > _sideC)
                {
                    return "Real";
                }
                if (_sideB + _sideA == _sideC)
                {
                    return "Null";
                }

                if (_sideB + _sideA < _sideC)
                {
                    return "Imaginary";
                }

            }

            return "";
        }

    }
}
