using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;

    void Update()
    {
        if (score == 10)
        {
            GameObject.FindGameObjectWithTag("SM").GetComponent<SceneMaster>().ShowWinningScreen(gameObject.name);
        }
    }
}
