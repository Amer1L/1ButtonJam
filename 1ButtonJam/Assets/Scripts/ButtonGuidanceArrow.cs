using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGuidanceArrow : MonoBehaviour
{
    [SerializeField] private Transform _arrow;
    [SerializeField] private SpriteRenderer _buttonSR;
    [SerializeField] private Sprite _true;
    [SerializeField] private Sprite _false;
    private bool _isGuidance = false;


    void Update()
    {
        if(_arrow.position.y == transform.position.y && !_isGuidance)
        {
            _buttonSR.sprite = _true;
            _isGuidance = true;
        }
        if(_arrow.position.y != transform.position.y && _isGuidance)
        {
            _buttonSR.sprite = _false;
            _isGuidance = false;
        }
    }
}
