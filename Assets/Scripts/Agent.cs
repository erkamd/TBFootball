using UnityEngine;

public class Agent : MonoBehaviour
{
    public AgentStats stats = new AgentStats();
    public Vector2Int Position { get; private set; }
    public bool HasBall { get; set; }

    public void Initialize(Vector2Int startPos)
    {
        Position = startPos;
        transform.position = new Vector3(startPos.x, 0, startPos.y);
    }

    public void Move(Vector2Int direction)
    {
        Position += direction;
        transform.position = new Vector3(Position.x, 0, Position.y);
    }
}
