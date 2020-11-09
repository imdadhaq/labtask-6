using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem
{
    class account
    {
        private string id;

        public string acc_id
        {
            get { return id; }
            set { id = value; }
        }

        protected string name;
        protected string department;
        internal int deposit;
        internal float cgpa;

        private void creat_account()
        {
            Console.Write("Enter Your Id: ");
            acc_id = Console.ReadLine();
            Console.Write("Enter Your Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Your Type:");
            department = Console.ReadLine();
            Console.Write("Enter initial deposit");
            deposit = int.Parse(Console.ReadLine());
            Console.Write("Enter Your cgpa: ");
            cgpa = float.Parse(Console.ReadLine());
        }

        public void creataccount()
        {
            creat_account();
        }

        private void show_account()
        {
            Console.WriteLine("Your Id:", acc_id);
            Console.WriteLine("Your Name:", name);
            Console.WriteLine("Your cgpa:", cgpa);
            Console.WriteLine("Your Department:", department);

        }

        public void showaccount()
        {
            show_account();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABTASK6
{
    class student
    {

        private String name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private String id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }


        private String department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public student()
        {
            Console.WriteLine("Empty Constructor");
        }

        public student(String name, String id, String department, float cgpa)
        {

            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }


        public void showinfo()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("ID :" + id);
            Console.WriteLine("Department :" + department);
            Console.WriteLine("CGPA :" + cgpa);
        }
    }
}
