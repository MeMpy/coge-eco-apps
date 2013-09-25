using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace CodeTransformation.Utils
{
    /// <summary>
    /// Utility per la gestione dei file.
    /// CONTIENE L'ALGORITMO DI RICERCA DELLE CORRISPONDENDE PASCAL C#
    /// </summary>
    public class DiskUtils
    {      
        #region Ricerca Files

        /// <summary>
        /// Effettua una ricerca leggendo su quale vue il file pascal opera (prendendolo dai primi commenti)
        /// e confrontando questa vue con la vue su cui opera il file C# (anche questa letta nei primi commenti)
        /// Il confronto è effettuato come segue:
        /// - 1) Se il nome della vue pascal è contenuto nel nome della vue C# allora trovato altrimenti
        /// - 2) Crea la sottostringa della vue pascal a partire dal prossimo _ (underscore)
        /// - 3) Cerca la sottostringa creata nella vue C# se non trovato torna a 2)
        /// 
        /// NOTA: La vue pascal equivale al nome del file senza uDefBDD_
        ///       La vue C# equivale al nome del file
        /// </summary>
        public static string searchMatchPascalCSharp(string pascalPath, string[] cSharpPaths)
        {
            string pascalVue = readPascalVue(pascalPath);

            string pascalVueSubString = pascalVue;
            int nextStart = 0;
            while (!string.IsNullOrEmpty(pascalVueSubString))
            {

                string cSharpVue = null;
                foreach (string cSharpF in cSharpPaths)
                {
                    cSharpVue = readCSharpVue(cSharpF);
                    if (cSharpVue.Contains(pascalVueSubString))
                        return cSharpF;
                }
                if ((nextStart = pascalVueSubString.IndexOf("_") + 1) > 0)
                    pascalVueSubString = pascalVueSubString.Substring(nextStart);
                else
                    pascalVueSubString = null;
            }
            
            return null;
        }

        #region Private

        private static string readCSharpVue(string cSharpF)
        {
            //string lineToSearch = "/// Identifiants des champs de la vue ";

            return readVue(cSharpF, null);
        }

        private static string readPascalVue(string pascalPath)
        {
            //string lineToSearch = "* @brief Gestion de la vue ";
            string lineToSearch = "uDefBDD_";

            return readVue(pascalPath, lineToSearch);
        }

        private static string readVue(string filePath, string lineToSearch)
        {
            string safeFileName = Path.GetFileNameWithoutExtension(filePath);
            if (!string.IsNullOrEmpty(lineToSearch))
                return safeFileName.Substring(safeFileName.LastIndexOf(lineToSearch)+lineToSearch.Length);
            else
                return safeFileName;
        }

        #endregion

        #endregion

        #region Costruzione Path
        /// <summary>
        /// Costruisce il nuovo path del file.
        /// Il nuovo path partirà dalla parent folder del file
        /// passato in input (path), creerà la cartella dirName
        /// e nominera il file con lo stesso nome.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="dirName"></param>
        /// <returns></returns>
        public static string getPathFileIntoParentFolder(string path, string dirName)
        {
            string dirPath = Path.GetDirectoryName(Path.GetDirectoryName(path));
            string trasformedDir = Path.Combine(dirPath, dirName);
            Directory.CreateDirectory(trasformedDir);
            string trasformedFileName = Path.GetFileName(path);
            string trasformedPath = Path.Combine(trasformedDir, trasformedFileName);

            return trasformedPath;
        }

        #endregion

        #region Deprecated
        /// <summary>
        /// Ricerca il fileSearched (path) nell'array filesIntoSearch (contenente i path dei file).
        /// La ricerca avviene per corrispondenza nomeFile, ossia il nome senza estensione di fileSearched
        /// deve corrispondere ad un file name dell'array filesIntoSearch.
        /// 
        /// Verrà ritornata la prima occorrenza valida.
        /// </summary>
        /// <param name="filesSearched">path completo del file da cercare</param>
        /// <param name="filesIntoSearch">array di path completi in cui cercare la corrispondenza</param>
        /// <param name="extension">estensione del file SENZA punto</param>
        /// <returns>path completo del file trovato, altrimenti stringa vuota</returns>
        [Obsolete("Algoritmo Inefficace", true)]
        public static string searchFileSameName(string filesSearched, string[] filesIntoSearch, string extension)
        {
            bool notFound = true;
            string fileSimpleName = string.Empty;
            string nameToSearch = string.Empty;
            string fileNameFound = string.Empty;

            //la ricerca avviene per corrispondenza nome file without extension e aggiungendo l'estensione .pas
            fileSimpleName = Path.GetFileNameWithoutExtension(filesSearched);
            nameToSearch = fileSimpleName + @"." + extension + @"\b";
            notFound = true;
            for (int i = 0; i < filesIntoSearch.Length && notFound; i++)
            {

                if (Regex.IsMatch(filesIntoSearch[i], nameToSearch))
                {
                    //se i files matchano per nome la coppia di files in match popola la gridView
                    fileNameFound = filesIntoSearch[i]; ;
                    notFound = false;

                }
            }

            return fileNameFound;
        }

        #endregion

    }
}
