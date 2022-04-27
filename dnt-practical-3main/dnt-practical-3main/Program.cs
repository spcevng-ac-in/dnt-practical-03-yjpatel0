using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetPractical_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[3];
            for (int k = 0; k < 3; k++)
            {
                s[k] = new Student();
                s[k].getdata();
                s[k].percentage();
                s[k].grade();

                Console.WriteLine("Your Percentage is " + s[k].percentage());
                Console.WriteLine("Your Grade is " + s[k].grade());



            }

            Console.ReadLine();
        }
    }
    class Student
    {
        public int rollno;
        public string name;
        public int n;
        public int[] subject;
        float per;

        public void getdata()
        {
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter your Roll No");
            rollno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of subjects");
            n = Convert.ToInt32(Console.ReadLine());
            subject = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter marks of subject:");
                subject[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        public int rollnum
        {
            get
            {
                return rollno;
            }

            set
            {
                if (value > 0)
                {
                    rollno = value;
                }
            }
        }

        public string myname
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public float percentage()
        {



            int sum = 0;
            foreach (int j in subject)
            {
                sum += j;
            }
            per = (float)sum / n;
            return (per);


        }

        public string grade()
        {


            if (per > 90)
                return "A";
            else if (per > 80)
            {
                return "B";
            }
            else if (per > 70)
            {
                return "C";
            }
            else if (per > 60)
            {
                return "D";

            }
            else
            {
                return "F";
            }


        }


    }
}
