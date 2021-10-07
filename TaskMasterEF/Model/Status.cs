using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMasterEF.Model
{
   class Status
   {
      public int Id { get; set; }

      public string Name { get; set; }

      public override string ToString()
      {
         //This help us adding the statuses to a combobox 
         return Name;
      }
   }
}
