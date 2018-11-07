using System;
using System.Collections.Generic;
using System.Text;

namespace GiftVoting.ApplicationCore.Entities
{
    public class Survey : BaseEntity
    {

        public int CreatorId { get; set; }

        public int TargetUserId { get; set; }

        public ICollection<Gift> Gifts { get; set; }

        public ICollection<Vote> Votes { get; set; }
    }
}
