using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HandController : MonoBehaviour
{
    [SerializeField] private float fingerForce;
    [SerializeField] private List<Rigidbody2D> fingerRigidbodies;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            fingerRigidbodies[0].AddForce(transform.up * fingerForce);
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            fingerRigidbodies[1].AddForce(transform.up * fingerForce);
        }
        
        if (Input.GetKey(KeyCode.O))
        {
            fingerRigidbodies[2].AddForce(transform.up * fingerForce);
        }
        
        if (Input.GetKey(KeyCode.P))
        {
            fingerRigidbodies[3].AddForce(transform.up * fingerForce);
        }
    }
    
}