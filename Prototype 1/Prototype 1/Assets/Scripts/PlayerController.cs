// Similar to import or require
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The : means that PlayerController inherits from MonoBehaviour
public class PlayerController : MonoBehaviour
{
    // Need to add the 'f' at the end so the computer understands it's a float
    public float speed = 5.0f;

    // Public can be edited in Unity, private can't
    public float turnSpeed;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        // Move the vehicle forward
        // Time.deltaTime is the relative time between frames
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
