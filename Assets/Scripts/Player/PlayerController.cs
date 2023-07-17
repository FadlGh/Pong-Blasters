using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    [SerializeField] private string inputY;

    private Rigidbody2D rb;
    private float vertical;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        vertical = Input.GetAxis(inputY);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
    }
}
