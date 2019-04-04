using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scalarFunctionProject
{
    class function
    {
        //public string definition;
        public string name;
        public int numArguments;
        public string[] dataTypes;
        // public string returnType;


        public function( string name, int numArguments, string[] dataTypes)
        {
           // this.definition = definition;
            this.name = name;
            this.numArguments = numArguments;
            this.dataTypes = dataTypes;
            //this.returnType = returnType;

        }
        public void writeFunction()
        {

        }
        public void readFunction(string name)
        {

        }
    }
}
