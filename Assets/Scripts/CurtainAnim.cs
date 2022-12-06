using System;
using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class CurtainAnim : MonoBehaviour
{
    [SerializeField] private AudioSource curtainAudio;

    [SerializeField] private Flowchart cutsceneController;

    private void Start()
    {
        OpenCurtain();
    }

    public void OpenCurtain()
    {
        gameObject.GetComponent<Animator>().SetTrigger("openCurtain");
        curtainAudio.enabled = true;
        StartCoroutine(WaitForCurtainOpen());
        //disable?
    }

    public void CloseCurtain()
    {
        gameObject.GetComponent<Animator>().SetTrigger("closeCurtain");
        curtainAudio.Play();
    }

    private IEnumerator WaitForCurtainOpen()
    {
        yield return new WaitForSeconds(3f);
        cutsceneController.SendFungusMessage("cutsceneStart");
    }
}
