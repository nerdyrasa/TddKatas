﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddKatas
{
    public enum CellState
    {
        Alive,
        Dead
    }

    public class LifeRules
    {
        public static CellState GetNewState(CellState currentState, int liveNeighbors)
        {
            if (currentState == CellState.Alive && liveNeighbors < 2)
                return CellState.Dead;

            return currentState;
        }
    }
}