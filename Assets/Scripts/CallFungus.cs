using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallFungus : MonoBehaviour
{
    public Fungus.Flowchart myFlowchart; // Link the Flowchart in your script
    private float hitCount = 0;
    public GameObject firework;

    enum canCollideStates
    {
        canCollide,
        cannotCollide,
    }

    private canCollideStates ccs = canCollideStates.canCollide;

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
        if (ccs == canCollideStates.canCollide && collision.gameObject.name == "upperbody")
        {
            
            // call create and destrooy confetti instead
            StartCoroutine(CreateAndDestroyConfetti());
            
            if (hitCount == 0){
                //Debug.Log ("Head Hit");
                myFlowchart.ExecuteBlock("1-5(J)");
                hitCount = 1;
                StartCoroutine(ChangeCollisionState());
            }
            else if (hitCount == 1){
                myFlowchart.ExecuteBlock("1-4 (R)");
                hitCount = 2;
                StartCoroutine(ChangeCollisionState());

            }
            else if (hitCount == 2){
                myFlowchart.ExecuteBlock("1-3 (R)");
                hitCount = 3;
                StartCoroutine(ChangeCollisionState());
            }
        }
    }

    IEnumerator ChangeCollisionState()
    {  
        ccs = canCollideStates.cannotCollide;
        Debug.Log(ccs);
        yield return new WaitForSeconds(2);
        ccs = canCollideStates.canCollide;
        Debug.Log(ccs);
    }

    private IEnumerator CreateAndDestroyConfetti()
    {
        GameObject confetti1 = Instantiate(firework, new Vector3(-8.56f, 5.09f, 8.9f), Quaternion.identity);
        GameObject confetti2 = Instantiate(firework, new Vector3(8.25f, 5.09f, 8.9f), Quaternion.identity);
        yield return new WaitForSeconds(10f);
        Destroy(confetti1);
        Destroy(confetti2);
    }


}
