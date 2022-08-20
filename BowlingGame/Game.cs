namespace BowlingGame
{
    public class Game
    {
        int[] throws = new int[21];
        int currentThrow = 0;
        public int Score
        {
            get
            {

                var score = 0;
                var throwIndex = 0;

                for (int frame = 0; frame < 10; frame++)
                {
                    if (IsStrike(throwIndex))
                    {
                        score += GetScoreForStrike(throwIndex);
                        throwIndex++;
                    }
                    else if (IsSpare(throwIndex))
                    {
                        score += GetScoreForSpare(throwIndex);
                        throwIndex += 2;
                    }
                    else
                    {
                        score += GetRegularScore(throwIndex);
                        throwIndex += 2;
                    }

                }
                return score;
            }
        }

        public void Throw(int pins)
        {
            throws[currentThrow++] = pins;
        }

        private bool IsSpare(int rollIndex) => throws[rollIndex] + throws[rollIndex + 1] == 10;
        private bool IsStrike(int rollIndex) => throws[rollIndex] == 10;
        private int GetScoreForSpare(int rollIndex) => throws[rollIndex] + throws[rollIndex + 1] + throws[rollIndex + 2];
        private int GetScoreForStrike(int rollIndex) => throws[rollIndex] + throws[rollIndex + 1] + throws[rollIndex + 2];
        private int GetRegularScore(int rollIndex) => throws[rollIndex] + throws[rollIndex + 1];

    }
}