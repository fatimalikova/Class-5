using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using System;

namespace Class_5.Task_3
{
    internal class StudentClass
    {
        private string fullname;
        private string groupNo;

        public string Fullname
        {
            get { return fullname; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    string[] parts = value.Trim().Split(' ');
                    if (parts.Length == 2 && char.IsUpper(parts[0][0]) && char.IsUpper(parts[1][0]))
                    {
                        fullname = value;
                        return;
                    }
                }
                Console.WriteLine("Xəta: Fullname düzgün formatda deyil!");
            }
        }

        public int Age { get; set; }

        public string GroupNo
        {
            get { return groupNo; }
            set
            {
                if (value.Length == 4 &&
                    char.IsUpper(value[0]) &&
                    char.IsDigit(value[1]) &&
                    char.IsDigit(value[2]) &&
                    char.IsDigit(value[3]))
                {
                    groupNo = value;
                }
                else
                {
                    Console.WriteLine("Xəta: GroupNo düzgün formatda deyil! (Məsələn: P216)");
                }
            }
        }

        public static bool CheckFullname(string fullname)
        {
            if (string.IsNullOrWhiteSpace(fullname)) return false;
            string[] parts = fullname.Trim().Split(' ');
            if (parts.Length != 2) return false;
            if (!char.IsUpper(parts[0][0]) || !char.IsUpper(parts[1][0])) return false;
            return true;
        }

        public static bool CheckGroupNo(string groupNo)
        {
            if (string.IsNullOrWhiteSpace(groupNo)) return false;
            if (groupNo.Length != 4) return false;
            if (!char.IsUpper(groupNo[0])) return false;
            if (!char.IsDigit(groupNo[1]) || !char.IsDigit(groupNo[2]) || !char.IsDigit(groupNo[3])) return false;
            return true;
        }



        public void DoHomeWork()
        {
            if (Age < 18)
            {
                Console.WriteLine($"{Fullname} hələ gəncdir, sadə tapşırıqlar edəcək.");
            }
            else if (GroupNo.StartsWith("P"))
            {
                Console.WriteLine($"{Fullname} P qrupundadır, orta səviyyəli tapşırıq edəcək.");
            }
            else
            {
                Console.WriteLine($"{Fullname} çətin tapşırıq edəcək.");
            }
        }

    }
}

