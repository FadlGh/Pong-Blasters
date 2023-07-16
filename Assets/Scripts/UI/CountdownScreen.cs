using System.Collections;
using UnityEngine;
using TMPro;

public class CountdownScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI countdownText;
    [SerializeField] private GameObject powerUpsSpawner;

    private void Start()
    {
        StartCoroutine(StartCountdown());
    }

    private IEnumerator StartCountdown()
    {
        int countdownValue = 3;
        countdownText.text = countdownValue.ToString();

        yield return new WaitForSeconds(1f);

        while (countdownValue > 1)
        {
            countdownValue--;
            countdownText.text = countdownValue.ToString();
            yield return new WaitForSeconds(1f);
        }

        countdownText.text = "GO!";

        yield return new WaitForSeconds(1f);
        countdownText.text = "";
        StartGame();
    }

    private void StartGame()
    {
        powerUpsSpawner.SetActive(true);
    }
}
