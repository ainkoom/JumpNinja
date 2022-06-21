using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGameMenu : MonoBehaviour
{
    public void RestartGame()
    {
        StartGameMenu.lifeLeft = StartGameMenu.MaxlifeLeft;
        SceneManager.LoadScene($"Scenes/Level{StartGameMenu.level}");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
