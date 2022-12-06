using System;
using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class BladeController : MonoBehaviour
{

    [SerializeField] private Collider2D romeoBlade;
    [SerializeField] private Collider2D rosalindBlade;

    [SerializeField] private Flowchart flowchart;
    [SerializeField] private List<string> fungusMessages;

    //dont like this
    public int enemyHitCounter;

    [SerializeField] private GameObject bloodstainPrefabReference;
    [SerializeField] private GameObject enemyHitboxReference;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == enemyHitboxReference.name)
        {
            Debug.Log("blade collision");
            // bloodstain instantiation
            StartCoroutine(CreateAndDestroyBloodstain(bloodstainPrefabReference, col.transform));
            //play message
            if (enemyHitCounter < 3)
            {
                flowchart.SendFungusMessage(fungusMessages[enemyHitCounter]);
                enemyHitCounter++;
            }
            // turn BOTH trigger off for a certain period of time basically after this
            StartCoroutine(BladeTriggersOff(romeoBlade, rosalindBlade));
        }
    }

    private IEnumerator CreateAndDestroyBloodstain(GameObject bloodstainPrefab, Transform colliderTransform)
    {
        GameObject bloodstainInstance = Instantiate<GameObject>(bloodstainPrefab, colliderTransform);
        yield return new WaitForSeconds(1f);
        Destroy(bloodstainInstance);
    }

    private IEnumerator BladeTriggersOff(Collider2D romeoBlade, Collider2D rosalindBlade)
    {
        romeoBlade.isTrigger = false;
        rosalindBlade.isTrigger = false;
        yield return new WaitForSeconds(5f);
        romeoBlade.isTrigger = true;
        rosalindBlade.isTrigger = true;
    }
}
