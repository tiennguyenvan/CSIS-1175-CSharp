using System;
using static System.Console;

namespace Book.Chapter_1 {
    class Question_6 {
        public static void Solution() {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            // Laugh often,Dream big,Reach for the stars!Output #3Laughoften,Dreambig,Reachforthestars!
            WriteLine("Output #1");
            Write("        Laugh often, "); Write("Dream big, "); WriteLine("Reach for the stars!");
            WriteLine("Output #2");
            WriteLine("        Laugh often, ");
            WriteLine("        Dream big, ");
            WriteLine("        Reach for the stars!");
            WriteLine("Output #3");
            WriteLine("        Laugh");
            WriteLine("        often,");
            WriteLine("        Dream");
            WriteLine("        big,");
            WriteLine("        Reach ");
            WriteLine("        for");
            WriteLine("        the");
            WriteLine("        stars!");

        }
    }
}