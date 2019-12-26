using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Toptanci.CodeFirst;

namespace BLL
{
    public class FirmaBL:IDisposable
    {
      public ToptanciDbContext ctx = new ToptanciDbContext();

        public void Dispose()
        {
            ((IDisposable)ctx).Dispose();
        }

        public bool Ekle(Form1 f)
        {
            ctx.Firmalar.Add(f);
            return ctx.SaveChanges() > 0;
        }

    }
}
