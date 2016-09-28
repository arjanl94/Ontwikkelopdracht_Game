using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE2Game
{
    public enum SoortCell
    {
        Wall,
        Field,
        Goal
    }
    public enum Action
    {
        NoAction,
        MoveUp,
        MoveDown,
        MoveLeft,
        MoveRight,
        PerformAction
    }
}
