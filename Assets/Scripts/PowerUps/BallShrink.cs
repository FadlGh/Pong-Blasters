using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShrink : PowerUp
{
    [SerializeField] float SizeIncreaseFactor;

    protected override void Apply(GameObject collision)
    {
        collision.transform.localScale += new Vector3(SizeIncreaseFactor, SizeIncreaseFactor, 0);

        StartCoroutine(ReturnDefault(collision));
    }

    private IEnumerator ReturnDefault(GameObject collision)
    {
        GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(3f);

        collision.transform.localScale -= new Vector3(SizeIncreaseFactor, SizeIncreaseFactor, 0);

        Destroy(gameObject);
    }
}
