using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2Int Position { get; private set; }

    public void Place(Vector2Int pos)
    {
        Position = pos;
        transform.position = new Vector3(pos.x, 0.5f, pos.y);
    }
}
