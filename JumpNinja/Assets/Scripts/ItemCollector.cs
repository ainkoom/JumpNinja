using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int gold = 0;
    //[SerializeField] Text LifeLeft;
    [SerializeField] Text goldText;
    [SerializeField] AudioSource collectionSound;
    //public GameObject playerLife;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Gold"))
        {
            Destroy(other.gameObject);
            gold++;
            goldText.text = "Gold : " + gold;
            collectionSound.Play();
            //Debug.Log("Gold : " + gold);
        }

        else if (other.gameObject.CompareTag("ExtraLife"))
        {
            Destroy(other.gameObject);
            PlayerLife.playerLife.addExtraLife();
            //PlayerLife.addExtraLife(LifeLeft);
        }

        else if (other.gameObject.CompareTag("Tip"))
        {
            Destroy(other.gameObject);
            StartCoroutine(DisplayTip());
            //PlayerLife.addExtraLife(LifeLeft);
        }
    }

    IEnumerator DisplayTip()
    {
        PlayerLife.playerLife.tipText.text = StartGameMenu.tip;
        yield return new WaitForSeconds(5);
        PlayerLife.playerLife.tipText.text = "";
    }
}
