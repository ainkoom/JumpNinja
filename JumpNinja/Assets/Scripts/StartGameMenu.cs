using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameMenu : MonoBehaviour
{
    public static int level = 1;
    public static int finalLevel = 2;
    public static int MaxlifeLeft = 3;
    public static int lifeLeft = MaxlifeLeft;
    public static string DiedScreen = "Scenes/DiedScreen"; 
    public static string StartScreen = "Scenes/StartScreen";
    public static string EndScreen = "Scenes/EndScreen";

    public void StartGame()
    {
        SceneManager.LoadScene(StartGameMenu.StartScreen);
    }

}
