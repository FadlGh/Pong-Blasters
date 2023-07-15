using System.Collections;
using UnityEngine;

public class SpeedIncrease : PowerUp
{
    [SerializeField] float speedIncreaseFactor;

    protected override void Apply(GameObject collision)
    {
        GameObject target = collision.GetComponent<Ball>().lastHitter;

        if (target.CompareTag("AI"))
        {
            target.GetComponent<AI>().speed += speedIncreaseFactor;
        }
        else
        {
            target.GetComponent<PlayerController>().speed += speedIncreaseFactor;
        }

        StartCoroutine(ReturnDefault(target));
    }

    private IEnumerator ReturnDefault(GameObject target)
    {
        GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(1);
        
        if (target.CompareTag("AI"))
        {
            target.GetComponent<AI>().speed -= speedIncreaseFactor;
            print(target.GetComponent<AI>().speed);
        }
        else
        {
            target.GetComponent<PlayerController>().speed -= speedIncreaseFactor;
        }
        Destroy(gameObject);
    }
}
