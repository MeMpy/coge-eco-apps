using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DrawItems
{

    /// <summary>
    /// Interfaccia che definisce un oggetto da disegnare.
    /// 
    /// Ogni classe che la estende dovrà implementare il metodo writeCode()
    /// che servirà a generare il codice sorgente che servirà a disegnare 
    /// l'oggetto sulla GUI
    /// 
    /// Per disegnare un oggetto sono necessari i seguenti passi:
    /// 1-creare l'oggetto drawItem di base(LabelItem, TextItam...) e il layout di base(LayoutTableItem...)
    /// 2-[opzionale]decorare l'oggetto base utilizzando i decorators(FontStyleDecorator...)
    /// 3-decorare l'oggetto drawItem con un decorator di Layout(LabelTextPositionLayoutDecorator...)
    /// </summary>
    public interface DrawItem
    {
       
        /// <summary>
        /// Ritorna una stringa contenente il codice sorgente che disegnerà
        /// il componente inizializzato con i valori immessi in quest'oggetto.
        /// </summary>
        /// <returns></returns>
        string writeCode();


        /// <summary>
        /// Ritorna l' id dell'item. Tale id deve essere il nome della
        /// la variabile nel codice generato da writeCode.
        /// Sarà utilizzato dai decoratori per scrivere il codice che aggiunge
        /// funzionalità all'item.
        /// </summary>
        /// <returns></returns>
        string getItemName();

    }
}
