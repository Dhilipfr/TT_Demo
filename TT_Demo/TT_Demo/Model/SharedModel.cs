﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT_Demo.Model
{
    class SharedModel
    {
    }
    public class PlayersInfo
    {
        public long ID { get; set; }

        public string FullName { get; set; }

        public int No_Of_Match { get; set; }
        public int No_Of_Match_Win { get; set; }
        public int No_Of_Match_Lose { get; set; }
        public int TotelPoint { get; set; }
    }

    public class RootObject
    {
        public bool Status { get; set; }
        public List<MyMatchInfo> Message { get; set; }
    }

    public class MyMatchInfo
    {
        public long ID { get; set; }

        public long OpponentID { get; set; }

        public string OpponentFullName { get; set; }

        public bool MatchStatus { get; set; }

        public int Point { get; set; }
    }
}
