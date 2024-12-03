using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class levelProg : MonoBehaviour
{
    [SerializeField] private Transform _playerPoint;
    [SerializeField] private Transform _p1;
    [SerializeField] private Transform _p2;
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _finish;


    void Update()
    {
        float t = Vector2.Distance(_player.position, _finish.position) / 70;
        _playerPoint.position = Vector3.Lerp(_p2.position, _p1.position, t);
        _playerPoint.Rotate(0, 0, -27.42857142857143f * Time.deltaTime);
    }
}
