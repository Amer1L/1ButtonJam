using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlaneButton : MonoBehaviour
{
    [SerializeField] private invent invent;
    [SerializeField] private NeedParts[] _partsArray;
    [SerializeField] private Transform _arrow;
    private bool _moveA = false;
    private float _delay = 1f;
    private float constDelay = 1f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _moveA = true;
        }
        if (_moveA && _delay > 0)
        {
            _delay -= Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (_delay > 0)
            {
                _delay = constDelay;
                _moveA = false;
            }
        }
        if (_delay <= 0)
        {
            if (_arrow.position.y == transform.position.y)
            {
                for (int i = 0; i < invent._invetoryArray.Length; i++)
                {
                    for (int j = 0; j < _partsArray.Length; j++)
                    {
                        for (int p = 0; p < _partsArray[j]._namePartsArray.Length; p++)
                        {
                            if (invent._invetoryArray[i] == _partsArray[j]._namePartsArray[p])
                            {
                                invent._invetoryArray[i] = "empty";
                                _partsArray[j]._namePartsArray[p] = "empty";
                            }
                        }
                    }
                }
            }
            _moveA = false;
            _delay = constDelay;

        }
    }
}
