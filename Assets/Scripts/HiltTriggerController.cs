using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiltTriggerController : MonoBehaviour
{
    [SerializeField] private GameObject swordInHand;
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col);
        if (col.gameObject.name == "TempSword")
        {
            col.gameObject.SetActive(false);
            swordInHand.SetActive(true);
        }
    }
}
