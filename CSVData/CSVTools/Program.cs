using System;
using System.Collections.Generic;
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
        public void AlphaSort(int index)
        {
            List<List<int>> strVals = new List<List<int>> { };
            foreach (List<string> step in content)
            {
                char[] compare = step[index].ToCharArray();
                int len = compare.Length;
                List<int> strValsStep = new List<int> { };
                for (int i = 0; i < len; i++)
                {
                    if (compare[i] == ' ')
                    {
                        i++;
                    }
                    else if (compare[i] == 'A') { strValsStep.Add(00); }
                    else if (compare[i] == 'a') { strValsStep.Add(01); }
                    else if (compare[i] == 'B') { strValsStep.Add(02); }
                    else if (compare[i] == 'b') { strValsStep.Add(03); }
                    else if (compare[i] == 'C') { strValsStep.Add(04); }
                    else if (compare[i] == 'c') { strValsStep.Add(05); }
                    else if (compare[i] == 'D') { strValsStep.Add(06); }
                    else if (compare[i] == 'd') { strValsStep.Add(07); }
                    else if (compare[i] == 'E') { strValsStep.Add(08); }
                    else if (compare[i] == 'e') { strValsStep.Add(09); }
                    else if (compare[i] == 'F') { strValsStep.Add(10); }
                    else if (compare[i] == 'f') { strValsStep.Add(11); }
                    else if (compare[i] == 'G') { strValsStep.Add(12); }
                    else if (compare[i] == 'g') { strValsStep.Add(13); }
                    else if (compare[i] == 'H') { strValsStep.Add(14); }
                    else if (compare[i] == 'h') { strValsStep.Add(15); }
                    else if (compare[i] == 'I') { strValsStep.Add(16); }
                    else if (compare[i] == 'i') { strValsStep.Add(17); }
                    else if (compare[i] == 'J') { strValsStep.Add(18); }
                    else if (compare[i] == 'j') { strValsStep.Add(19); }
                    else if (compare[i] == 'K') { strValsStep.Add(20); }
                    else if (compare[i] == 'k') { strValsStep.Add(21); }
                    else if (compare[i] == 'L') { strValsStep.Add(22); }
                    else if (compare[i] == 'l') { strValsStep.Add(23); }
                    else if (compare[i] == 'M') { strValsStep.Add(24); }
                    else if (compare[i] == 'm') { strValsStep.Add(25); }
                    else if (compare[i] == 'N') { strValsStep.Add(26); }
                    else if (compare[i] == 'n') { strValsStep.Add(27); }
                    else if (compare[i] == 'O') { strValsStep.Add(28); }
                    else if (compare[i] == 'o') { strValsStep.Add(29); }
                    else if (compare[i] == 'P') { strValsStep.Add(30); }
                    else if (compare[i] == 'p') { strValsStep.Add(31); }
                    else if (compare[i] == 'Q') { strValsStep.Add(32); }
                    else if (compare[i] == 'q') { strValsStep.Add(33); }
                    else if (compare[i] == 'R') { strValsStep.Add(34); }
                    else if (compare[i] == 'r') { strValsStep.Add(35); }
                    else if (compare[i] == 'S') { strValsStep.Add(36); }
                    else if (compare[i] == 's') { strValsStep.Add(37); }
                    else if (compare[i] == 'T') { strValsStep.Add(38); }
                    else if (compare[i] == 't') { strValsStep.Add(39); }
                    else if (compare[i] == 'U') { strValsStep.Add(40); }
                    else if (compare[i] == 'u') { strValsStep.Add(41); }
                    else if (compare[i] == 'V') { strValsStep.Add(42); }
                    else if (compare[i] == 'v') { strValsStep.Add(43); }
                    else if (compare[i] == 'W') { strValsStep.Add(44); }
                    else if (compare[i] == 'w') { strValsStep.Add(45); }
                    else if (compare[i] == 'X') { strValsStep.Add(46); }
                    else if (compare[i] == 'x') { strValsStep.Add(47); }
                    else if (compare[i] == 'Y') { strValsStep.Add(48); }
                    else if (compare[i] == 'y') { strValsStep.Add(49); }
                    else if (compare[i] == 'Z') { strValsStep.Add(50); }
                    else if (compare[i] == 'z') { strValsStep.Add(51); }
                    else if (compare[i] == '1') { strValsStep.Add(52); }
                    else if (compare[i] == '2') { strValsStep.Add(53); }
                    else if (compare[i] == '3') { strValsStep.Add(54); }
                    else if (compare[i] == '4') { strValsStep.Add(55); }
                    else if (compare[i] == '5') { strValsStep.Add(56); }
                    else if (compare[i] == '6') { strValsStep.Add(57); }
                    else if (compare[i] == '7') { strValsStep.Add(58); }
                    else if (compare[i] == '8') { strValsStep.Add(59); }
                    else if (compare[i] == '9') { strValsStep.Add(62); }
                    else if (compare[i] == '0') { strValsStep.Add(63); }
                    else { strValsStep.Add(52); }

                    
                }
                strVals.Add(strValsStep);
            }                                                                                                           // works to here
            

            int lena = content.Count;
            for (int i = 1; i < lena; i++)
            {
                int lenb = lena - (i);
                for (int j = 1; j < lenb; j++)
                {
                    List<string> temp;
                    List<int> temp2;
                    int lenc;
                    bool size;
                    if (strVals[j].Count < strVals[j + 1].Count)
                    {
                        lenc = strVals[j].Count;
                        size = false;
                    }
                    else
                    {
                        lenc = strVals[j+1].Count;
                        size = true;
                    }

                    for (int k = 0; k < lenc; k++)
                    {
                        if (strVals[j][k] > strVals[j + 1][k])
                        {
                            Console.WriteLine(strVals[j][k].ToString() + ">" + strVals[j+1][k] + "  so swapping them");
                            temp = content[j + 1];
                            temp2 = strVals[j + 1];
                            content[j + 1] = content[j];
                            strVals[j + 1] = strVals[j];
                            content[j] = temp;
                            strVals[j] = temp2;
                            k = lenc;
                            size = false;
                        }
                        else if (strVals[j][k] < strVals[j + 1][k])
                        {
                            Console.WriteLine(strVals[j][k].ToString() + "<" + strVals[j+1][k] + "  so not swapping them");
                            k = lenc;
                            size = false;
                        }
                    }

                    if (size)
                    {
                        temp = content[j + 1];
                        temp2 = strVals[j + 1];
                        content[j + 1] = content[j];
                        strVals[j + 1] = strVals[j];
                        content[j] = temp;
                        strVals[j] = temp2;
                    }
                }
            }
        }

        public void NumericSort(int index)
        {
            int len = content.Count;
            List<String> temp;
            for (int i = 1; i < len; i++)
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
            file.AlphaSort(0);
            Console.WriteLine(file.StringConv());
        }
    }
}