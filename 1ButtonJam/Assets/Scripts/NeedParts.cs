using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedParts : MonoBehaviour
{
    public string[] _namePartsArray;
    [SerializeField] private SpriteRenderer[] _parts;
    [SerializeField] private Sprite _empty;
    void Update()
    {
        for(int i = 0; i < _namePartsArray.Length; i++)
        {
            if (_namePartsArray[i] == "empty")
            {
                _parts[i].sprite = _empty;
            }
        }
    }
}
