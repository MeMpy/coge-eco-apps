using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TransformationDePascalAC.Model
{
    public class FileMatched
    {

        private string fullPathPascalFile;

        public string FullPathPascalFile
        {
            get { return fullPathPascalFile; }
            set { fullPathPascalFile = value; }
        }

        private string fullPathCFile;

        public string FullPathCFile
        {
            get { return fullPathCFile; }
            set { fullPathCFile = value; }
        }

        private bool checkedForTransformation;

        public bool CheckedForTransformation
        {
            get { return checkedForTransformation; }
            set { checkedForTransformation = value; }
        }

        private string filePascalSimpleName;

        public string FilePascalSimpleName
        {
            get { return filePascalSimpleName; }
            set { filePascalSimpleName = value; }
        }
        private string fileCSimpleName;

        public string FileCSimpleName
        {
            get { return fileCSimpleName; }
            set { fileCSimpleName = value; }
        }

        public FileMatched()
        {

        }

        public FileMatched(string fileP, string fileC)
        {
            this.FullPathPascalFile = fileP;
            this.FullPathCFile = fileC;
            this.FilePascalSimpleName = Path.GetFileName(fileP);
            this.fileCSimpleName = Path.GetFileName(fileC);
        }
    }
}
