using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Command
{
    public interface ICommand
    {
        void Execute(Stack<double> stack);
    }
}
