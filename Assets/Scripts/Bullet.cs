using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<Enemy>().enemyHealth -= 100;
            if(other.gameObject.GetComponent<Enemy>().enemyHealth <= 0)
            {
                Destroy(other.gameObject);
            }
            Destroy(gameObject);
        }
    }
}
