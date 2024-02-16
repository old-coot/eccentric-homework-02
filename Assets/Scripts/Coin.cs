using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Transform PlayerTransform;
    void Start()
    {
        PlayerTransform = FindObjectOfType<PlayerMove>().gameObject.transform;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, PlayerTransform.position);
        Debug.Log(distance);
        if (distance < 0.8f)
        {
            Destroy(gameObject);
        }
    }
}
