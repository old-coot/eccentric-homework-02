using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed;
    public float RoatationSpeed;
    private int _speedMultiplier = 1;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        _speedMultiplier = Input.GetKey(KeyCode.LeftShift) ? 3 : 1;
        
        Vector3 offset = new Vector3(h, 0, v) * Speed * Time.deltaTime * _speedMultiplier;
        transform.Translate(offset);

        float yRotation = Input.GetAxis("Mouse X");
        
        transform.Rotate(0, -yRotation * RoatationSpeed *Time.deltaTime, 0);

        
        
    }
}
