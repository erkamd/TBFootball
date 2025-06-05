# Turn Based Football

This repository contains a small Unity project targeting **Unity 2022.3.54f1**. The goal is to demonstrate a simple turn‑based football prototype played on a 20x10 grid with teams of three agents each.

## Project Structure

```
Assets/
  Scenes/            - Put your Unity scene files here
  Scripts/           - Gameplay scripts
```

The project currently only ships with scripts. Create a new Unity project (version `2022.3.54f1` or newer) and copy the `Assets` folder into your project to try it out.

## Gameplay Overview

- **Pitch Size:** 20 columns by 10 rows
- **Teams:** 3 agents vs 3 agents (no dedicated goal keeper)
- **Stats:** Each agent has `speed`, `kickPower` and `stamina`
- **Turn System:** The `TurnManager` selects one agent at a time to act. After all agents from one team have taken a turn, the other team begins its round.
- **Rogue-like Movement:** Agents occupy grid cells and can move or kick the ball during their turn.

The included scripts implement a bare‑bones version of these rules so you can extend them further in Unity.

## Getting Started

1. Create a new project in Unity **2022.3.54f1**.
2. Copy this repository's `Assets` folder into your Unity project.
3. Create a scene and place the `GameManager`, `TurnManager`, agents and ball prefabs in the hierarchy.
4. Press Play to start the match.

Feel free to build upon these scripts to add visuals, animations and more advanced gameplay logic.
