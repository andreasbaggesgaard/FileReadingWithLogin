using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace csharp3rdHandin
{
    public class FileUtility
    {
        public static void WriteFile(ArrayList a, string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, a);
                fs.Close();
            }         
        }

        public static ArrayList ReadFile(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                ArrayList a = (ArrayList)bf.Deserialize(fs);
                fs.Close();

                return a;
            }                     
              
        }
    }
}