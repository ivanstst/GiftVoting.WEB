using GiftVoting.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftVoting.ApplicationCore.Entities
{
    public class Person : BaseEntity
    {

        public List<Vote> Votes{ get; set; }
    }
}
