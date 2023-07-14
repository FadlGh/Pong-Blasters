using UnityEngine;

public class AI : MonoBehaviour
{
    public GameObject ball;
    public float paddleSpeed = 5f;

    private void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x, ball.transform.position.y);
    }
}
