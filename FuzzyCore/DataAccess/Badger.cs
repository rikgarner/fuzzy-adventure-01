using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyCore.DataAccess
{
    internal class Badger
    {
        public async Task<string> GetInfo(int id)
        {
            return ""+id+"";
        }
    }
}
