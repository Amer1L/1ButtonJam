using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugMove : MonoBehaviour
{
    private float _speed;

    void Start()
    {
        _speed = Random.Range(-2f, -5f);
    }

    void Update()
    {
        if (StartAndFinish.IsPlay)
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
    }
}
