/*

 Goal
A bank robber is about to break into a bank. The police has been informed and will arrive in c seconds. Before blowing the safe, the robber speaks to the civilians in the room. On average, he says wpm words per minute. After each sentence (including the last one), he pauses for p seconds before continuing.
Once he is done with his speech s, he needs t seconds until he is ready to leave again.

Assuming, everything goes according to plan, which of the following cases will occur?
1) "SUCCESS"; the bank is empty before the police comes
2) "SPECTACULAR"; on top of the case above, there's enough time to give the same speech again before leaving
3) "BUSTED"; he doesn't make it in time

Notes:
Each sentence is guaranteed to end with exactly one period (.), exclamation point (!) or question mark (?).
The bank robber can carry an infinite amount of money.
If he comes out of the bank in the same moment as the police arrives, he gets busted.
Input
Line 1: Four space separated integers: c, wpm, p, t
Line 2: A string s
Output
A single line containing "SUCCESS", "SPECTACULAR" or "BUSTED" (see statement above).
Constraints
30 <= c <= 1000
60 <= wpm <= 200
0 <= p <= 5
10 <= t <= 600
3 <= amount of characters in s <= 1024
Example
Input

180 155 1 120
Am I the only one who thinks it is HOT in here? Sorry, small talk was never my thing. Ehm, hi, my name is Ron. Darn, I was not supposed to say that! Anyway, I have come to free you from this capitalistic world. Just kidding, guys, stop looking at me like that. It WAS a good joke though, right? No? Anyone? Fine, here we go. Geronimo!

Output

SUCCESS


*/

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int c = int.Parse(inputs[0]);
        int wpm = int.Parse(inputs[1]);
        int p = int.Parse(inputs[2]);
        int t = int.Parse(inputs[3]);
        string s = Console.ReadLine();

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine("Run The Jewels!");
    }
}
