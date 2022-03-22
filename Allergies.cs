using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodePackage
{


    // add additional libraries if required

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Allergies
    {
        // do not alter this enum
        [Flags]
        public enum Allergen
        {
            Eggs = 1,
            Peanuts = 2,
            Shellfish = 4,
            Strawberries = 8,
            Tomatoes = 16,
            Chocolate = 32,
            Pollen = 64,
            Cats = 128
        }

        // write your code below this line

        // constructors 
        public Allergies(string n)
        {
            this.Name = n;
        }

        public Allergies(string n, int scores)
        {
            this.Name = n;
            this.Score = scores;
        }

        public Allergies(string n, string alleryies)
        {
            this.Name = n;
            foreach (string s in alleryies.Split(' '))
            {
                this.AddAllergy(string2Allergen(s));
            }
        }







        // properties
        public string Name { get; private set; }
        public int Score { get; private set; }


        // methods
        public Allergen string2Allergen(string s)
        {
            foreach (Allergen item in Enum.GetValues(typeof(Allergen)))
            {
                if (item.ToString() == s) return item;
            }

            //if(s.Length>0)
            //return (Allergen)Enum.Parse(typeof(Allergen), s);
            return Allergen.Cats;
        }

        public void AddAllergy(string a)
        {
            Score |= (int)string2Allergen(a);
        }

        public void AddAllergy(Allergen a)
        {
            Score |= (int)a;
        }

        public void DeleteAllergy(string s)
        {
            DeleteAllergy(string2Allergen(s));
        }
        public void DeleteAllergy(Allergen a)
        {
            Score -= (int)a;
        }


        public bool IsAllergicTo(Allergen a)
        {
            return (((int)a & this.Score) > 0);
        }

        public bool IsAllergicTo(string s)
        {
            return IsAllergicTo(string2Allergen(s));
        }

        public override string ToString()
        {
            // add code here to return string representation of this instance
            List<string> list = new List<string>();

            foreach (var item in Enum.GetValues(typeof(Allergen)))
            {
                if (((int)item & this.Score) > 0) list.Add(item.ToString());
            }

            var format1 = "{0} is allergic to {1}.";
            var format2 = "{0} and {1}";
            if (this.Score == 0) return this.Name + " has no allergies!";
            if (list.Count == 1)
            {
                return String.Format(format1, this.Name, list[0]);
            }
            else if (list.Count == 2)
            {
                return String.Format(format1, this.Name, String.Format(format2, list[0], list[1]));
            }
            else
            {
                string aName = "";
                for (int i = 0; i < list.Count - 1; i++)
                {
                    aName += list[i].Trim() + ", ";
                }
                aName = aName.Substring(0, aName.Length - 2);
                return String.Format(format1, this.Name, String.Format(format2, aName, list[list.Count - 1]));
            }
        }
        // return base.ToString();
    }




}





