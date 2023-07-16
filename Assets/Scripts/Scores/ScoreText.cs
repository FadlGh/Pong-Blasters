using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private Score score;
    [SerializeField] private TextMeshProUGUI text;

    void Update()
    {
        text.text = score.score.ToString();
    }
}
