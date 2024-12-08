# Unexpected Mutability in F# Function Arguments

This repository demonstrates a common, yet subtle, bug in F# related to the behavior of mutable variables when passed as arguments to functions.  In F#, mutable variables are passed by reference, which can lead to unexpected side effects and difficulties in debugging if not carefully handled.

## The Bug
The `bug.fs` file contains code showcasing the issue.  The `add` function modifies the input variable `x` directly. While this might seem straightforward, it can create problems in larger codebases.

## The Solution
The `bugSolution.fs` file presents a solution by utilizing immutability and function composition for cleaner, more predictable code.

## How to Run
1. Clone this repository.
2. Open the `.fs` files in a F# environment (e.g., Visual Studio, .NET Interactive).
3. Execute the code to observe the behavior and the corrected solution.