﻿// -----------------------------------------------------------------------
// <copyright file="LeftTurnCommand.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Rover.Command
{
    /// <summary>
    ///     TODO: Update summary.
    /// </summary>
    public class LeftTurnCommand : ICommand
    {
        public void Execute(RoverObject rover)
        {
            rover.LeftTurn();
        }
    }
}