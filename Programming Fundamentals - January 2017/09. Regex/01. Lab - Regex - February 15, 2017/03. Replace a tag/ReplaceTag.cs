﻿namespace _01.Replace_a_tag
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ReplaceTag
    {
        // Write a program that replaces in a HTML document given as string all the tags<a href=…>…</a> 
        // with corresponding tags[URL href =…>…[/ URL]. Read an input, until you receive “end” command.
        // Print the result on the console. 

        public static void Main()
        {
            List<string> html = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower().Equals("end"))
                {
                    break;
                }

                html.Add(input);
            }

            Regex regex = new Regex(@"<a.*(href=.*>?)>(.*)<\/a>");

            foreach (string line in html)
            {
                string result = regex.Replace(line, "[URL $1]$2[/URL]");

                Console.WriteLine(result);
            }
        }
    }
}