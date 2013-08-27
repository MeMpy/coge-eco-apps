using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeTrasformation.model;
using System.IO;
using System.Text.RegularExpressions;

namespace CodeTransformation
{
    public class CSharpFileCode : FileCode
    {
        #region Attributi
        
        private List<FileItem> cSharpInfo;

        #endregion

        #region Constanti

        private const string searchStringC = "new DefBDDFieldAttribute[]";

        private const string closeRegionC = "endregion";

        private const string defaultValueC = "-1";

        private const string fieldPattern = @",?.*?,";

        private const string extractFieldValuePattern = "\".*?\"|[0-9]*";

        #endregion

        #region FileCode Interface

        

        /// <summary>
        /// Il metodo effettua la trasformazione del file C# (sourcePath) inserendo in ogni definizione
        /// di un DefBDDFieldAttribute il valore dell'indice di presentazione 
        /// recuperato dal file Pascal (GridPos) nelle definizioni dei campi. 
        /// Se nel file Pascal la displayWidth vale 0 l'indice di presentazione sarà
        /// settato a -1
        /// Scrive sul file destPath o, se questo è null, sovrascrive il file esistente
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="destPath"></param>
        public void writeFile(string sourcePath, string destPath)
        {
            if (!File.Exists(sourcePath))
            {
                throw new FileNotFoundException(@"File C# non presente in: " + @sourcePath);
            }

            StreamReader cStream = new StreamReader(sourcePath);
            string line = string.Empty;
            string cDefField = string.Empty;
            /*isDef diventa true quando si entra nel blocco di definizione dei campi, false altrimenti
             */
            bool isDef = false;
            bool trasformationDone = false;

            /*il ciclo legge il file linea per linea, e memorizza fino a quando si è all'interno della definizione
             * dei campi, ovvero inizia quando individua la parola chiave contenuta in searchStringC
             */
            StringBuilder newFile = new StringBuilder();
            while ((line = cStream.ReadLine()) != null)
            {
                //Se non abbiamo ancora effettuato la trasformazione dobbiamo cercare il blocco di definizione campi
                if (!trasformationDone)
                {

                    if (!isDef)
                    {
                        //Se il blocco di definizione non è stato ancora trovato cerchiamolo nella linea corrente
                        if (line.Contains(searchStringC))
                        {
                            isDef = true;
                        }

                    }
                    else //Se siamo nel blocco
                    {

                        if (line.Contains(closeRegionC))
                        {
                            isDef = false;
                            trasformationDone = true;
                        }
                        else
                        {
                            line = substituteValue(line, cSharpInfo);

                        }
                    }

                }

                //Scrivi il file linea per linea all'interno dello StringBuilder
                newFile.Append(line);
                newFile.Append(Environment.NewLine);

            }

            cStream.Close();

            if (destPath != null)
            {
                StreamWriter sf = new StreamWriter(destPath);
                sf.WriteLine(newFile);
                sf.Close();
            }
            else
            {
                StreamWriter sf = new StreamWriter(sourcePath);
                sf.WriteLine(newFile);
                sf.Close();
            }
        }
        
        public void setItems(FileItem[] items)
        {
            this.cSharpInfo = new List<FileItem>(items);
        }

        /// <summary>
        /// Utilizzato per generazione automatica di GUI
        /// </summary>
        /// <param name="filePath"></param>
        public void setItems(string filePath)
        {                      
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(@"File C# non presente in: " + filePath);
            }

            StreamReader cStream = new StreamReader(filePath);
            string line = string.Empty;
            string cDefField = string.Empty;
            /*isDef diventa true quando si entra nel blocco di definizione dei campi, false altrimenti
             */
            bool isDef = false;
            bool trasformationDone = false;

            /*il ciclo legge il file linea per linea, e memorizza fino a quando si è all'interno della definizione
             * dei campi, ovvero inizia quando individua la parola chiave contenuta in searchStringC
             */

            while ((line = cStream.ReadLine()) != null)
            {
                //Se non abbiamo ancora effettuato la trasformazione dobbiamo cercare il blocco di definizione campi
                if (!trasformationDone)
                {

                    if (!isDef)
                    {
                        //Se il blocco di definizione non è stato ancora trovato cerchiamolo nella linea corrente
                        if (line.Contains(searchStringC))
                        {
                            isDef = true;
                        }

                    }
                    else //Se siamo nel blocco
                    {

                        if (line.Contains(closeRegionC))
                        {
                            isDef = false;
                            trasformationDone = true;
                        }
                        else
                        {
                            parseItem(line);

                        }
                    }

                }


            }
        }       

        public FileItem[] getItems()
        {
            return this.cSharpInfo.ToArray();
        }

        #endregion

