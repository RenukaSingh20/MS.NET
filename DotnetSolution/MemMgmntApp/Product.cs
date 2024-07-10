using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemMgmntApp
{
    internal class Product:IDisposable,ICloneable
    {
        public string Title {  get; set; } 
        public double UnitPrice { get; set; }
        public Product(string title, double unitPrice)
        {
            Title = title;  
            UnitPrice = unitPrice;
        }

        ~Product() { 
            //destructor
            //clean up code
        }
        public void Dispose() {
            //self reference
            GC.SuppressFinalize(this);
        }

        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }
    }
}
