using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab03
{
    partial class Abiturient
    {
        //Readonly Field - ID
        public int Identificator { get; set; } = 0;

        private string name = "";
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                    name = value;
            }
        }
        private string middle = "";
        public string Middle
        {
            get { return middle; }
            set
            {
                if (value != null)
                    middle = value;
            }
        }
        private string last = "";
        public string Last
        {
            get { return name; }
            set
            {
                if (value != null)
                    last = value;
            }
        }
        private string adress = "";
        public string Adress
        {
            get { return name; }
            set
            {
                if (value != null)
                    adress = value;
            }
        }
        public int Telephone { get; set; } = 0;
        public int[] Scores { get; set; } = new int[0];

        private readonly int ID;
        const string university = "BSTU";
        public static int PassableScore { get; set; } = 4;
        private static char city;
        static private int count = 0;

        public Abiturient()
        {
            ID = this.GetHashCode();
            count++;
        }
        public Abiturient(int id, string name, int telephone) : this()
        {
            Identificator = id;
            Name = name;
            Telephone = telephone;
        }
        public Abiturient(int id, string last, int[] scores) : this(scores, id)
        {
            Last = last;
        }
        private Abiturient(int[] scores, int id = -1, string name = "anonymous", int telephone = 112) : this()
        {
            Scores = scores;
            Identificator = id;
            Name = name;
            Telephone = telephone;
        }

        static Abiturient()
        {
            city = 'A';
        }

    }
}
