using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationshipLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using(  var context=new SportContext())
            {
                var rrresult = context.Players.ToList();
            }
        }
    }
}
