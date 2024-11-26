using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invent : MonoBehaviour
{

    private string[] _invetoryArray = new string[5];

    void Start()
    {
        for(int i = 0;  i < _invetoryArray.Length; i++)
        {
            _invetoryArray[i] = " ";
        }
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.K))
        {
            string inventory = "";
            for (int i = 0; i < _invetoryArray.Length; i++)
            {
                inventory = inventory + "|" + _invetoryArray[i];
            }
            Debug.Log(inventory);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for(int i = 0; i < _invetoryArray.Length; i++)
            {
                if (_invetoryArray[i] == " ")
                {
                    _invetoryArray[i] = collision.gameObject.name;
                    i = _invetoryArray.Length;
                    Destroy(collision.gameObject);
                }
            }
        }
    }
}