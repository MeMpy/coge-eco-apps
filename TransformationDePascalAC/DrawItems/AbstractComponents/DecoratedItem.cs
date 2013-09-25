using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawItems.AbstractComponents
{
    public abstract class DecoratedItem : DrawItem
    {

        private List<DrawItem> itemsToDraw;

        /// <summary>
        /// Setta la lista degli item da decorare
        /// </summary>
        /// <param name="items"></param>
        public void setItem(params DrawItem[] items)
        {
            if (itemsToDraw == null)
            {
                itemsToDraw = new List<DrawItem>();
            }

            if (items != null)
            {
                foreach (DrawItem item in items)
                {
                    itemsToDraw.Add(item);
                }
            }
        }

        /// <summary>
        /// Restituisce il primo item da decorare se c'è altrimeni null.
        /// Utile dato che i decoratori spesso agiscono su item singoli
        /// </summary>
        /// <returns></returns>
        public DrawItem getItem()
        {
            if (itemsToDraw != null)
            {
                return itemsToDraw.First();
            }
            else
            {
                return null;
            }

        }

        /// <summary>
        /// Ritorna l'array degli item da decorare
        /// </summary>
        /// <returns></returns>
        public DrawItem[] getItems()
        {
            if (itemsToDraw != null)
            {
                return itemsToDraw.ToArray();
            }
            else
            {
                return null;
            }

        }

        /// <summary>
        /// Ritorna il codice generato per ogni elemento decorato
        /// </summary>
        /// <returns></returns>
        public virtual string writeCode()
        {
            StringBuilder code = new StringBuilder();
            if (itemsToDraw != null)
            {
                foreach (DrawItem item in itemsToDraw)
                {
                    code.AppendLine(item.writeCode());
                }
            }

            return code.ToString();
        }

        /// <summary>
        /// Ritorna il nome della variabile che mantiene il primo elemento da
        /// decorare
        /// </summary>
        /// <returns></returns>
        public string getItemName()
        {
            DrawItem item = this.getItem();
            if (item != null)
            {
                return item.getItemName();
            }
            else
            {
                return null;
            }
        }

       

    }
}
