using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genomgång_SalerySystem
{
    internal class HeadOffice
    {
        private Outlet[] outlets;
        private int CurrentOutletCount;

        public HeadOffice(int maxOutlets)
        {
            outlets = new Outlet[maxOutlets];
        }

        public void AddOutlet(Outlet outlet)
        {
            if (CurrentOutletCount < outlets.Length)
            {
                outlets[CurrentOutletCount] = outlet;
                CurrentOutletCount++;
            }
            else
            {
                Console.WriteLine("Head Office has reached its maximum amounts");
            }
        }
    }
}
