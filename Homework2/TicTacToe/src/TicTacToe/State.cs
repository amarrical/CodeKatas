//-----------------------------------------------------------------------
// <copyright file="State.cs" company="ImprovingEnterprises">
//     Copyright (c) ImprovingEnterprises. All rights reserved.
// </copyright>
// <author>Anthony Marrical</author>
//-----------------------------------------------------------------------
namespace TicTacToe
{
    /// <summary>
    /// State for a location on the board.
    /// </summary>
    public enum State
    {
        /// <summary>
        /// Location is empty.
        /// </summary>
        Empty,

        /// <summary>
        /// Location has a circle.
        /// </summary>
        Circle,

        /// <summary>
        /// Location has a cross.
        /// </summary>
        Cross
    }
}