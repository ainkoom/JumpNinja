using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeControl : MonoBehaviour
{
    public GameObject Life1, Life2, Life3;
    public static int health;
    // Start is called before the first frame update
    public void Start()
    {
        health = 3;
        Life1.gameObject.SetActive (true);
        Life2.gameObject.SetActive (true);
        Life3.gameObject.SetActive (true);
    }

    // Update is called once per frame
    void Update()
    {
		if (health > 3)
			health = 3;

		switch (health)
		{
			case 3:
				Life1.gameObject.SetActive(true);
				Life2.gameObject.SetActive(true);
				Life3.gameObject.SetActive(true);
				break;

			case 2:
				Life1.gameObject.SetActive(true);
				Life2.gameObject.SetActive(true);
				Life3.gameObject.SetActive(false);
				break;

			case 1:
				Life1.gameObject.SetActive(true);
				Life2.gameObject.SetActive(false);
				Life3.gameObject.SetActive(false);
				break;

			case 0:
				Life1.gameObject.SetActive(false);
				Life2.gameObject.SetActive(true);
				Life3.gameObject.SetActive(false);
				break;
		}
	}
}
