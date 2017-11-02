using ProjectEulerApp.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerApp
{
    class ProblemsCollection
    {
        public static Dictionary<string, IProblem> GetProblems()
        {
            Dictionary<string, IProblem> problems = new Dictionary<string, IProblem>();
            Problem1 problem1 = new Problem1();
            problems.Add(problem1.Name, problem1);
            Problem2 problem2 = new Problem2();            
            problems.Add(problem2.Name, problem2);


            Problem4 problem4 = new Problem4();
            problems.Add(problem4.Name, problem4);
            Problem5 problem5 = new Problem5();
            problems.Add(problem5.Name, problem5);
            Problem6 problem6 = new Problem6();
            problems.Add(problem6.Name, problem6);
            Problem7 problem7 = new Problem7();
            problems.Add(problem7.Name, problem7);
            return problems;
        }
    }
}
