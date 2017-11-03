using ProjectEulerApp.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ProjectEulerApp
{
    class ProblemsCollection
    {
        public static SortedDictionary<string, IProblem> GetProblems()
        {
            var instances = from t in Assembly.GetExecutingAssembly().GetTypes()
                            where t.GetInterfaces().Contains(typeof(IProblem))
                            && t.GetConstructor(Type.EmptyTypes) != null
                            select Activator.CreateInstance(t) as IProblem;

            ProbComp probComp = new ProbComp();
            SortedDictionary < string, IProblem> problems = new SortedDictionary<string, IProblem>(new ProbComp());

            foreach (var instance in instances)
            {
                problems.Add(instance.Name, instance);
            }

            return problems;
        }
    }

    class ProbComp : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            Regex rx = new Regex("Problem ");
            string numX = rx.Replace(x, "");
            string numY = rx.Replace(y, "");

            int intX;
            int.TryParse(numX, out intX);
            int intY;
            int.TryParse(numY, out intY);

            if (intX.CompareTo(intY) != 0)
            {
                return intX.CompareTo(intY);
            }
            else
            {
                return 0;
            }
        }
    }
}
