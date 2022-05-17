using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;

    public void UserNameEntered(string name)
    {
        DataManager.Instance.currentName = name;
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenScoreBoard()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
        DataManager.Instance.SavePlayData();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
