using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject lastHitter;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(x  * 4f, y * 4f);
    }

    void Update()
    {
        if (rb.velocity.sqrMagnitude < 2f)
        {
            rb.AddForce(Vector2.up * Random.Range(-1, 3), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("AI"))
        {
            lastHitter = collision.gameObject;
        }

        rb.AddForce(Vector2.up * Random.Range(-1, 3), ForceMode2D.Impulse);
    }
}
