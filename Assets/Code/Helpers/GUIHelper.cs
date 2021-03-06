﻿using System.Text;
using UnityEngine;

public class GUIHelper
{
    public static string WordWrap(string s, int lineLength)
    {
        StringBuilder sb = new StringBuilder();
        string[] parts = s.Split(new char[] { }); //default split = any whitespace -> ' ', '\n',...

        int nbChars = 0;
        for (int i = 0; i < parts.Length; i++)
        {
            //Debug.Log(parts[i]);
            if (nbChars + parts[i].Length > lineLength)
            {
                sb.Append('\n');
                nbChars = 0;
            }
            else if(nbChars != 0)
                sb.Append(' ');

            sb.Append(parts[i]);
            nbChars += parts[i].Length + 1;
        }

        return sb.ToString();
    }
}
