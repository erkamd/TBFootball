using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public List<Agent> teamA = new List<Agent>();
    public List<Agent> teamB = new List<Agent>();

    int currentTeam = 0;
    int currentIndex = 0;

    public Agent CurrentAgent => currentTeam == 0 ? teamA[currentIndex] : teamB[currentIndex];

    public void StartMatch()
    {
        currentTeam = 0;
        currentIndex = 0;
        SetActiveAgent(CurrentAgent, true);
    }

    public void EndTurn()
    {
        SetActiveAgent(CurrentAgent, false);

        currentIndex++;
        if (currentTeam == 0 && currentIndex >= teamA.Count)
        {
            currentTeam = 1;
            currentIndex = 0;
        }
        else if (currentTeam == 1 && currentIndex >= teamB.Count)
        {
            currentTeam = 0;
            currentIndex = 0;
        }

        SetActiveAgent(CurrentAgent, true);
    }

    void SetActiveAgent(Agent agent, bool active)
    {
        // highlight or enable input for agent
    }
}
