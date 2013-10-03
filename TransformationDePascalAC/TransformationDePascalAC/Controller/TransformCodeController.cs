using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using CodeTransformation;
using TransformationDePascalAC.Model;
using DrawItems;
using System.Drawing;
using CodeTransformation.Model;
using CodeTransformation.Utils;

namespace TransformationDePascalAC.Controller
{
    /// <summary>
    /// Controller: fa comunicare la libreria CodeTrasformation con l'interfaccia tramite metodi statici
    /// //TODO Potrebbe essere utile memorizzare i vari path per rendere piu facile la chiamata ai metodi
    /// </summary>
    public class TransformCodeController
    {               
    	
    	private static TransformCodeController _instance;
    	
    	private TransformCodeController(){}
    	
    	public static TransformCodeController Instance {
    		get {
    			if (_instance == null )
    				_instance = new TransformCodeController();
    			
    			return _instance;
    		}
    	}

        public List<FileMatched> findMatchesCSharpIntoPascal(string[] filesCSharp, string[] filesPascal)
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
        public FileCode doTransformation(string pascalPath, string cSharpPath, string destPath)
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

                
                return cSharpFile;

            }
            catch (Exception)
            {
                
                return null;
            }
            


        }


    }
}
