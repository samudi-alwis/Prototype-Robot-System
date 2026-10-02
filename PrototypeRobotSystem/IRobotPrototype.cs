using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeRobotSystem
{
    public interface IRobotPrototype
    {
        IRobotPrototype Clone();
    }
}
