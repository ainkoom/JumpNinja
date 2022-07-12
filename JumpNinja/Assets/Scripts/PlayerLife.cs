using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public GameObject L1, L2, L3;
    [SerializeField] AudioSource deadSound;
    [SerializeField] public Text tipText; 
    bool dead = false;
    public static PlayerLife playerLife;

     void Start()
    {
        playerLife = this;
        lifeUpdate();
        //LifeLeft.text = $"x {StartGameMenu.lifeLeft}";
    }
    private void Update()
    {
        if (transform.position.y < -1f && !dead)
        {
            Die();
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyBody"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false;
            Die();
        }
    }
        void Die()
        {
            Invoke(nameof(ReloadLevel), 1.3f);
            dead = true;
            deadSound.Play();
            StartGameMenu.lifeLeft --;
            //LifeLeft.text = $"x {StartGameMenu.lifeLeft}";
            lifeUpdate();
            if (StartGameMenu.lifeLeft < 1)
            {
                SceneManager.LoadScene(StartGameMenu.DiedScreen2);
            }
        //lf.ReduceLife(gameObject);
        //LifeControl.health -= 1;
    }

    public void addExtraLife ()
    {
        StartGameMenu.lifeLeft++;
        lifeUpdate();
        //lifeLeftText.text = $"x {StartGameMenu.lifeLeft}";
    }


    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void lifeUpdate()
    {
        if (StartGameMenu.lifeLeft > StartGameMenu.MaxlifeLeft)
            StartGameMenu.lifeLeft = StartGameMenu.MaxlifeLeft;

        switch (StartGameMenu.lifeLeft)
        {
            case 3:
                L1.gameObject.SetActive(true);
                L2.gameObject.SetActive(true);
                L3.gameObject.SetActive(true);
                break;

            case 2:
                L1.gameObject.SetActive(true);
                L2.gameObject.SetActive(true);
                L3.gameObject.SetActive(false);
                break;

            case 1:
                L1.gameObject.SetActive(true);
                L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(false);
                break;

            case 0:
                L1.gameObject.SetActive(false);
                L2.gameObject.SetActive(true);
                L3.gameObject.SetActive(false);
                break;
        }
    }

}
