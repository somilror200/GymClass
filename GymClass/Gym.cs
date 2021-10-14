using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymClass
{
    class Gym
    {
        List<Member> gym = new List<Member>();

        public void AddMember()
        {
            Console.Write("Enter name\n>> ");
            string name = Console.ReadLine();
            Console.Write("Enter Valid Date\nDay>> ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month>> ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year>> ");
            int year = Convert.ToInt32(Console.ReadLine());
            ValidDate date = new ValidDate(day, month, year);
            Member member = new Member(name, date);
            gym.Add(member);
        }
        public void DeleteMember()
        {
            Console.WriteLine("Enter memb # of the player");
            Console.Write(">> ");
            int memb = Convert.ToInt32(Console.ReadLine());
            memb--;
            if (memb > gym.Count)
                throw new ArgumentOutOfRangeException("Member number does not exist");
            gym.RemoveAt(memb);
        }
        public void IncreasePackValidity()
        {
            Console.WriteLine("Enter memb # of the player");
            Console.Write(">> ");
            int memb = Convert.ToInt32(Console.ReadLine());
            memb--;
            if (memb > gym.Count)
                throw new ArgumentOutOfRangeException("Member number does not exist");
            Console.WriteLine("How much months you want to add");
            Console.Write(">> ");
            int month = Convert.ToInt32(Console.ReadLine());
            gym[memb].AddMonth(month);
        }
        public void DrawTable()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string(' ', 12) + "MEMBERS");
            Console.WriteLine(new string(' ', 10) + new string('-', 63));
            Console.Write("{0,10} ", "memb #");
            Console.Write("{0,30}|", "Name");
            Console.Write("{0,30}|", "Pack Validity");
            Console.WriteLine();
            Console.WriteLine(new string(' ', 10) + new string('-', 63));
            System.DateTime moment = DateTime.Now;
            for (int i = 0; i < gym.Count; i++)
            {
                Console.Write("{0,10}|", i + 1);
                Console.Write("{0,30}|", this.gym[i].getName());
                if (gym[i].getDate().GetYear() == moment.Year && gym[i].getDate().GetMonth() == moment.Month)
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0,30}|", this.gym[i].getDate().toString());
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
