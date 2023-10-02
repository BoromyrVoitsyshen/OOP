using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2._2
{
    abstract class Worker
    {
        public string Name;
        public string Position;
        public string WorkDay;

        public Worker(string name)
        {
            Name = name;
        }

        protected void Call()
        {
            WorkDay += "Called ";
        }
        protected void WriteCode()
        {
            WorkDay += "WritedCode ";
        }
        protected void Relax()
        {
            WorkDay += "Relaxed ";
        }

        protected abstract void FillWorkDay();
    }

    class Developer : Worker
    {
        public Developer(string name) : base(name)
        {
            Position = "Developer";
            FillWorkDay();
        }

        protected override void FillWorkDay()
        {
            WriteCode();
            Call();
            Relax();
            WriteCode();
        }
    }

    class Manager : Worker
    {
        private Random r = new Random();
        public Manager(string name) : base(name)
        {
            Position = "Manager";
            FillWorkDay();
        }

        protected override void FillWorkDay()
        {
            int repeatCount = r.Next(10);
            for(int i = 0; i < repeatCount; i++) 
                Call();
            Relax();
            repeatCount = r.Next(5);
            for (int i = 0; i < repeatCount; i++) 
                Call();
        }
    }

    class Team
    {
        private List<Worker> MemberList = new List<Worker>();
        public string Name;
        public Team(string name)
        {
            Name = name;
        }

        public void AddMember(Worker newMember)
        {
            MemberList.Add(newMember);
        }
        public void TeamInfo()
        {
            Console.WriteLine(Name); Console.Write(":");
            for (int i = 0; i < MemberList.Count; i++)
            {
                Console.Write(" - ");
                Console.WriteLine(MemberList[i].Name);
            }
        }

        public void AdditionalTeamInfo()
        {
            Console.WriteLine(Name); Console.Write(":");
            for (int i = 0; i < MemberList.Count; i++)
            {
                Console.Write(" - "); Console.Write(MemberList[i].Name);
                Console.Write(" - "); Console.Write(MemberList[i].Position);
                Console.Write(" - "); Console.WriteLine(MemberList[i].WorkDay);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of your team");
            string userInput = Console.ReadLine();
            Team userTeam = new Team(userInput);
            bool userConfirms = true;
            string workerName;
            int failCount = 0;
            Console.WriteLine("Enter name of your worker");
            while ((failCount < 2) & userConfirms)
            {
                userInput = Console.ReadLine();
                workerName = userInput;
                Console.WriteLine("Enter position of your worker(Manager/Developer)");
                userInput = Console.ReadLine().Trim().ToLower();
                if (userInput == "manager")
                {
                    Manager userWorker = new Manager(workerName);
                    userTeam.AddMember(userWorker);
                }
                else if (userInput == "developer")
                {
                    Developer userWorker = new Developer(workerName);
                    userTeam.AddMember(userWorker);
                }
                else
                {
                    Console.WriteLine("Available positions are only Manager and Developer, try again");
                    failCount++;
                }
                    if (failCount < 2)
                {
                    Console.WriteLine("Enter yes if you want to continue");
                    userInput = Console.ReadLine().Trim().ToLower();
                    if (userInput == "yes")
                    {
                        userConfirms = true;
                        Console.WriteLine("Enter next name");
                    }
                    else
                    {
                        userConfirms = false;
                    }
                }
            }
            userTeam.TeamInfo();
            Console.WriteLine("Enter yes if you want to additional info");
            userInput = Console.ReadLine().Trim().ToLower();
            if (userInput == "yes")
                userConfirms = true;
            else
                userConfirms = false;
            if(userConfirms) userTeam.AdditionalTeamInfo();
            Console.WriteLine("<<END OF WORK>>");
            Console.ReadKey();
        }
    }
}
