using System;
using System.Collections.Generic;
using System.Text;

namespace UncleBob.BowlingGameKata
{
    public class Game
    {
        private int _score = 0;
        private readonly int[] _rolls = new int[21];
        private int _currentRoll = 0;

        public void Roll(int pins)
        {
            _score += pins;
            _rolls[_currentRoll++] = pins;
        }

        public int Score()
        {
            return _score;
        }
    }
}
