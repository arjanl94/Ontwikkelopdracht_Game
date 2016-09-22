using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE2Game
{
    enum SoortCell
    {
        Wall,
        Field,
        Goal
    }
    enum Action
    {
        NoAction,
        MoveUp,
        MoveDown,
        MoveLeft,
        MoveRight,
        PerformAction
    }
}
