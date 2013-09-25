using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeTransformation.Model
{
    /// <summary>
    /// Questa interfaccia rappresenta un file di codice contenente campi valorizzati
    /// Ogni implementazione dovrà definire come leggere questi campi dal file
    /// e, eventualmente, come scriverli.
    /// </summary>
    public interface FileCode
    {        
        /// <summary>
        /// Sostituisce nel file sorgente(sourcePath) i valori dei campi
        /// e riscrive il file in (destPath). Se destPath è null sovrascrive
        /// il file sorgente
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="destPath"></param>
        void writeFile(string sourcePath, string destPath);

        /// <summary>
        /// Setta i FileItem con quelli presi in input.
        /// </summary>
        /// <param name="items"></param>
        void setItems(FileItem[] items);

        /// <summary>
        /// Setta i FileItem andandoli a leggere dal file passato in input.
        /// </summary>
        /// <param name="filePath"></param>
        void setItems(string filePath);

        /// <summary>
        /// Ritorna i FileItem se sono stati settati in precedenza altrimenti null.
        /// </summary>
        /// <returns></returns>
        FileItem[] getItems();
    }
}
