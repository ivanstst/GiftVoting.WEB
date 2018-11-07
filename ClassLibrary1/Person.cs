using System;
using System.Collections.Generic;
using System.Text;

namespace GiftVoting.CORE
{
    public class Person
    {
        public int Id { get; set; }

        public List<Vote> Votes{ get; set; }
    }
}
