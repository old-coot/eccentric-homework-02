using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed;
    public float RoatationSpeed;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 offset = new Vector3(h, 0, v) * Speed * Time.deltaTime;
        transform.Translate(offset);

        float yRotation = Input.GetAxis("Mouse X");
        
        Debug.Log(yRotation);
        transform.Rotate(0, -yRotation * RoatationSpeed *Time.deltaTime, 0);
        
        // if (Input.GetKeyDown())
        
        
    }
}
