using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreWall : MonoBehaviour
{
    [SerializeField] private Score player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.score += 1;
        print("sss");
        Destroy(collision.gameObject);
    }

}
