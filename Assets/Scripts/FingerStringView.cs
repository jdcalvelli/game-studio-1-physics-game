using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerStringView : MonoBehaviour
{

    [SerializeField] private Transform limbView;
    private Transform _fingerView;

    private LineRenderer _fingerStringRenderer;

    private float _stringWidth = 0.05f;
    private int _stringCapVertices = 10;

    private Color _stringColor = new Color(116, 20, 20);

    // Start is called before the first frame update
    void Start()
    {
        _fingerView = gameObject.transform;
        _fingerStringRenderer = gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //string shaping
        _fingerStringRenderer.startWidth = _stringWidth;
        _fingerStringRenderer.endWidth = _stringWidth;
        _fingerStringRenderer.numCapVertices = _stringCapVertices;

        _fingerStringRenderer.SetPosition(0, _fingerView.position);
        _fingerStringRenderer.SetPosition(1, limbView.position);
    }
}
