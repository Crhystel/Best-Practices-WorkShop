using Best_Practices.ModelBuilders;
using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Infraestructure.Factories
{
    public class FordMustangCreator : Creator
    {
        public override Vehicle Create()
        {
            //using the CarBuilder to create a Ford Mustang with default properties
            return new CarBuilder().Build();
        }
    }
}
