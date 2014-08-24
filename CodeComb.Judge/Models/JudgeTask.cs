﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeComb.Judge.Models
{
    public class JudgeTask
    {
        public string Token { get; set; }
        public int ID { get; set; }
        public string Code { get; set; }
        public Entity.Language CodeLanguage { get; set; }
        public int DataID { get; set; }
        public string SpecialJudgeCode { get; set; }
        public Entity.Language SpecialJudgeCodeLanguage { get; set; }
        public int TimeLimit { get; set; }
        public int MemoryLimit { get; set; }
    }
}
