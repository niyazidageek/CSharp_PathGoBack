using System;
using System.IO;

public class PathGoBack
{
    public static string GetPreviousPath(string path, int levels = 0)
    {
        if (levels is 0)
        {
            return Path.Combine(path, @"..");
        }
        else
        {
            string[] rawPath = new string[++levels];
            for (int i = 0; i < levels; i++)
            {
                if (i == 0)
                {
                    rawPath[i] = path;
                }
                else
                {
                    rawPath[i] = @"..";
                }
            }

            return Path.Combine(rawPath);
        }
    }
}