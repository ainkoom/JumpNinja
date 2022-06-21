using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int gold = 0;
    [SerializeField] Text goldText;
    [SerializeField] AudioSource collectionSound;
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
    }
}
