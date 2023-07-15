using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            Apply(collision.gameObject);
        }
    }

    protected abstract void Apply(GameObject collision);
}
