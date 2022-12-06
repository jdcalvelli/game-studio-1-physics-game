using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class FullGameController : MonoBehaviour
{
    [SerializeField] private AudioSource curtainAudio;
    
    [SerializeField] private GameObject introSceneReference;
    
    [SerializeField] private GameObject scene1Reference;
    [SerializeField] private Flowchart scene1Flowchart;
    
    [SerializeField] private GameObject scene2Reference;
    [SerializeField] private Flowchart scene2Flowchart;

    [SerializeField] private GameObject endSceneReference;
    
    private enum FullGameStates
    {
        StartMenu,
        Scene1,
        Scene2,
        EndGame
    }

    private FullGameStates _fullGameStates;
    
    // Start is called before the first frame update
    void Start()
    {
        _fullGameStates = FullGameStates.StartMenu;
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (_fullGameStates)
        {
            case FullGameStates.StartMenu:
                if (introSceneReference.activeSelf == false)
                {
                    scene1Reference.SetActive(true);
                    _fullGameStates = FullGameStates.Scene1;
                }
                break;
            
            case FullGameStates.Scene1:

                if (scene1Flowchart.GetVariable<BooleanVariable>("IsSceneEnded").Value == true)
                {
                    scene1Reference.SetActive(false);
                    scene2Reference.SetActive(true);
                    _fullGameStates = FullGameStates.Scene2;
                }
                break;
            
            case FullGameStates.Scene2:
                if (scene2Reference.activeSelf == false)
                {
                    scene2Reference.SetActive(false);
                    endSceneReference.SetActive(true);
                    _fullGameStates = FullGameStates.EndGame;
                }
                break;
            
            case FullGameStates.EndGame:
                break;
        }
    }
}
