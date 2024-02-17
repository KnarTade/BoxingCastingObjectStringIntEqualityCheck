using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingCasting
{
    public class Thing
    {
        // initializes the data field with the default value for the object type, which is null
        public object data = default(object);

        public string Process(object input)
        {
            if (data == input)
            {

                return "Data and input are the same";
            }

            else
            {

                return "Data and input are NOT the same";
            }
        }
    }

}
