using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagerLoadingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Model1())
            {
                var stud1 = context.Users.Include("UserRoles").ToList();
            }
        }
    }
}
