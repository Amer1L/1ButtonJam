using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    [SerializeField] private Collider2D _player;
    [SerializeField] private GameObject _menu;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == _player)
        {
            StartAndFinish.IsPlay = false;
            _menu.SetActive(true);
        }
    }
}
