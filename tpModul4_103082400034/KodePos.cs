using System;
using System.Collections.Generic;
using System.Text;

namespace tpModul4_103082400034
{
    internal class KodePos
    {
        public static string getKodePos(string namaKelurahan)
        {

            string[] kelurahan = new string[]
        {
            "Batununggal",
            "Kujangsari",
            "Mengger",
            "Wates",
            "Cijaura",
            "Jatisari",
            "Margasari",
            "Sekejati",
            "Kebonwaru",
            "Maleer",
            "Samoja"
        };

            
            string[] kodePos = new string[]
            {
            "40266",
            "40287",
            "40267",
            "40256",
            "40287",
            "40286",
            "40286",
            "40286",
            "40272",
            "40274",
            "40273"
            };

            
            string inputBersih = namaKelurahan.Trim().ToLower();

            
            for (int i = 0; i < kelurahan.Length; i++)
            {
                
                if (kelurahan[i].ToLower() == inputBersih)
                {
                    
                    return $"{kelurahan[i]} {kodePos[i]}";
                }
            }

            
            return "Data tidak ditemukan";


        }

        public static void getKodePos()
        {

            string[] kelurahan = new string[]
        {
            "Batununggal",
            "Kujangsari",
            "Mengger",
            "Wates",
            "Cijaura",
            "Jatisari",
            "Margasari",
            "Sekejati",
            "Kebonwaru",
            "Maleer",
            "Samoja"
        };


            string[] kodePos = new string[]
            {
            "40266",
            "40287",
            "40267",
            "40256",
            "40287",
            "40286",
            "40286",
            "40286",
            "40272",
            "40274",
            "40273"
            };


            


            for (int i = 0; i < kelurahan.Length; i++)
            {

                Console.WriteLine("Kelurahan : "+kelurahan[i]);
                Console.WriteLine("Kode Pos : " + kodePos[i]);
            }


            


        }
    }


    
    
}
