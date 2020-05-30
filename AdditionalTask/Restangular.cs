using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalTask
{
    public class Rectangular : ITriangle 
    {
        #region 
        int firstParty;
        int secondParty;
        int corner;
        #endregion

        #region 
        public Rectangular(int firstParty, int secondParty, int corner)
        {
            this.firstParty = firstParty;
            this.secondParty = secondParty;
            this.corner = corner;
        }
        #endregion

        #region 
        public int FirstParty { get { return firstParty; } }
        public int SecondParty { get { return secondParty; } }
        public int Corner { get { return corner; } }
        #endregion

        #region
        public double Area()
        {
            return 0.5 * FirstParty * SecondParty * System.Math.Sin(Corner);
        }
        #endregion

        #region 
        public double Perimeter()
        {
            return System.Math.Sqrt(System.Math.Pow(FirstParty, 2) + System.Math.Pow(SecondParty, 2));
        }
        #endregion

        #region 
        public double Sum()
        {
            return 195.09 + 64.75;
        }
        #endregion

        #region 
        public override string ToString()
        {
            return String.Format("Площа рiвнобедреного трикутника дорiвнює {0}, периметр дорiвнює {1}, сума площ {2}.", System.Math.Round(Area(), 2), System.Math.Round(Perimeter(), 2), System.Math.Round(Sum(), 2));
        }
        #endregion
    }
}