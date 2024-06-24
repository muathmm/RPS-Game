# Rock-Paper-Scissors Game

This console application implements the classic game of Rock-Paper-Scissors. Players can compete against an AI opponent, making moves and determining the winner based on game rules.
## Features

- **Single-Player Mode**: Player vs AI.
- **Gameplay**: Players choose rock, paper, or scissors.
- **Round Management**: Compares moves and declares winners.
- **Score Tracking**: Updates scores and displays results.
- **Exception Handling**: Manages errors like invalid inputs.
- **Game End Condition**: Ends when any player reaches 3 points.
## Program Structure

- **Program.cs**: Entry point, manages game flow.
- **Player.cs**: Player class for move selection.
- **AIPlayer.cs**: AI opponent class with random move generation.
- **RPSGame.cs**: Game logic for move comparison and scoring.
## Methods

- **Player Class**:
  - `ChooseMove()`: Player selects rock, paper, or scissors.

- **AIPlayer Class**:
  - `ChooseMove()`: AI selects a random move.

- **RPSGame Class**:
  - `CompareMoves(string move1, string move2)`: Compares player and AI moves to determine round winners.
  - `PlayGame()`: Controls overall game flow including rounds, scoring, and winner declaration.
  - `DisplayScores()`: Shows scores after each round and declares the overall winner.
## Usage

1. **Clone Repository**: `https://github.com/muathmm/RPS-Game`
2. **Navigate to Directory**: `cd Rock-Paper-Scissors`
3. **Build and Run**: `dotnet run`
## Unit Tests

- **Run Tests**: `dotnet test`
- **Coverage**:
  - Move comparisons: rock vs scissors, paper vs rock, etc.
  - Score updates and end game conditions.
  - Handling invalid inputs and exceptions.
