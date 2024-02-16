using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private Transform _playerTransform;
    public float rotationSpeed = 200f;
    void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().gameObject.transform;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, _playerTransform.position);
        if (distance < 1f)
        {
            FindObjectOfType<CoinCounter>().CoinsCount -= 1;
            Destroy(gameObject);
        }

        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

    }
}
