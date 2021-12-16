﻿// See https://aka.ms/new-console-template for more information

using System.Text;

string? input = Console.ReadLine();

char current;
char prev = input[0];
int count = 1;

for (int j = 0; j < 40; j++)
{
    StringBuilder new_str = new StringBuilder();
    for (int i = 1; i < input.Length; i++)
    {
        current = input[i];
        if (current == prev)
        {
            count++;
        }
        else
        {
            new_str.Append(count.ToString() + prev);
            prev = current;
            count = 1;
        }
    }

    new_str.Append(count.ToString() + prev);
    input = new_str.ToString();
    prev = input[0];
    count = 1;
    // Console.WriteLine(new_str.ToString() + "\t" + input);
}

Console.WriteLine(input.Length);

// 146794 - too low - Part 1 Solution 252594