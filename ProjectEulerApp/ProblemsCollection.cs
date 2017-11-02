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

            Problem25 problem25 = new Problem25();
            problems.Add(problem25.Name, problem25);

            Problem30 problem30 = new Problem30();
            problems.Add(problem30.Name, problem30);

            Problem34 problem34 = new Problem34();
            problems.Add(problem34.Name, problem34);

            Problem36 problem36 = new Problem36();
            problems.Add(problem36.Name, problem36);
            Problem37 problem37 = new Problem37();
            problems.Add(problem37.Name, problem37);

            Problem44 problem44 = new Problem44();
            problems.Add(problem44.Name, problem44);
            return problems;
        }
    }
}
