using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TurnManager turnManager;
    public Ball ball;

    void Start()
    {
        // Setup starting positions
        turnManager.teamA[0].Initialize(new Vector2Int(2, 3));
        turnManager.teamA[1].Initialize(new Vector2Int(2, 5));
        turnManager.teamA[2].Initialize(new Vector2Int(2, 7));

        turnManager.teamB[0].Initialize(new Vector2Int(17, 3));
        turnManager.teamB[1].Initialize(new Vector2Int(17, 5));
        turnManager.teamB[2].Initialize(new Vector2Int(17, 7));

        ball.Place(new Vector2Int(Pitch.Width / 2, Pitch.Height / 2));

        turnManager.StartMatch();
    }
}
