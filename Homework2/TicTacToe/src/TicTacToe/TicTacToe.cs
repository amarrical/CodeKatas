//-----------------------------------------------------------------------
// <copyright file="TicTacToe.cs" company="ImprovingEnterprises">
//     Copyright (c) ImprovingEnterprises. All rights reserved.
// </copyright>
// <author>Anthony Marrical</author>
//-----------------------------------------------------------------------
namespace TicTacToe
{
    using System.Security.Principal;

    /// <summary>
    /// Represents a tic tac toe game.
    /// </summary>
    public class TicTacToe
    {
        #region [ Fields ]

        /// <summary>
        /// Contains the state map for the board.
        /// </summary>
        private State[,] board;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of the <see cref="TicTacToe"/> class.
        /// </summary>
        public TicTacToe()
        {
            this.board = new State[3, 3];
        }

        #endregion

        #region [ Methods ]

        /// <summary>
        /// Attempts to place a circle at the location.
        /// </summary>
        /// <param name="col">Column to place the circle.</param>
        /// <param name="row">Row to place the circle.</param>
        /// <returns>A value representing wheither the placement is valid.</returns>
        public bool SetCircle(int col, int row)
        {
            return this.SetPiece(col, row, State.Circle);
        }

        /// <summary>
        /// Attempts to place a cross at the location.
        /// </summary>
        /// <param name="col">Column to place the cross.</param>
        /// <param name="row">Row to place the cross.</param>
        /// <returns>A value representing wheither the placement is valid.</returns>
        public bool SetCross(int col, int row)
        {
            return this.SetPiece(col, row, State.Cross);
        }

        /// <summary>
        /// Determines if the piece at the location is a circle.
        /// </summary>
        /// <param name="col">Column of the inquery.</param>
        /// <param name="row">Row of the inquery.</param>
        /// <returns>A value indicating wheither the location contains a circle.</returns>
        public bool IsCircle(int col, int row)
        {
            return this.board[col, row] == State.Circle;
        }

        /// <summary>
        /// Determines if the piece at the location is a cross.
        /// </summary>
        /// <param name="col">Column of the inquery.</param>
        /// <param name="row">Row of the inquery.</param>
        /// <returns>A value indicating wheither the location contains a cross.</returns>
        public bool IsCross(int col, int row)
        {
            return this.board[col, row] == State.Cross;
        }

        /// <summary>
        /// Determines if a game is finished.
        /// </summary>
        /// <returns>A value indicating wheither the game is finished.</returns>
        public bool IsFinished()
        {
            if (//rows
                this.board[0, 0] == this.board[0, 1] && this.board[0, 0] == this.board[0, 2]
                || this.board[1, 0] == this.board[1, 1] && this.board[1, 0] == this.board[1, 2]
                || this.board[2, 0] == this.board[2, 1] && this.board[2, 0] == this.board[2, 2]
                // collumns
                || this.board[0, 0] == this.board[1, 0] && this.board[0, 0] == this.board[2, 0]
                || this.board[0, 1] == this.board[1, 1] && this.board[0, 1] == this.board[2, 1]
                || this.board[0, 2] == this.board[1, 2] && this.board[0, 2] == this.board[2, 2]
                // diagnals
                || this.board[1, 1] == this.board[0, 0] && this.board[0, 0] == this.board[2, 2]
                || this.board[1, 1] == this.board[2, 0] && this.board[1, 1] == this.board[0, 2])
            {
                return true;
            }

            for (var row = 0; row < 3; row++)
                for (var col = 0; col < 3; col++)
                    if (this.board[col, row] == State.Empty)
                        return false;

            // full board
            return true;
        }

        #endregion

        #region [ Private Helpers ]

        private bool SetPiece(int col, int row, State state)
        {
            if (this.board[row, col] != State.Empty)
                return false;

            this.board[row, col] = state;
            return true;
        } 

        #endregion
    }
}