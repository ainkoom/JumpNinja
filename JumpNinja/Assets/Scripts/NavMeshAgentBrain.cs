using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentBrain : MonoBehaviour
{
    public bool ShouldIMove;
    public GameObject Point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ShouldIMove == true)
        {
            GetComponent<NavMeshAgent>().SetDestination(Point.transform.position);
        }
    }
}
