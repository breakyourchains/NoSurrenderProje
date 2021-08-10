using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
     public Joystick joystick;
    
    
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joystick.Horizontal * 10f, rigidbody.velocity.y, joystick.Vertical * 10f) * -1;
    }
}
