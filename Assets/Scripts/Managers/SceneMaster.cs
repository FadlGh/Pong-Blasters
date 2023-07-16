using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class SceneMaster : MonoBehaviour
{
    [SerializeField] private TMP_Text invertedText;
    [SerializeField] private TMP_Text winnerText;
    [SerializeField] private GameObject winningScreen;

    public void OpenScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ShowInvertedText()
    {
        invertedText.text = "Scores Inverted !";
    }

    public void RemoveInvertedText()
    {
        invertedText.text = "";
    }

    public void ShowWinningScreen(string winnerName) 
    {
        winnerText.text = winnerName + "Wins !!";
        winningScreen.SetActive(true);
    }
}
