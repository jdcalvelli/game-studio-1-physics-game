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
    [SerializeField] private GameObject romeoSword;
    [SerializeField] private GameObject rosalindSword;
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col);
        if (col.gameObject.name == "TempSword")
        {
            col.gameObject.SetActive(false);
            romeoSword.SetActive(true);

            StartCoroutine(ActivateRosalindController());
            
            flowchart.SendFungusMessage("PickedUpSword");
            
            StartCoroutine(ActivateTriggers());
        }
    }
    
    private IEnumerator ActivateRosalindController()
    {
        yield return new WaitForSeconds(2f);
        rosalindControllerReference.enabled = true;
    }

    private IEnumerator ActivateTriggers()
    {
        yield return new WaitForSeconds(8f);
        romeoSword.GetComponent<Collider2D>().isTrigger = true;
        rosalindSword.GetComponent<Collider2D>().isTrigger = true;
    }
}