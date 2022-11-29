using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallFungus : MonoBehaviour
{
    public Fungus.Flowchart myFlowchart; // Link the Flowchart in your script
    private float hitCount = 0;
    public GameObject firework;
    // Start is called before the first frame update
    void Start()
    {
       //Instantiate(firework, new Vector3(0, 1.1f, 4.3f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
            Debug.Log (hitCount);
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.name == "upperbody")
        {
            Instantiate(firework, new Vector3(0, 1.1f, 4.3f), Quaternion.identity);
            if (hitCount == 0){
                //Debug.Log ("Head Hit");
                myFlowchart.ExecuteBlock("1-3 (R)"); 
                hitCount = 1;
            }
            if (hitCount == 1){
                myFlowchart.ExecuteBlock("1-4(J)");
                hitCount = 2;
            }
            if (hitCount == 2){
                myFlowchart.ExecuteBlock("1-5(J)");
                hitCount = 3;
            }
        }
    }

    IEnumerator ExampleCoroutine()
    {  
        yield return new WaitForSeconds(5);
    }

    
}
