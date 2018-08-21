using System;
using System.Collections.Generic;
using System.Text;

namespace UncleBob.BowlingGameKata
{
    public class Game
    {
        private int _score = 0;

        public void Roll(int pins)
        {
            _score += pins;
        }

        public int Score()
        {
            return _score;
        }
    }
}
