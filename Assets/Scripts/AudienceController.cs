using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AudienceController : MonoBehaviour
{
    public void MoveAudienceUp()
    {
        gameObject.transform.DOMoveY(-0.5f, 5f).SetEase(Ease.InOutSine);
    }
    
    public void MoveAudienceDown()
    {
        gameObject.transform.DOMoveY(-3f, 3f).SetEase(Ease.InOutSine);
    }

}
