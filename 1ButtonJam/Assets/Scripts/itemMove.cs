using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemMove : MonoBehaviour
{

    [SerializeField] private float _speed;


    void Update()
    {
        if (StartAndFinish.IsPlay)
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
    }
}
