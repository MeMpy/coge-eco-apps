using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace CodeTransformation.Model
{
    public class PascalFileCode: FileCode
    {
        #region Attributi

        private List<FileItem> pascalInfo;

        #endregion

        #region Constanti

        private const string searchStringPascal = "TGridInfoRec";
        private const string delimiterFieldDefP = ":";

        private const string delimiterLineDefP = ",";
        #endregion

        #region FileCode Interface

        public void writeFile(string sourcePath, string destPath)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Legge il file Pascal cercando il blocco di definizione identificato da TGridInfoRec
        /// all'espressione di chiusura del blocco ");". Elabora poi tale blocco per cercare
        /// di creare una lista di FileItem che dovranno essere poi utilizzate per trasformare
        /// il file C#
        /// </summary>
        public void setItems(string filePath)
        {
            if (!File.Exists(filePath))
            {

                throw new FileNotFoundException("File Pascal non presente in: " + @filePath);

            }

            List<FileItem> pascalInfo = null;
            StreamReader pascalStream = new StreamReader(filePath, Encoding.GetEncoding("iso-8859-1"));
            string line = string.Empty;
            string pascalDefField = string.Empty;
            /*isDef diventa true quando si entra nel blocco di definizione dei campi, false altrimenti
             */
            bool isDef = false;

            /*il ciclo legge il file linea per linea, e memorizza fino a quando si è all'interno della definizione
             * dei campi, ovvero inizia quando individua la parola chiave contenuta in searchStringPascal
             * e termina quando non sono presenti nella linea il delimiterFieldDefP o quando è presente
             * il closeDefCharP. Il trovarsi all'interno del campo di definizione è espresso nella 
             * variabile booleana isDef 
             */
            while ((line = pascalStream.ReadLine()) != null)
            {
                if (line.Contains(searchStringPascal))
                {
                    pascalDefField += line;
                    isDef = true;
                }
                else
                {
                    if (isDef)
                    {
                        pascalDefField += line;


                        if (!line.Contains(delimiterFieldDefP))
                        {
                            isDef = false;
                        }
                    }
                }
            }


            pascalInfo = parsePascalInfo(pascalDefField);

            pascalStream.Close();

            this.pascalInfo = pascalInfo;
        }

        public void setItems(FileItem[] items)
        {
            this.pascalInfo = new List<FileItem>(items);
        }

        public FileItem[] getItems()
        {
            return this.pascalInfo.ToArray();
        }

        #endregion

        #region Private

        #region Lettura file Pascal

        /// <summary>
        /// Dato il blocco di definizione TGridInfoRec il metodo lo splitta
        /// in un array contenente in ogni elemento una riga di definizione di un campo
        /// Ognuno di questi elementi sarà elaborato per creare un oggetto FileItem
        /// </summary>
        /// <param name="pascalDefField"></param>
        /// <returns></returns>
        private List<FileItem> parsePascalInfo(string pascalDefField)
        {
            string[] lineDef = pascalDefField.Split(delimiterLineDefP.ToCharArray());

            List<FileItem> pascalInfoList = new List<FileItem>();
            FileItem pascalInfo;
            foreach (string line in lineDef)
            {
                pascalInfo = createPascalInfo(line);
                pascalInfoList.Add(pascalInfo);
            }

            checkForVisibilityCorrection(pascalInfoList);
            return pascalInfoList;
        }

        /// <summary>
        /// Data una linea del file Pascal, cerca all'interno di essa tramite regular expression
        /// i valori da assegnare all'oggetto FileItem
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private FileItem createPascalInfo(string line)
        {
            List<string> propertyNames = new FileItem().getAttributeNames();
            string patternProperties = string.Empty;
            Match m = null;
            //coppie (attributo, valore attributo in Pascal)
            Dictionary<string, string> fields = new Dictionary<string, string>();

            foreach (string prop in propertyNames)
            {
                patternProperties = @"[\(?\;?]+" + @prop + @".*?[;?\)?]{1}";

                m = Regex.Match(line, patternProperties);
                fields.Add(prop, m.Value);
            }

            string patternFieldValue = @"\" + delimiterFieldDefP + @".*[']|\:\w*";
            string fieldValue = string.Empty;
            FileItem p = new FileItem();
            foreach (KeyValuePair<string, string> pair in fields)
            {
                m = Regex.Match(pair.Value, patternFieldValue);
                if (m.Value.Length > 0)
                {
                    //non è la definizione vuota(la prima nel nostro caso)
                    //considero a partire dal secondo carattere, ovvero escludo :
                    fieldValue = m.Value.Substring(1);
                    //Sostituisco i doppi apici interni alla stringa con l'apice escapeato
                    fieldValue = fieldValue.Replace(@"''", "\'");
                    //cancello gli ventuali apici singoli iniziali e finali della stringa in Pascal
                    int firstApex = fieldValue.IndexOf(@"'");
                    int lastApex = fieldValue.LastIndexOf(@"'");
                    if (firstApex == 0 && (lastApex>firstApex && lastApex == fieldValue.Length - 1))
                        fieldValue = fieldValue.Substring(1, fieldValue.Length - 2);
                    
                }
                else
                {
                    fieldValue = string.Empty;
                }
                p.setValue(pair.Key, fieldValue);
            }


            return p;
        }


        #region Set Visibility

        /// <summary>
        /// Controlla se esistono più item con la stessa label, se si setta visibile
        /// solo quello con label terminante con "LIB" o in caso di ambiguità 
        /// quella con indice minore.
        /// </summary>
        /// <param name="pascalInfoList"></param>
        private void checkForVisibilityCorrection(List<FileItem> pascalInfoList)
        {
            List<List<FileItem>> pascalInfoListGroupedByLabel = groupListByLabel(pascalInfoList);

            if (pascalInfoListGroupedByLabel.Count == 0)
            {
                //Tutte label diverse
                return;
            }

            foreach (List<FileItem> itemsEquals in pascalInfoListGroupedByLabel)
            {

                setVisibility(itemsEquals);
            }

        }

        private void setVisibility(List<FileItem> itemsEquals)
        {
            List<FileItem> fileItemLIB = new List<FileItem>();
            foreach (FileItem item in itemsEquals)
            {
                item.setVisLib(false);

                if(item.Name.EndsWith("LIB"))
                    fileItemLIB.Add(item);
            }

            if (fileItemLIB.Count > 1)
            {
                setMinGridPosAsVisible(fileItemLIB);

            }
            else
            {
                if (fileItemLIB.Count == 1)
                {//Solo un elemento termina con LIB
                    fileItemLIB[0].setVisLib(true);                    
                }
                else
                {
                    //Nessun elemento termina con LIB                    
                    setMinGridPosAsVisible(itemsEquals);
                }
            }
        }

        private List<List<FileItem>> groupListByLabel(List<FileItem> pascalInfoList)
        {
            IOrderedEnumerable<FileItem> orderedFileItems = pascalInfoList.OrderBy<FileItem, string>((item) => { return item.ShortLibel; });
            List<List<FileItem>> listGrouped = new List<List<FileItem>>();

            FileItem prev = null;
            List<FileItem> group = new List<FileItem>();
            foreach (FileItem item in orderedFileItems)
            {
                if (prev != null && item.ShortLibel.Equals(prev.ShortLibel))
                {
                    group.Add(prev);
                }
                else
                {
                    if (prev != null)
                    {//Fine gruppo
                        group.Add(prev);
                        if(group.Count>1)
                            listGrouped.Add(group);
                        group = new List<FileItem>();
                    }
                }

                prev = item;
            }
            //Agiunta ultimo gruppo
            if (prev != null)
            {//Fine gruppo
                group.Add(prev);
                if (group.Count > 1)
                    listGrouped.Add(group);
            }

            return listGrouped;
        }

        private static void setMinGridPosAsVisible(List<FileItem> fileItems)
        {
            //piu di un elemento termina con Lib
            IOrderedEnumerable<FileItem> orderedFileItems = fileItems.OrderBy<FileItem, int>((item) => { return Convert.ToInt32(item.GridPos); });
            for (int i = 0; i < orderedFileItems.Count(); i++)
            {
                orderedFileItems.ElementAt(i).setVisLib(i == 0);
            }
        }

        #endregion

        
        #endregion

        #endregion


    }
}
