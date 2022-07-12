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
    public static string DiedScreen2 = "Scenes/DiedScreen2"; 
    public static string StartScreen = "Scenes/StartScreen";
    public static string EndScreen = "Scenes/EndScreen";
    public static bool tipDisplayed = false;
    public static string tip = "TIP 1: TAKE ALL GREEN FOOD TO GET EXTRA LIFE";
    public void StartGame()
    {
        StartGameMenu.lifeLeft = StartGameMenu.MaxlifeLeft;
        SceneManager.LoadScene($"Scenes/Level{StartGameMenu.level}");
    }


}
