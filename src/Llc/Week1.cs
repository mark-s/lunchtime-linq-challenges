using System;
using System.Linq;

namespace Llc
{
    public static class Week1
    {

        /*
        Take the following string "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana, Rodriguez, Lambert" and give each player a shirt number, starting from 1, to create a string of the form: "1. Davis, 2. Clyne, 3. Fonte" etc
         */
        public static string Task1(string input, char splitter)
        {
            var names = input.Split(splitter).Select(i => i.Trim());

            var numbers = Enumerable.Range(1, names.Count());

            var namesAndNumbers = names.Zip(numbers, (name, number) => $"{number}. {name}");

            // could use aggregate here.. but it's ugly
            return string.Join(", ", namesAndNumbers);
        }


    }
}
