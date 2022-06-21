using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduceLife : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        LifeControl.health -= 1;
    }
}
