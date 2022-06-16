using System;
using System.Collections.Generic;
using System.Text;

namespace parametersAssignment
{
    //gave employee class a generic type
    public class Employee<T>
    {
        // added property called "things" and made generic list
        public List<T> things { get; set; } 
    }
    

}
