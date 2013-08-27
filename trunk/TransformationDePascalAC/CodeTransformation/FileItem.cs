using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace CodeTrasformation.model
{
    /// <summary>
    /// classe con attributi=campi definizione Pascal
    /// </summary>
    public class FileItem
    {
        /// <summary>
        /// In Pascal corrisponde a Name, in C# al primo (1) elemento immesso
        /// </summary>
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
  
        /// <summary>
        /// In pascal corrisponde a shortLibel, in C# corrisponde al terzo(3) elemento immesso
        /// </summary>
        private string shortLabel;

        public string ShortLibel
        {
            get { return shortLabel; }
            set { shortLabel = value; }
        }
        

        /// <summary>
        /// In pascal corrisponde a GridPos, in C# al Nono (9) elemento immesso
        /// </summary>
        private string gridPos;

        public string GridPos
        {
            get { return gridPos; }
            set { gridPos = value; }
        }

        /// <summary>
        /// In pascal corrisponde a DisplayWidth, in C# al Nono (10) elemento immesso
        /// </summary>
        private string displayWidth;

        public string DisplayWidth
        {
            get { return displayWidth; }
            set { displayWidth = value; }
        }
        
        /// <summary>
        /// Flag per la disambiguazione di visibilita in caso di label uguali
        /// è visibile solo quella terminante per LIB
        /// Se la flag è true vuol dire che siamo in presenza di un item che ha una label
        /// uguale ad altri item di questo file pascal ma la sua label termina con LIB
        /// quindi è l'unico visibile
        /// Se è false siamo in presenza di un item che ha una label uguale ad altri ma 
        /// non termina con LIB
        /// Se è null la visibilità viene calcolata diversamente @<see cref="isVisibile"/>
        /// </summary>
        private bool? visLib = null;


        public FileItem()
        {

        }

        public FileItem(string name, string shortLibel, string gridPos, string displayWidth)
        {
            this.name = name;
            this.shortLabel = shortLibel;
            this.gridPos = gridPos;
            this.displayWidth = displayWidth;
        }
        

        public List<string> getAttributeNames()
        {
            PropertyInfo[] properties = this.GetType().GetProperties();
            List<string> propertyNames = new List<string>();
            
            foreach (PropertyInfo p in properties)
            {
                propertyNames.Add(p.Name);
            }

            return propertyNames;
        }

        /// <summary>
        /// Setta il valore della property key 
        /// con il valore value.
        /// Se value è null setta stringa vuota.
        /// 
        /// NB: key deve corrispondere al nome della proprietà (ossia al nome del
        /// metodo accessorio)
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void setValue(string key, string value)
        {
            if (key != null)
            {
                PropertyInfo prop = this.GetType().GetProperty(key);
                if (value == null)
                {
                    value = string.Empty;
                }
                prop.SetValue(this, value, null);
            }
            
            

        }

        
        public override string ToString()
        {
            string print = string.Empty;
            print += "Name: " + this.Name;
            print += " ShortLibel: " + this.ShortLibel;
            print += " GridPos: " + this.GridPos;
            print += " Display: " + this.DisplayWidth;

            return print;
        }



        public bool isVisibile()
        {
            if (visLib == null)
                return !(Convert.ToInt32(this.displayWidth) == 0 ||
                                IsAllUpper(this.shortLabel));
            else
                return visLib.Value;
        }        

        private bool IsAllUpper(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]) && !Char.IsUpper(input[i]))
                    return false;
            }
            return true;
        }

        public void setVisLib(bool value)
        {
            this.visLib = value;
        }
    }
}