        #region Private

        #region Lettura Items da file C#

        /// <summary>
        /// Valorizza l'attributo cSharpInfo leggendo i valori dalla line
        /// </summary>
        /// <param name="line"></param>
        private void parseItem(string line)
        {
            FileItem fileItem = null;

            MatchCollection m = Regex.Matches(line, fieldPattern);

            if (m.Count >= 10)
            {
                fileItem = createFileItem(line, m);
                if (cSharpInfo == null)
                {
                    cSharpInfo = new List<FileItem>();
                }

                cSharpInfo.Add(fileItem);

            }


        }

        private FileItem createFileItem(string line, MatchCollection matches)
        {
            string extractFieldValuePattern = "\".*?\"|\\d+";
            string name = Regex.Match(matches[0].Value, extractFieldValuePattern).Value;
            string shortLibel = Regex.Match(matches[2].Value, extractFieldValuePattern).Value;
            string gridPos = Regex.Match(matches[9].Value, extractFieldValuePattern).Value;
            string displayWidth = Regex.Match(matches[10].Value, extractFieldValuePattern).Value;

            return new FileItem(name.Substring(1, name.Length - 2), shortLibel.Substring(1, shortLibel.Length - 2), gridPos, displayWidth);
        }

        #endregion

        #region Scrittura File C#
        /// <summary>
        /// Individua il campo da sostituire scorrendo pascalInfoList
        /// e cercando il valore di Name all'interno della linea.
        /// Se trova il campo effettua la sostituzione altrimenti 
        /// ritorna la linea non modificata.
        /// </summary>
        private string substituteValue(string line, List<FileItem> pascalInfoList)
        {
            int startPointToRead = 0;
            string pattern = string.Empty;
            bool notFound = true;
            FileItem p = null;
            for (int i = 0; i < pascalInfoList.Count && notFound; i++)
            {
                p = pascalInfoList[i];
                pattern = "\"" + @p.Name + "\"";
                startPointToRead = line.IndexOf(pattern);
                //Trovato il campo da modificare
                if (startPointToRead > 0)
                {
                    notFound = false;
                    line = createNewLine(line, startPointToRead, p);
                }
            }

            return line;
        }

        /// <summary>
        /// la creazione del nuovo file avviene linea per linea effettuando l' aggiornamento dei dati 
        /// nelle linee appartenenti al blocco di definizione. Il valore da aggiornare è individuato
        /// contando gli argomenti passati. Il decimo dovrà essere trasformato
        ///
        /// </summary>
        private string createNewLine(string line, int startPointToRead, CodeTrasformation.model.FileItem p)
        {

            int countVirgule = 0;
            StringBuilder newLine = new StringBuilder(line.Substring(0, startPointToRead));
            string newValue = string.Empty;
            int indexSecVirg = 0;
            for (int i = startPointToRead; i < line.Length; i++)
            {
                newLine.Append(line[i]);
                if (line[i].Equals(','))
                {
                    countVirgule++;
                    //raggiunta una virgola si sovrascrive il valore del file originario se necessario
                    //ovvero si scrive il nuovo valore e si riprende la lettura della riga originaria 
                    //a partire dalla virgola successiva   
                    newValue = generateNewValue(p, countVirgule);
                    if (!string.IsNullOrEmpty(newValue))
                    {
                        newLine.Append(newValue);

                        //spostiamo l'indice alla fine del campo sostituito
                        indexSecVirg = line.Substring(i + 1).IndexOf(",");
                        i = i + indexSecVirg;
                    }

                }

            }
            return newLine.ToString();
        }


        /// <summary>
        /// Genera il nuovo valore da inserire nel file C# controllando le FileItem e
        /// la posizione in cui stiamo inserendo
        /// </summary>
        private string generateNewValue(FileItem p, int countVirgule)
        {
            switch (countVirgule)
            {
                case 2:
                    //Stiamo inserendo la shortLibel
                    return " \"" + p.ShortLibel + "\"";
                case 9:
                    //Stiamo sostituendo l'indice di presentazione (GridPos in pascal), con l'accorgimento
                    //che se il valore di DisplayWidth = 0 o per qualche altra ragione l'attributo
                    //è settato come invisibile allora GridPos=-1 indipendentemente
                    //dal valore di GridPos del file Pascal corrispondente
                    if (p.DisplayWidth.Equals("0") || !p.isVisibile())
                    {
                        return " " + defaultValueC;
                    }
                    else
                    {
                        return " " + p.GridPos;
                    }
                case 4:
                    //stiamo settando la visibilità
                    return " " + p.isVisibile().ToString().ToLower();
                default:
                    return string.Empty;
            }
        }

        #endregion


        #endregion
    }
}
