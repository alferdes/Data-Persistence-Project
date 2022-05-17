using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreBoardUIHandler : MonoBehaviour
{
    public TextMeshProUGUI HighScoreText;
    // Start is called before the first frame update
    void Start()
    {
        HighScoreText.text = $"High Score : {DataManager.Instance.playerName} : {DataManager.Instance.highScore}";
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
