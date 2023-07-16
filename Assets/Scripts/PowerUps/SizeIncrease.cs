using System.Collections;
using UnityEngine;

public class SizeIncrease : PowerUp
{
    [SerializeField] float SizeIncreaseFactor;

    protected override void Apply(GameObject collision)
    {
        GameObject target = collision.GetComponent<Ball>().lastHitter;

        if (target == null) { return; }

        target.transform.localScale += new Vector3(SizeIncreaseFactor, SizeIncreaseFactor, 0);

        StartCoroutine(ReturnDefault(target));
    }

    private IEnumerator ReturnDefault(GameObject target)
    {
        GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(3f);

        target.transform.localScale -= new Vector3(SizeIncreaseFactor, SizeIncreaseFactor, 0);

        Destroy(gameObject);
    }
}
