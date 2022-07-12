using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{

    public float speed;
    public float range;
    public float maxDistance;

    public Transform player;
    private Vector2 wayPoint;

    public enum ENEMY_STATE
    {
        Wander,
        Attack,
        Nothing,
    }

    public ENEMY_STATE enemyState;
    void Start()
    {
        SetNewDestination();
    }

    // Update is called once per frame
     void Update()
    {
        switch (enemyState)
        {
            case ENEMY_STATE.Wander:
                transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
                if (Vector2.Distance(transform.position, wayPoint) < range)
                {
                    SetNewDestination();
                }
                if (Input.GetKey(KeyCode.J))
                {
                    enemyState = ENEMY_STATE.Attack;
                }
                if (Input.GetKey(KeyCode.K))
                {
                    enemyState = ENEMY_STATE.Nothing;
                }
                break;

            case ENEMY_STATE.Attack:
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
                if (Input.GetKey(KeyCode.H))
                {
                    enemyState = ENEMY_STATE.Wander;
                }
                if (Input.GetKey(KeyCode.K))
                {
                    enemyState = ENEMY_STATE.Nothing;
                }
                break;

            case ENEMY_STATE.Nothing:
                Debug.Log("Doing Nothing Now");
                if (Input.GetKey(KeyCode.H))
                {
                    enemyState = ENEMY_STATE.Wander;
                }
                if (Input.GetKey(KeyCode.K))
                {
                    enemyState = ENEMY_STATE.Nothing;
                }
                if (Input.GetKey(KeyCode.J))
                {
                    enemyState = ENEMY_STATE.Attack;
                }
                break;
        }
    }

     void SetNewDestination()
    {
        wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
        //GetComponent<NavMeshAgent>().SetDestination(Point.transform.position);
    }

}
