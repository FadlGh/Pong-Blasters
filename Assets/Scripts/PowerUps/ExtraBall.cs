using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBall : PowerUp
{
    [SerializeField] private GameObject ball;

    protected override void Apply(GameObject collision)
    {
        Instantiate(ball, new Vector2(0f, 0f), Quaternion.identity);
        Destroy(gameObject);
    }
}
