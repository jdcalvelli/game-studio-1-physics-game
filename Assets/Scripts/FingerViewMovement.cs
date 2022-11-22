using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerViewMovement : MonoBehaviour
{
    //[SerializeField] private List<GameObject> fingerView;
    [SerializeField] private float moveSpeed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position0 = GameObject.Find("ThumbView").transform.position;
        Vector3 position1 = GameObject.Find("IndexView").transform.position;
        Vector3 position2 = GameObject.Find("MiddleView").transform.position;
        Vector3 position3 = GameObject.Find("RingView").transform.position;

        if (Input.GetKey(KeyCode.Q))
        {
            if (position0.y < 3.72)
            {
                    //Debug.Log (position0.y);
                    position0.y += moveSpeed; 
            }
            if (position0.y > 3.72)
            {
                    //Debug.Log (position0.y);
                    position0.y += 0; 
            }
            GameObject.Find("ThumbView").transform.position = position0;                  
        } 
        else {
            if (position0.y > 3.58)
            {
                position0.y -= moveSpeed;
            }
            if (position0.y < 3.58)
            {
            position0.y -= 0;
            }  
            GameObject.Find("ThumbView").transform.position = position0; 
        }
        
        //

        if (Input.GetKey(KeyCode.W))
            {
                if (position1.y < 3.95)
                {
                    //Debug.Log (position1.y);
                    position1.y += moveSpeed;
                }
                if (position1.y > 3.95)
                {
                    //Debug.Log (position1.y);
                    position1.y += 0; 
                }
                GameObject.Find("IndexView").transform.position = position1;                 
            } 
            else 
            {
                if (position1.y > 3.8)
                {
                position1.y -= moveSpeed;
                }
                if (position1.y < 3.8)
                {
                position1.y -= 0;
                }  
                GameObject.Find("IndexView").transform.position = position1;
        }

        //

        if (Input.GetKey(KeyCode.O))
            {
                if (position2.y < 4.26)
                {
                    //Debug.Log (position2.y);
                    position2.y += moveSpeed;
                }
                if (position2.y > 4.26)
                {
                    //Debug.Log (position2.y);
                    position2.y += 0; 
                }
                GameObject.Find("MiddleView").transform.position = position2;                 
            } 
            else 
            {
                if (position2.y > 4.056)
                {
                position2.y -= moveSpeed;
                }
                if (position2.y < 4.056)
                {
                position2.y -= 0;
                }  
                GameObject.Find("MiddleView").transform.position = position2;
        }

        //
        
          if (Input.GetKey(KeyCode.P))
            {
                if (position3.y < 4.1)
                {
                    //Debug.Log (position3.y);
                    position3.y += moveSpeed;
                }
                if (position3.y > 4.1)
                {
                    //Debug.Log (position3.y);
                    position3.y += 0; 
                }
                GameObject.Find("RingView").transform.position = position3;                 
            } 
            else 
            {
                if (position3.y > 3.95)
                {
                position3.y -= moveSpeed;
                }
                if (position3.y < 3.95)
                {
                position3.y -= 0;
                }  
                GameObject.Find("RingView").transform.position = position3;
        }

    }
}
