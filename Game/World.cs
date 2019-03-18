
namespace Game
{
    public class World
    {
        private static int _gridSize = 40;
        private char[][] _grid { get; set; }

        public World()
        {
            _buildGrid();
        }

        private void _buildGrid()
        {
            _grid = new char[_gridSize][];
            for (int x = 0; x < _gridSize; x++)
            {
                _grid[x] = new char[_gridSize];
                for (int y = 0; y < _gridSize; y++)
                {
                    _grid[x][y] = 'x';
                }
            }
        }

        // renders the current state of the grid
        public string GetWorldState()
        {
            string currentState = "";

            for (int x = 0; x < _gridSize; x++)
            {
                for (int y = 0; y < _gridSize; y++)
                {
                    currentState += $"{ _grid[x][y] } ";
                }
                currentState += "\n";
            }
            
            return currentState;
        }
    }
}