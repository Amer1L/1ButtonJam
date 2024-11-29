using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invent : MonoBehaviour
{

    public string[] _invetoryArray = new string[12];

    void Start()
    {
        for(int i = 0;  i < _invetoryArray.Length; i++)
        {
            _invetoryArray[i] = "empty";
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (StartAndFinish.IsPlay)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                for (int i = 0; i < _invetoryArray.Length; i++)
                {
                    if (_invetoryArray[i] == "empty")
                    {
                        _invetoryArray[i] = collision.gameObject.name;
                        i = _invetoryArray.Length;
                        Destroy(collision.gameObject);
                        if(collision.gameObject.name == "bug")
                        {
                            for (int j = 0; j < _invetoryArray.Length; j++)
                            {
                                if (_invetoryArray[j] != "empty" && _invetoryArray[j] != "bug" && _invetoryArray[j] != "trash")
                                {
                                    _invetoryArray[j] = "trash";
                                    j = _invetoryArray.Length;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}