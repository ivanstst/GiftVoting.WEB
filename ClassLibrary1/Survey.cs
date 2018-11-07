using System;
using System.Collections.Generic;
using System.Text;

namespace GiftVoting.CORE
{
    public class Survey
    {
        public int Id { get; set; }

        public int CreatorId { get; set; }

        public int TargetUserId { get; set; }

        public List<Gift> Gifts { get; set; }

        public List<Vote> UserVotes { get; set; }
    }
}
