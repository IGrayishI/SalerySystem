using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genomgång_SalerySystem
{
    internal class HeadOffice
    {
        private Outlet[] Outlets;
        private int CurrentOutletCount;

        public HeadOffice(int maxOutlets)
        {
            Outlets = new Outlet[maxOutlets];
        }

        public void AddOutlet(Outlet outlet)
        {
            if (CurrentOutletCount < Outlets.Length)
            {
                Outlets[CurrentOutletCount] = outlet;
                CurrentOutletCount++;
            }
            else
            {
                Console.WriteLine("Head Office has reached its maximum amounts");
            }
        }

        public double GetTotalCompanySalary()
        {
            double total = 0;
            for (int i = 0; i < CurrentOutletCount; i++)
            {
                total += Outlets[i].GetTotalOutletSalary();
                
            }

            return total;
        }
    }
}
