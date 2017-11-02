using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerApp.Problems
{
    public interface IProblem
    {
        #region Properties
        string Name { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        long RequiredAnswer { get; set; }
        long MyAnswer { get; set; }
        #endregion

        #region Methods
        long GetAnswer();
        #endregion
    }
}
