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
            int frameIndex = 0;
            for (var frame = 0; frame < 10; frame++)
            {
                if (_rolls[frameIndex] == 10) //strike
                {
                    _score += 10 + _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
                    frameIndex++;
                }
                else if (IsSpare(frameIndex))
                {
                    _score += 10 + _rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    _score += _rolls[frameIndex] + _rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return _score;
        }

        private bool IsSpare(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;
        }
    }
}
