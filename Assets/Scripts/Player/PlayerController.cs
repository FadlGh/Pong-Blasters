using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private string inputX;
    [SerializeField] private string inputY;

    private Rigidbody2D rb;
    private float horizontal;
    private float vertical;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis(inputX);
        vertical = Input.GetAxis(inputY);
    }
    void FixedUpdate()
    {
        Vector2 movement = new Vector2(horizontal, vertical);

        rb.velocity = movement * speed;

        if (movement == Vector2.zero)
        {
            rb.velocity = Vector2.Lerp(rb.velocity, Vector2.zero, speed * Time.deltaTime);
        }
    }
}
