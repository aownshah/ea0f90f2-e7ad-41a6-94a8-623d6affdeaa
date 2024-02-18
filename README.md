## Overview

The Longest Increasing Subsequence (LIS) program is a console application that computes the longest increasing subsequence from a given sequence of integers, employing a dynamic programming approach for efficiency and accuracy.

**Source Code:** [GitHub Repository](https://github.com/aownshah/ea0f90f2-e7ad-41a6-94a8-623d6affdeaa)

## How to Run

### Prerequisites

- .NET 7 SDK
- A code editor (Visual Studio, Visual Studio Code, or JetBrains Rider)

### Steps to Run

1. **Open the Project:** Open `LongestIncreasingSubsequence.ConsoleApp` project in your IDE.
2. **Navigate to the Project Directory:** Use terminal or command prompt to navigate to the project directory.
3. **Build the Project:** Run `dotnet build`.
4. **Run the Program:** Execute `dotnet run --project LongestIncreasingSubsequence.ConsoleApp`.

### Input and Output

- **Input:** A string of integers separated by single whitespace (e.g., `3 10 2 1 20`).
- **Output:** Calculates and displays the LIS (e.g., `Result: 3 10 20`).

## Understanding the Program Components

- `LongestIncreasingSubsequenceInputParser`: Parses console input into integers.
- `LongestIncreasingSubsequenceFactory`: Creates LIS calculation strategy instances.
- `LongestIncreasingSubsequenceDynamicProgrammingStrategy`: Implements dynamic programming for LIS.
- `Interfaces`: Defines the LIS strategy contract.

## Unit Testing

- **Project:** `LongestIncreasingSubsequence.Core.Test` contains unit tests for the LIS program.

## GitHub Continuous Integration Workflow

- **Workflow File:** `.github/workflows/dotnet-ci.yml`
- **Features:** Automated building, testing, code coverage reports, and Docker image publishing.

### Workflow Configuration

- **Trigger:** Manually triggered (`workflow_dispatch`).
- **Environment:** Runs on `ubuntu-latest` with Docker.
- **Steps:** Includes checkout, .NET setup, dependency restoration, build, test, and Docker publishing.

