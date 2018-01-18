using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacaoComCodeFirst.Models
{
    public class DbContext
    {
        private string v;

        public DbContext(string v)
        {
            this.v = v;
        }
    }
}