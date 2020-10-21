using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    partial class Abiturient
    {
        //static methods
        public static void Info()
        {
            Console.WriteLine("Abiturients of city - {0}.", city);
        }
        public static void CalculateAverageScore(out int average, params int[] scores)
        { 
            average = 0;
            for (int i = 0; i < scores.Length; i++)
                average += scores[i];
            average /= scores.Length;
        }
        public static void SetMaxScore(ref int score)
        {
            score = 10;
        }
        public static void SetCity(char newCity)
        {
            city = newCity;
        }

        //class methods
        public int MaxScore()
        {
            int i = 0;
            foreach (var item in Scores)
                if (i < item)
                    i = item;
            return i;
        }
        public int MinScore()
        {
            int i = 0;
            foreach (var item in Scores)
                if (i > item)
                    i = item;
            return i;
        }
        public bool CheckOnPassableScores()
        {
            bool outcome = true;
            foreach (var item in Scores)
                if (item < PassableScore)
                    outcome = false;
            return outcome;
        }
        public bool ChekOnSumWall(int wall)
        {
            int sum = 0;
            foreach (var item in Scores)
                sum += item;
            return (wall < sum) ? true : false;
        }
        public void PrintScores()
        {
            foreach (var item in Scores)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        //override methods
        public override string ToString() => $"[Identificator: {Identificator}; Name: {Name}; Middle : {Middle}; Last : {Last}; Adress : {Adress}; Telephone: {Telephone};]";

        public override bool Equals(object obj)
        {
            if (obj is Abiturient && obj != null)
            {
                Abiturient temp;
                temp = (Abiturient)obj;
                if (temp.Identificator == this.Identificator
                    && temp.Name == this.Name
                    && temp.Middle == this.Middle
                    && temp.Last == this.Last
                    && temp.Adress == this.Adress
                    && temp.Telephone == this.Telephone) return true;
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
