using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RosalindController : MonoBehaviour
{
    // move her arm nidhogg style between three positions
    // every few seconds, randomly switch between positions, tween over to new one

    [SerializeField] private float timeToWait;
    [SerializeField] private SpringJoint2D swordString;

    private void Start()
    {
        StartCoroutine(SetSwordString());
    }
    

    private IEnumerator SetSwordString()
    {
        swordString.distance = Random.Range(2, 5);
        Debug.Log(swordString.distance);
        yield return new WaitForSeconds(timeToWait);

        StartCoroutine(SetSwordString());
    }
}
