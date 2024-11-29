using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryRender : MonoBehaviour
{
    [SerializeField] private invent invent;
    [SerializeField] private SpriteRenderer[] _SRArray;
    [SerializeField] private Sprite[] _textureArray;


    void Update()
    {
        for (int i = 0; i < _SRArray.Length; i++)
        {
            string itemName = invent._invetoryArray[i];
            for (int j = 0; j < _textureArray.Length; j++)
            {
                if(_textureArray[j].name == itemName)
                {
                    _SRArray[i].sprite = _textureArray[j];
                }
            }
        }
    }
}
