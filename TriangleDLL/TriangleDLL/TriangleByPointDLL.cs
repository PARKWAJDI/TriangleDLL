using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this coding is used to determine various parameters such as
//area, perimeter and angle of a triangle by using the side value given by the user

namespace TriangleDLL
{
    public class TriangleByPointDLL //class by point
    {
        private double _x1;
        private double _y1;
        private double _x2;
        private double _y2;
        private double _x3;
        private double _y3;


        public double X1
        {
            get { return _x1; }
            set { _x1 = value; }
        }

        public double Y1
        {
            get { return _y1; }
            set { _y1 = value; }
        }

        public double X2
        {
            get { return _x2; }
            set { _x2 = value; }
        }

        public double Y2
        {
            get { return _y2; }
            set { _y2 = value; }
        }

        public double X3
        {
            get { return _x3; }
            set { _x3 = value; }
        }

        public double Y3
        {
            get { return _y3; }
            set { _y3 = value; }
        }

        /// <summary>
        /// contructor for triangle calculator by point (3 coordinates, 6 unknowns)
        /// one constructor only because there are no parameter (=0)
        /// </summary>
        public TriangleByPointDLL() //constructor
        {
            _x1 = 0;
            _y1 = 0;
            _x2 = 0;
            _y2 = 0;
            _x3 = 0;
            _y3 = 0;

        }

        /// <summary>
        /// there are various parameters can be calculate by using specific formula (side, perimeter, area, angle)
        /// </summary>
        /// <param name="x1"> The first unknown of coordinate 1 of a triangle </param> 
        /// <param name="y1"> The second unknown of coordinate 1 of a triangle </param> 
        /// <param name="x2"> The first unknown of coordinate 2 of a triangle </param>
        /// <param name="y2"> The second unknown of coordinate 2 of a triangle </param> 
        /// <param name="x3"> The first unknown of coordinate 3 of a triangle </param> 
        /// <param name="y3"> The second unknown of coordinate 3 of a triangle </param> 
        /// <returns> the formula for each parameters using x1, x2, x3, y1, y2, and y3 </returns>
        public double SideA() //method to find distance of side A by using pythagoras
        {
            return (Math.Sqrt(((_x2 - _x1) * (_x2 - _x1)) + ((_y2 - _y1) * (_y2 - _y1))));
        }
        public double SideB() //method to find distance of side B by using pythagoras
        {
            return (Math.Sqrt(((_x1 - _x3) * (_x1 - _x3)) + ((_y1 - _y3) * (_y1 - _y3))));
        }
        public double SideC() //method to find distance of side C by using pythagoras
        {
            return (Math.Sqrt(((_x3 - _x2) * (_x3 - _x2)) + ((_y3 - _y2) * (_y3 - _y2))));
        }
        public double Perimeter() //method to find triangle perimeter
        {
            return (Math.Sqrt(((_x2 - _x1) * (_x2 - _x1)) + ((_y2 - _y1) * (_y2 - _y1))))
                + (Math.Sqrt(((_x1 - _x3) * (_x1 - _x3)) + ((_y1 - _y3) * (_y1 - _y3))))
                + (Math.Sqrt(((_x3 - _x2) * (_x3 - _x2)) + ((_y3 - _y2) * (_y3 - _y2))));

        }

        private double S() //method to find triangle half perimeter
        {
            return Perimeter() / 2;

            // return Perimeter / 2; 
        }

        public double Area() //method to find triangle area
        {
            return Math.Sqrt(S() * (S() - SideA()) * (S() - SideB()) * (S() - SideC()));

            //return Math.Sqrt(S*(S-SideA)* (S - SideB)* (S - SideC));
        }

        //for angleBC
        public double AngleBC() //method to find angle between side B and side C
        {
            return ((Math.Acos((SideB() * SideB() + SideC() * SideC() - SideA() * SideA()) / (2 * SideB() * SideC()))) * 180) / Math.PI;
        }

        //for angleAC
        public double AngleAC() //method to find angle between side A and side C
        {
            return ((Math.Acos((SideA() * SideA() + SideC() * SideC() - SideB() * SideB()) / (2 * SideA() * SideC()))) * 180) / Math.PI;
        }

        //for angleAB
        public double AngleAB() //method to find angle between side A and side B
        {
            return ((Math.Acos((SideA() * SideA() + SideB() * SideB() - SideC() * SideC()) / (2 * SideA() * SideB()))) * 180) / Math.PI;
        }

        public string Reality() //method to determine the reality of the triangle
        {
            if ((SideA() > SideB()) && (SideA() > SideC())) //if side A was the longest
            {
                if (SideB() + SideC() > SideA())
                {
                    return "Real";
                }
                if (SideB() + SideC() == SideA())
                {
                    return "Null";
                }

                if (SideB() + SideC() < SideA())
                {
                    return "Imaginary";
                }

            }

            if ((SideB() > SideA()) && (SideB() > SideC())) //if side B was the longest
            {
                if (SideA() + SideC() > SideB())
                {
                    return "Real";
                }
                if (SideA() + SideC() == SideB())
                {
                    return "Null";
                }

                if (SideA() + SideC() < SideB())
                {
                    return "Imaginary";
                }

            }

            if ((SideC() > SideB()) && (SideC() > SideA())) //if side C was the longest
            {
                if (SideB() + SideA() > SideC())
                {
                    return "Real";
                }
                if (SideB() + SideA() == SideC())
                {
                    return "Null";
                }

                if (SideB() + SideA() < SideC())
                {
                    return "Imaginary";
                }

            }

            return "";
        }
    }
}
