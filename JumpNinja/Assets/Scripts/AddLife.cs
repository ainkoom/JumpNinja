using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLife : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        LifeControl.health += 1;
    }
}
