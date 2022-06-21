using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            StartGameMenu.level ++;
            if (StartGameMenu.level > StartGameMenu.finalLevel)
            {
                SceneManager.LoadScene(StartGameMenu.EndScreen);
            }
            else
            {
                SceneManager.LoadScene($"Scenes/Level{StartGameMenu.level}");
            }
                
        }
    }
}
