using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace CSVTools
{
    public class CSVData
    {
        public List<List<string>> content = new List<List<string>> {};
        public void CSVParse(string path)
        {
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine() + ",";
            while (line != ",")
            {
                List<string> CSVLine = new List<string> { };
                string buffer = "";
                foreach (char check in line)
                {
                    if (check == ',')
                    {
                        CSVLine.Add(buffer);
                        buffer = "";
                    }
                    else
                    {
                        buffer += check;
                    }
                }

                content.Add(CSVLine);
                line = sr.ReadLine() + ",";
            }
            sr.Close();
        }

        public string StringConv()
        {
            string result = "";
            foreach (List<string> line in content)
            {
                foreach (string item in line)
                {
                    result += item + "       ";
                }

                result += "\n";
            }

            return result;
        }

        public void Sort(int index)
        {
            if (Regex.IsMatch(content[1][index], "^[0-9]*[.][0-9]*$") || Regex.IsMatch(content[1][index], "^[0-9]"))
            {
                NumericSort(index);
            }
            else
            {
                AlphaSort(index);
            }
        }

        private void AlphaSort(int index)
        {
            
        }

        private void NumericSort(int index)
        {
            int len = content.Count;
            List<String> temp;
            for (int i = 0; i < len; i++)
            {
                int nel = len - (i + 1);
                for (int j = 0; j < nel; j++)
                {
                    if (float.Parse(content[j][index]) > float.Parse(content[j+1][index]))
                    {
                        temp = content[j + 1];
                        content[j + 1] = content[j];
                        content[j] = temp;
                    }
                }
            }
        }
    }


    class Program
    {
        public static void Main()
        {
            Console.Write("enter path of CSV file \n=>");
            string path = Console.ReadLine();
            CSVData file = new CSVData();
            file.CSVParse(path);
            Console.WriteLine(file.StringConv());
            Console.WriteLine("#################################");
            file.Sort(1);
            Console.WriteLine(file.StringConv());
        }
    }
}