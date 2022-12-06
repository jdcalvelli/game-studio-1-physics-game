using System;
using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class HiltTriggerController : MonoBehaviour
{

    [SerializeField] private Flowchart flowchart;
    
    //THIS SHOULD BE REWRITTEN INTO A GAME MANAGER BUT NO TIME
    [SerializeField] private RosalindController rosalindControllerReference;
    [SerializeField] private GameObject swordInHand;
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col);
        if (col.gameObject.name == "TempSword")
        {
            col.gameObject.SetActive(false);
            swordInHand.SetActive(true);

            StartCoroutine(ActivateRosalindController());
            
            flowchart.SendFungusMessage("PickedUpSword");
        }
    }
    
    private IEnumerator ActivateRosalindController()
    {
        yield return new WaitForSeconds(2f);
        rosalindControllerReference.enabled = true;
    }
}