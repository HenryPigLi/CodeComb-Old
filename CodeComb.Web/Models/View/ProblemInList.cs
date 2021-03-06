﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeComb.Web.Models.View
{
    public class ProblemInList
    {
        public ProblemInList() { }
        public ProblemInList (Entity.Problem problem, Entity.User user) 
        {
            ID = problem.ID;
            Title = problem.Title;
            ContestTitle = problem.Contest.Title;
            ContestID = problem.ContestID;
            AC = problem.Statuses.Where(x => x.ResultAsInt == (int)Entity.JudgeResult.Accepted).Count();
            Submit = problem.Statuses.Count;
            Difficulty = "R";
            if (problem.Difficulty >= 1500 && problem.Difficulty < 1700)
                Difficulty = "L3";
            else if (problem.Difficulty >= 1700 && problem.Difficulty < 2000)
                Difficulty = "L2";
            else if (problem.Difficulty >= 2000 && problem.Difficulty < 2400)
                Difficulty = "L1";
            else if (problem.Difficulty >= 2400)
                Difficulty = "S";
            Flag = "";
            FlagCss = "";
            if (user != null)
            {
                var statuses = problem.Statuses.Where(x => x.UserID == user.ID);
                if (statuses.Count() == 0)
                {
                    return;
                }
                else
                {
                    if (statuses.Where(x => x.ResultAsInt == (int)Entity.JudgeResult.Accepted).Count() > 0)
                    {
                        Flag = "Accepted";
                        FlagCss = "flag-green";
                    }
                    else
                    {
                        Flag = "Not Accepted";
                        FlagCss = "flag-red";
                    }
                }
            }
        }
        public int ID { get; set; }
        public string Flag { get; set; }
        public string FlagCss { get; set; }
        public string Title { get; set; }
        public int AC { get; set; }
        public int Submit { get; set; }
        public string Difficulty { get; set; }
        public string ContestTitle { get; set; }
        public int ContestID { get; set; }
    }
}