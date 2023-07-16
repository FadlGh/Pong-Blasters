using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreWall : MonoBehaviour
{
    [SerializeField] private Score player;
    [SerializeField] private Score player2;

    public bool isInverted;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isInverted)
        {
            player2.score += 1;
            Destroy(collision.gameObject);
            return;
        }
        player.score += 1;
        Destroy(collision.gameObject);
    }

}
