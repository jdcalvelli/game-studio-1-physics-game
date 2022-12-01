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
        if (Input.GetKey(KeyCode.N))
        {
            fingerRigidbodies[0].AddForce(transform.up * fingerForce);
        }
        
        if (Input.GetKey(KeyCode.J))
        {
            fingerRigidbodies[1].AddForce(transform.up * fingerForce);
        }
        
        if (Input.GetKey(KeyCode.K))
        {
            fingerRigidbodies[2].AddForce(transform.up * fingerForce);
        }
        
        if (Input.GetKey(KeyCode.L))
        {
            fingerRigidbodies[3].AddForce(transform.up * fingerForce);
        }
    }
    
}