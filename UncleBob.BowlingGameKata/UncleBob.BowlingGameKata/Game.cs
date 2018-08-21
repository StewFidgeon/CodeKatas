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
            int _score = 0;
            int i = 0;
            for (var frame = 0; frame < 10; frame++)
            {
                if (_rolls[i] + _rolls[i + 1] == 10) //spare
                {
                    _score += 10 + _rolls[i + 2];
                    i += 2;
                }
                else
                {
                    _score += _rolls[i] + _rolls[i + 1];
                    i += 2;
                }
            }
            return _score;
        }
    }
}
