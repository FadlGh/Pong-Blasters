using System.Collections;
using TMPro;
using UnityEngine;

public class InvertScores : PowerUp
{
    protected override void Apply(GameObject collision)
    {
        GameObject.FindGameObjectWithTag("SM").GetComponent<SceneMaster>().ShowInvertedText();
        GameObject[] ScoreWalls = GameObject.FindGameObjectsWithTag("ScoreWall");

        for (int i = 0; i < ScoreWalls.Length; i++)
        {
            ScoreWalls[i].GetComponent<ScoreWall>().isInverted = true;
        }

        StartCoroutine(ReturnDefault(collision));
    }

    private IEnumerator ReturnDefault(GameObject collision)
    {
        GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(10f);

        GameObject[] ScoreWalls = GameObject.FindGameObjectsWithTag("ScoreWall");

        for (int i = 0; i < ScoreWalls.Length; i++)
        {
            ScoreWalls[i].GetComponent<ScoreWall>().isInverted = false;
        }

        GameObject.FindGameObjectWithTag("SM").GetComponent<SceneMaster>().RemoveInvertedText();

        Destroy(gameObject);
    }
}
