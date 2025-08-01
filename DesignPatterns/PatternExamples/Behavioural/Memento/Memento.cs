﻿namespace DesignPatterns.PatternExamples.Behavioural.Memento;

internal class Memento: IPatternExample
{
    public void Demonstrate( )
    {
        Console.WriteLine( "Playing a chess game:\n" );
        GameProgress progress = new( );
        ChessGame game = new( progress );

        game.MakeMove( Colour.White, "d4" );
        game.MakeMove( Colour.Black, "Nf6" );
        game.MakeMove( Colour.White, "c4" );
        game.MakeMove( Colour.Black, "d6" );

        game.ListAllMoves( );

        Console.WriteLine( "\nUndoing a move\n" );

        game.UndoMove( );
        game.ListAllMoves( );

        Console.WriteLine( "\nUndoing a move\n" );

        game.UndoMove( );
        game.ListAllMoves( );

        Console.WriteLine( "\nRedoing a move\n" );

        game.RedoMove( );
        game.ListAllMoves( );
    }
}