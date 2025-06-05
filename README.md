# Turn Based Football

This repository contains a small Unity project targeting **Unity 2022.3.54f1**. The goal is to demonstrate a simple turn‑based football prototype played on a 20x10 grid with teams of three agents each.

## Project Structure

Clone or download this repository and open the folder directly in **Unity Hub** (version `2022.3.54f1`). The `ProjectSettings` and `Packages` folders are provided so you can open it without creating a new project.

## Gameplay Overview

- **Pitch Size:** 20 columns by 10 rows
- **Teams:** 3 agents vs 3 agents (no dedicated goal keeper)
- **Stats:** Each agent has `speed`, `kickPower` and `stamina`
- **Turn System:** The `TurnManager` selects one agent at a time to act. After all agents from one team have taken a turn, the other team begins its round.
- **Rogue-like Movement:** Agents occupy grid cells and can move or kick the ball during their turn.

The included scripts implement a bare‑bones version of these rules so you can extend them further in Unity.

## Getting Started

1. Open Unity **2022.3.54f1** and select **Add project** from Unity Hub.
2. Choose the repository folder.
3. Create simple placeholder sprites (e.g. colored squares) under `Assets/Sprites`.
4. The included `Main` scene already contains a basic setup with managers, agents and the ball.
5. Press Play to start the match.

Feel free to build upon these scripts to add visuals, animations and more advanced gameplay logic.
