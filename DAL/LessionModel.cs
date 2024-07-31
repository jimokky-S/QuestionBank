using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LessionModel
    {
        public string Name { get; set; }
        public bool IsValidate()
        { 
            if (Name == null)
                return false;
            return true;    
        
        }
    }
}
