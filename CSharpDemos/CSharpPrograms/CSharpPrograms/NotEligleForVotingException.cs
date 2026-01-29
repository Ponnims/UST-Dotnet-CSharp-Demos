using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    internal class NotEligleForVotingException:Exception
    {
        public NotEligleForVotingException()
        {
            
        }

        public NotEligleForVotingException(string msg): base(msg)
        {
            
        }
    }
}
