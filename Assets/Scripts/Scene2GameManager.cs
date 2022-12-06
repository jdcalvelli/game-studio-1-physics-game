using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class Scene2GameManager : MonoBehaviour
{
    [SerializeField] private BladeController romeoSword;
    [SerializeField] private BladeController rosalindSword;

    [SerializeField] private Flowchart flowchart;
    [SerializeField] private SayDialog sayDialogReference;

    [SerializeField] private Animator curtainAnimator;
    
    private enum Scene2States
    {
        CurtainAnimating,
        Fighting,
        Resolution,
        GameEnd,
    }

    [SerializeField] private Scene2States scene2States;
    
    // Start is called before the first frame update
    void Start()
    {
        scene2States = Scene2States.CurtainAnimating;

        //scene2States = Scene2States.Fighting;
    }

    // Update is called once per frame
    void Update()
    {
        switch (scene2States)
        {
            case Scene2States.CurtainAnimating:
                curtainAnimator.SetTrigger("openCurtain");
                flowchart.SendFungusMessage("startScene2");
                scene2States = Scene2States.Fighting;
                break;
            
            case Scene2States.Fighting:
                if (romeoSword.enemyHitCounter > 2 && rosalindSword.enemyHitCounter > 3)
                {
                    if (!sayDialogReference.isActiveAndEnabled)
                    {
                        scene2States = Scene2States.Resolution;
                    }
                }
                break;
            case Scene2States.Resolution:
                flowchart.SendFungusMessage("Ending");
                scene2States = Scene2States.GameEnd;
                break;
            
            case Scene2States.GameEnd:
                if (!sayDialogReference.isActiveAndEnabled)
                {
                    curtainAnimator.SetTrigger("closeCurtain");
                }
                break;
        }
    }
}
