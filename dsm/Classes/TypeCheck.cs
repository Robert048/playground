using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsm
{
    class TypeCheck
    {
        private double doubleWaarde;
        private int intWaarde;
        private DateTime dateWaarde;
        private bool? boolWaarde;

        public TypeCheck()
        {
            boolWaarde = null;
        }


        // ALLE CONSOLE.WRITELINE LATER VERWIJDEREN?!
        public void typeCheck(String check)
        {
            // Controleren of de waarde een double kan worden
            try
            {
                doubleWaarde = Convert.ToDouble(check);
                Console.WriteLine("double gemaakt");
            }
            catch (FormatException)
            {
                Console.WriteLine("double niet gemaakt");
            }

            // Controleren of de waarde een int kan worden
            try
            {
                intWaarde = Convert.ToInt32(check);
                Console.WriteLine("int gemaakt");
            }
            catch (FormatException)
            {
                Console.WriteLine("int niet gemaakt");
            }

            // Controleren of de waarde een datum is
            // wtf?....
            try
            {
                dateWaarde = Convert.ToDateTime(check);
                Console.WriteLine("datum gemaakt");
            }
            catch (FormatException e)
            {
                Console.WriteLine("datum niet gemaakt | " + e.Message);
            }

            // Controleren of de waarde een bool is of niet
            String boolCheck = check.ToLower().Trim();
            if(boolCheck.Equals("true") || boolCheck.Equals("false"))
            {
                boolWaarde = Convert.ToBoolean(boolCheck);
                Console.WriteLine("bool gemaakt");
            }

            Console.WriteLine(doubleWaarde);
            Console.WriteLine(intWaarde);
            Console.WriteLine(dateWaarde);
            Console.WriteLine(boolWaarde);
        }

        public double getDouble()
        {
            return doubleWaarde;
        }

        public int getInteger()
        {
            return intWaarde;
        }

        public DateTime getDateTime()
        {
            return dateWaarde;
        }

        public bool? getBoolean()
        {
            return boolWaarde;
        }
    }
}
