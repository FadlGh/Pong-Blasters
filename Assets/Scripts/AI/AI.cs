using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class AI : MonoBehaviour
{
    public GameObject ball;
    public float speed;

    private void FixedUpdate()
    {
        float newY = Mathf.Lerp(transform.position.y, ball.transform.position.y, speed * Time.deltaTime);
        transform.position = new Vector2(transform.position.x, newY);
    }
}
