using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Joystick joystick;
    public GameObject bullet;

    private GameObject tempGO;

    private float fireRate;

    
    void Update()
    {
        fireRate -= Time.deltaTime;

        if(Mathf.Abs(joystick.Horizontal) > 0.5f || Mathf.Abs(joystick.Vertical) > 0.5f)
        {
            if(fireRate < 0)
            {
                Fire();
            }
        }


    }

    private void Fire()
    {
        tempGO = Instantiate(bullet, transform.position, Quaternion.identity);
        tempGO.GetComponent<Rigidbody>().velocity = new Vector3(joystick.Horizontal * 10f, 0f, joystick.Vertical * 10f) * -5f;
        fireRate = 1;
    }


}
