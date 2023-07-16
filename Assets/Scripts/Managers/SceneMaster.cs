using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class SceneMaster : MonoBehaviour
{
    [SerializeField] private TMP_Text invertedText;

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
}
