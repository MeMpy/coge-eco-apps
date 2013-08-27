using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using CodeTransformation;
using TransformationDePascalAC.model;
using CodeTrasformation.model;
using DrawItems;
using System.Drawing;
using DrawItems.Decorator;

namespace TransformationDePascalAC
{
    /// <summary>
    /// Controller: fa comunicare la libreria CodeTrasformation con l'interfaccia tramite metodi statici
    /// //TODO probabilmente inutile puo essere accorpato parte nella libreria parte nell'interfaccia
    /// </summary>
    public class TransformationPascalC
    {               

        public static List<FileMatched> findMatchesCSharpIntoPascal(string[] filesCSharp, string[] filesPascal)
        {
            string fileCSharpFullPath;
            List<FileMatched> filesMatched = new List<FileMatched>();

            foreach (string filePascalFullPath in filesPascal)
            {

                fileCSharpFullPath = DiskUtils.searchMatchPascalCSharp(filePascalFullPath, filesCSharp);
                if (!string.IsNullOrEmpty(fileCSharpFullPath))
                {
                    filesMatched.Add(new FileMatched(filePascalFullPath, fileCSharpFullPath));
                }
            }

            return filesMatched;
        }


        /// <summary>
        /// Effettua la trasformazione del file C sharp aggiornando la definizione dei campi
        /// inserendo l'indice di presentazione preso dal file Pascal.
        /// </summary>
        /// <param name="pascalPath"></param>
        /// <param name="cSharpPath"></param>
        /// <returns></returns>
        public static bool doTransformation(string pascalPath, string cSharpPath, string destPath)
        {
            
            try
            {
                FileCode pascalFile = new PascalFileCode();
                pascalFile.setItems(pascalPath);

                FileCode cSharpFile = new CSharpFileCode();
                cSharpFile.setItems(pascalFile.getItems());

                ////Scrivi in un nuovo file che ha lo stesso nome del fle C# originario e si trova in una cartella 
                ////Trasformed File collocata nella stessa directory della cartella contenente i files da trasformare
                //string trasformedPath = DiskUtils.getPathFileIntoParentFolder(cSharpPath, "Transformed File");

                cSharpFile.writeFile(cSharpPath, destPath);

                return true;

            }
            catch (Exception)
            {
                
                return false;
            }
            


        }


    }
}
