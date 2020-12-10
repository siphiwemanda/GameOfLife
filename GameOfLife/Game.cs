namespace GameOfLife
{
    public class Game
    {
        private readonly bool[,] _board;

        public Game(bool[,] board)
        {
            _board = board;
           
        }

        public void Evolve()
        {

            var newBoard = new bool[_board.GetLength(0), _board.GetLength(1)];

            for (var x = 0; x < _board.GetLength(0); x++)
            {
                for (var y = 0; y < _board.GetLength(1); y++)
                {
                    GetLivingNeighborsCount(x,y);
                }
            }
            _board[1, 1] = false;

        }

        private int GetLivingNeighborsCount(int x, int y)
        {
            
            var cellOne = x - 1;
            var totalLiveCells = 0;
            totalLiveCells += IsAlive(x - 1, y - 1) ? 1 : 0;
            totalLiveCells += IsAlive(x - 1, y - 0) ? 1 : 0;
            totalLiveCells += IsAlive(x - 1, y + 1) ? 1 : 0;
            totalLiveCells += IsAlive(x - 0, y - 1) ? 1 : 0;
            totalLiveCells += IsAlive(x - 0, y + 1) ? 1 : 0;
            totalLiveCells += IsAlive(x + 1, y - 1) ? 1 : 0;
            totalLiveCells += IsAlive(x + 1, y - 0) ? 1 : 0;
            totalLiveCells += IsAlive(x + 1, y + 1) ? 1 : 0;

            return totalLiveCells;


        }

        public bool IsAlive(int x, int y)
        {
            var maxX = _board.GetLength(0);
            var minX = 0;

            var maxY = _board.GetLength(1);
            var minY = 0;
            if (x >=minX && x < maxX && y >= minY && y < maxY)
            {
                return _board[x, y];
            }

            return false;


        }
    }
}