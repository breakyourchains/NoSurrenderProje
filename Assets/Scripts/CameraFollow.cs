using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    private Vector3 desiredPosition;


    private void Start()
    {
        offset.z = 5;
        offset.y = 8;
    }


    private void Update ()
    {
        
        
        desiredPosition = target.position + offset;
        transform.position = desiredPosition;
        transform.LookAt(target);
        
    }
}
