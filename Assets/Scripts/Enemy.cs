using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public enum EnemyType { BigEnemy,SimpleEnemy}
public class Enemy : MonoBehaviour
{
    public GameObject player;
    private NavMeshAgent agent;
    public EnemyType enemyType;

    public float enemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(player.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

}
