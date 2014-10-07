using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace dsm
{
    //laad afbeeldingen in
    class ReaderWriter
    {
        readonly string folderPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Playground";
        
        public List<string> getImages()
        {
            checkFolder();
            List<string> images = new List<string>();
            foreach (string path in Directory.GetFiles(folderPath)) {
                if (path.Substring(path.Length - 3, 3).Equals("png") || path.Substring(path.Length - 3, 3).Equals("jpg")) {
                    images.Add(path);
                }
            }
            return images;
        }

        private void createFolder()
        {
            Directory.CreateDirectory(folderPath);
        }

        private void checkFolder()
        {
            if (!Directory.Exists(folderPath)) {
                createFolder();
            }
        }

        public void addImage(string fileName)
        {
            checkFolder();
            File.Copy(fileName, folderPath + fileName.Substring(fileName.LastIndexOf(@"\"), fileName.Length - fileName.LastIndexOf(@"\")));
        }

        public void removeImage(string imageName)
        {
            checkFolder();
            throw new NotImplementedException();
        }
    }
}
