using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static int marsExploration(string receivedMessage)
    {
        int count = receivedMessage.Length / 3;

        string originalMessage = (string.Concat(Enumerable.Repeat("SOS", count)));

        int difference = 0;


        for (int i = 0, j= 0; i < originalMessage.Length; i++, j++)
        {
            if (originalMessage[i] != receivedMessage[j])
            {
                difference++;
            }
        }
        return difference;  
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = Result.marsExploration(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
