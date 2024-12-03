using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invent : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private AudioSource[] _bugSourceArray;
    [SerializeField] private AudioSource[] _metalSourceArray;

    public string[] _invetoryArray = new string[12];

    void Start()
    {
        for (int i = 0; i < _invetoryArray.Length; i++)
        {
            _invetoryArray[i] = "empty";
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {
            bool plus = true;
            for (int i = 0; i < _invetoryArray.Length; i++)
            {
                if (_invetoryArray[i] == "empty" && plus)
                {
                    _invetoryArray[i] = "sheet";
                    plus = false;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            bool plus = true;
            for (int i = 0; i < _invetoryArray.Length; i++)
            {
                if (_invetoryArray[i] == "empty" && plus)
                {
                    _invetoryArray[i] = "prop";
                    plus = false;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            bool plus = true;
            for (int i = 0; i < _invetoryArray.Length; i++)
            {
                if (_invetoryArray[i] == "empty" && plus)
                {
                    _invetoryArray[i] = "trash";
                    plus = false;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _spriteRenderer.color = new Color(0, 255, 0, _spriteRenderer.color.a);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _spriteRenderer.color = new Color(255, 255, 255, _spriteRenderer.color.a);
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
                        if (collision.gameObject.name == "bug")
                        {
                            for (int j = 0; j < _invetoryArray.Length; j++)
                            {
                                if (_invetoryArray[j] != "empty" && _invetoryArray[j] != "bug" && _invetoryArray[j] != "trash")
                                {
                                    _invetoryArray[j] = "trash";
                                    j = _invetoryArray.Length;
                                }
                            }

                            int rand = Random.Range(0, _bugSourceArray.Length);
                            for (int p = 0; p < _bugSourceArray.Length; p++)
                            {
                                if (p == rand)
                                {
                                    _bugSourceArray[p].Play();
                                }
                            }
                        }
                        if(collision.gameObject.name == "sheet" || collision.gameObject.name == "prop")
                        {
                            int rand = Random.Range(0, _metalSourceArray.Length);
                            for (int p = 0; p < _metalSourceArray.Length; p++)
                            {
                                if (p == rand)
                                {
                                    _metalSourceArray[p].Play();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}