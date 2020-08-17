using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.DataClass
{
    public class Category
    {
        public int? Cid;
        public String Ctgr;
       

        public Category(int Cid, String Ctgr)
        {
            this.Cid = Cid;
            this.Ctgr = Ctgr;
          
        }
    }
}
