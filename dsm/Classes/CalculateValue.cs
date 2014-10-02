using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsm
{
    public class CalculateValue
    {
        // Show warning if its true
        private bool warning;

        // Alles met 1 is links
        // Alles met 2 is rechts
        private String string1;
        private String string2;

        private bool stringBool1;
        private bool stringBool2;

        private double double1;
        private int integer1;

        private double double2;
        private int integer2;

        private int modValue; // 0 = +, 1 = -, 2 = /, 3 = *

        private double outputDouble;
        private int outputInteger;

        /// <summary>
        /// Checkt of string1 en string2 doubles zijn.
        /// Als beide true zijn wordt outputDouble berekend.
        /// </summary>
        /// <returns>Als stringBool1 true is en stringBool2 true is return outputDouble</returns>
        public double calcDouble()
        {
            stringBool1 = checkString(string1);
            stringBool2 = checkString(string2);

            if (stringBool1 == true && stringBool2 == true)
            {
                if (modValue == 0) { outputDouble = double1 + double2; }
                if (modValue == 1) { outputDouble = double1 - double2; }
                if (modValue == 2) { outputDouble = double1 / double2; }
                if (modValue == 3) { outputDouble = double1 * double2; }
                this.warning = false;
                return outputDouble;
            }
            else
            {
                this.warning = true;
                outputDouble = 0.0;
                return outputDouble;
            }
        }

        /// <summary>
        /// Checkt of string1 en string2 doubles zijn.
        /// Als beide false zijn wordt outputDouble berekend.
        /// </summary>
        /// <returns>Als stringBool1 false is en stringBool2 false is return outputDouble</returns>
        public int calcInteger()
        {
            stringBool1 = checkString(string1);
            stringBool2 = checkString(string2);
            if (stringBool1 == false && stringBool2 == false)
            {
                if (modValue == 0) { outputInteger = integer1 + integer2; }
                if (modValue == 1) { outputInteger = integer1 - integer2; }
                if (modValue == 2) { outputInteger = integer1 / integer2; }
                if (modValue == 3) { outputInteger = integer1 * integer2; }
                this.warning = false;
                return outputInteger;
            }
            else
            {
                this.warning = true;
                outputInteger = 0;
                return outputInteger;
            }
        }

        /// <summary>
        /// Checkt of stringValue een double is.
        /// </summary>
        /// <param name="stringValue"></param>
        /// <returns>Return true als stringValue een double is.</returns>
        public bool checkString(String stringValue)
        {
            if(stringValue != null)
            {
                for(int i = 0; i < stringValue.Length; i++)
                {
                    String x = Convert.ToString(stringValue[i]);
                    if (x == ",")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Als warning true is wordt een fout melding returned.
        /// </summary>
        /// <returns></returns>
        public string warningMessage()
        {          
            if (warning)
            {
                return "Gegeven types zijn niet gelijk aan elkaar, Let op de comma";
            }
            else
            {
                return "Succesvolle berekening";
            }
        }

        //-------------------
        // Setters
        public void setString1(String stringValue)
        {
            string1 = stringValue;
        }

        public void setString2(String stringValue)
        {
            string2 = stringValue;
        }

        public void setDouble1(double newDouble)
        {
            double1 = newDouble;
        }

        public void setInteger1(int newInteger)
        {
            integer1 = newInteger;
        }

        public void setDouble2(double newDouble)
        {
            double2 = newDouble;
        }

        public void setInteger2(int newInteger)
        {
            integer2 = newInteger;
        }

        public void setModifier(int newValue)
        {
            modValue = newValue;
        }
    }
}
