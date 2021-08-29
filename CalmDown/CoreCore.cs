using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CalmDown
{
    public static class CoreCore
    {
        public static String getRandomPath(String dir)
        {
            String results = "";
            try
            {
                string[] files = Directory.GetFiles(dir, "*.*", SearchOption.TopDirectoryOnly);

                if (files.Length > 0)
                {
                    //testLabel.Content = files[0];

                    Random r = new Random();
                    results = files[r.Next(0, files.Length)];
                }
            }
            catch (Exception er)
            {
                results = "";
            }
            return results;
        }
    }
}
