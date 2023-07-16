using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class AI : MonoBehaviour
{
    public float speed;

    private void FixedUpdate()
    {
        if (GameObject.FindGameObjectsWithTag("Ball").Length == 0)
        {
            return;
        }
        float newY = Mathf.Lerp(transform.position.y, GameObject.FindGameObjectsWithTag("Ball")[0].transform.position.y, speed * Time.deltaTime);
        transform.position = new Vector2(transform.position.x, newY);
    }
}
