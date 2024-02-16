using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class CoinCounter : MonoBehaviour


{

    public GameObject WinCanvas;
    public int CoinsCount;

    private void Start()
    {
        CoinsCount = FindObjectsOfType<Coin>().Length;
        Debug.Log(CoinsCount);
    }

    void Update()
    {
        if (CoinsCount == 0)
        {
            WinCanvas.SetActive(true);
        }
    }
}
