namespace Kerstpuzzel
{
    public class Grid
    {
        private readonly string[,] _myGrid;

        public Grid()
        {
            _myGrid = new string[5, 5];
        }

        public string E
        {
            get => GetGridRow(4);
            set => setGridRow(value, 4);
        }

        private string GetGridRow(int iRow)
        {
            return _myGrid[0, iRow] + _myGrid[1, iRow] + _myGrid[2, iRow] + _myGrid[3, iRow] + _myGrid[4, iRow];
        }

        private void setGridRow(string myval, int iRow)
        {
            if (myval != "")
            {
                _myGrid[0, iRow] = myval.Substring(0, 1);
                _myGrid[1, iRow] = myval.Substring(1, 1);
                _myGrid[2, iRow] = myval.Substring(2, 1);
                _myGrid[3, iRow] = myval.Substring(3, 1);
                _myGrid[4, iRow] = myval.Substring(4, 1);
            }
        }

        private string getGridCol(int iCol)
        {
            return _myGrid[iCol, 4] + _myGrid[iCol, 3] + _myGrid[iCol, 2] + _myGrid[iCol, 1] + _myGrid[iCol, 0];
        }

        private void setGridCol(string myval, int iCol)
        {
            if (myval != "")
            {
                _myGrid[iCol, 4] = myval.Substring(0, 1);
                _myGrid[iCol, 3] = myval.Substring(1, 1);
                _myGrid[iCol, 2] = myval.Substring(2, 1);
                _myGrid[iCol, 1] = myval.Substring(3, 1);
                _myGrid[iCol, 0] = myval.Substring(4, 1);
            }
        }

        public string D
        {
            get => GetGridRow(3);
            set => setGridRow(value, 3);
        }

       public string C
        {
            get => GetGridRow(2);
            set => setGridRow(value, 2);
        }
        public string B
        {
            get => GetGridRow(1);
            set => setGridRow(value, 1);
        }
        public string A
        {
            get => GetGridRow(0);
            set => setGridRow(value, 0);
        }

        public string F
        {
            get => getGridCol(0);
            set => setGridCol(value, 0);
        }

        public string G
        {
            get => getGridCol(1);
            set => setGridCol(value, 1);
        }
        public string H
        {
            get => getGridCol(2);
            set => setGridCol(value, 2);
        }
        public string I
        {
            get => getGridCol(3);
            set => setGridCol(value, 3);
        }
        public string J
        {
            get => getGridCol(4);
            set => setGridCol(value, 4);
        }
    }
}