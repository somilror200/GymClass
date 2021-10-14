using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymClass
{
    class Member
    {
        private string name;
        private ValidDate valid_date;

        public Member(string name, ValidDate date)
        {
            this.name = name;
            this.valid_date = date;
        }
        public void AddMonth(int months)
        {
            for(int i = 1; i <= months; i++)
            {
                this.valid_date.NextMonth();
            }
        }
        public string getName()
        {
            return this.name;
        }
        public ValidDate getDate()
        {
            return this.valid_date;
        }
    }
}
