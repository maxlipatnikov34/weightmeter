using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _1712WeightMeter
{

    static class ManipulationClass
    {
        public static void AddManToListOfMan(Man man)
        {
            DataClass.listOfMan.Add(man);
            DataClass.listViewOfMan.Items.Add(man.Name);
        }
        public static void RemoveManFromList(int index)
        {
            DataClass.listOfMan.RemoveAt(index);
            DataClass.listViewOfMan.Items.RemoveAt(index);
        }
        public static void AddWeightInfo(Man man, string value, string comment)
        {
            man.listOfWeight.Add(new WeightData(double.Parse(value), DateTime.Now, comment));
            string[] row = { man.listOfWeight[man.listOfWeight.Count - 1].weightValue.ToString(), man.listOfWeight[man.listOfWeight.Count - 1].weightDate.ToString(), comment };
            ListViewItem item1 = new ListViewItem(row[0]);
            item1.SubItems.Add(row[1]);
            item1.SubItems.Add(row[2]);
            DataClass.listViewofWeight.Items.Add(item1);

        }
        public static void AddWeightInfo(Man man, string value, string date, string comment)
        {
            man.listOfWeight.Add(new WeightData(double.Parse(value), DateTime.Parse(date), comment));
        }
        public static void LoadDataFromFile()
        {
            try
            {
                string[] inputString = File.ReadAllLines("listOfMan.txt");
                for (int i = 0; i < inputString.Length; i++)
                {
                    Console.WriteLine(inputString[i]);
                    ManipulationClass.AddManToListOfMan(new Man(inputString[i]));
                }

            }
            catch { }
        }

        public static void SaveManToFile()
        {
            FileStream fl = File.Open("listOfMan.txt", FileMode.Truncate);
            for (int i = 0; i < DataClass.listOfMan.Count; i++)
            {
                byte[] output = Encoding.UTF8.GetBytes(DataClass.listOfMan[i].Name);
                for (int k = 0; k < output.Length; k++)
                {
                    fl.WriteByte(output[k]);
                }
                if (i + 1 != DataClass.listOfMan.Count)
                {
                    fl.WriteByte(Encoding.UTF8.GetBytes("\r\n")[0]);
                }
                else
                {

                }
            }
        }

        public static void SaveManToFileFull()
        {
            FileStream fl = File.Open("listOfMan.txt", FileMode.Truncate);
            for (int i = 0; i < DataClass.listOfMan.Count; i++)
            {
                byte[] output = Encoding.UTF8.GetBytes(DataClass.listOfMan[i].Name);
                for (int k = 0; k < output.Length; k++)
                {
                    fl.WriteByte(output[k]);
                }
                if (i + 1 != DataClass.listOfMan.Count)
                {
                    fl.WriteByte(Encoding.UTF8.GetBytes("\r\n")[0]);
                }
                else
                {

                }
            }
            fl.Close();
        }
        public static void SaveWeightsToFileFull()
        {
            FileStream fl = File.Open("listOfWeights.txt", FileMode.Truncate);
            for (int i = 0; i < DataClass.listOfMan.Count; i++)
            {
                for (int m = 0; m < DataClass.listOfMan[i].listOfWeight.Count; m++)
                {
                    byte[] outputV = Encoding.UTF8.GetBytes(DataClass.listOfMan[i].listOfWeight[m].weightValue.ToString());
                    byte[] outputD = Encoding.UTF8.GetBytes(DataClass.listOfMan[i].listOfWeight[m].weightDate.ToString());
                    byte[] outputC = Encoding.UTF8.GetBytes(DataClass.listOfMan[i].listOfWeight[m].Comment);
                    for (int k = 0; k < outputV.Length; k++)
                    {
                        fl.WriteByte(outputV[k]);
                    }
                    fl.WriteByte(Encoding.UTF8.GetBytes("|")[0]);
                    for (int k = 0; k < outputD.Length; k++)
                    {
                        fl.WriteByte(outputD[k]);
                    }
                    fl.WriteByte(Encoding.UTF8.GetBytes("|")[0]);
                    for (int k = 0; k < outputC.Length; k++)
                    {
                        fl.WriteByte(outputC[k]);
                    }
                    if (m + 1 != DataClass.listOfMan[i].listOfWeight.Count)
                        fl.WriteByte(Encoding.UTF8.GetBytes("|")[0]);

                }
                if (i + 1 != DataClass.listOfMan.Count)
                {
                    fl.WriteByte(Encoding.UTF8.GetBytes("\r\n")[0]);
                }
                else
                {

                }
            }
            fl.Close();
        }
        public static void LoadWeightsFromFile()
        {
            //try{
            string[] inputString = File.ReadAllLines("listOfWeights.txt");
            char[] separator = { '|' };
            for (int i = 0; i < inputString.Length; i++)
            {
                string[] inputSplitted = inputString[i].Split(separator[0]);
                Console.WriteLine(inputString[i]);
                Console.WriteLine(string.Join(" ", inputSplitted));
                for (int k = 0; k < inputSplitted.Length; k += 3)
                    ManipulationClass.AddWeightInfo(DataClass.listOfMan[i], inputSplitted[k], inputSplitted[k + 1], inputSplitted[k + 2]);
            }

            //} catch { }
        }
    }
}