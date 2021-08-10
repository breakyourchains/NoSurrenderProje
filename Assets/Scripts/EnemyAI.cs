using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    GameObject player;
    NavMeshAgent enemy;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if(player == null)
        {
            Debug.Log("asdasd");
        }

        enemy = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        if(player != null)
        {
            enemy.destination = player.transform.position;
        }
    }
}
