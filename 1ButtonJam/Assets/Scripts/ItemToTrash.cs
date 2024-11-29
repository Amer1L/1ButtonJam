using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemToTrash : MonoBehaviour
{
    [SerializeField] private invent invent;
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
            for (int i = 0; i < invent._invetoryArray.Length; i++)
            {
                invent._invetoryArray[i] = "empty";
            }
            _moveA = false;
            _delay = constDelay;
        }
    }
}
