using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowMove : MonoBehaviour
{
    [SerializeField] private Transform _point1;
    [SerializeField] private Transform _point2;
    [SerializeField] private Transform _arrow;
    [SerializeField] private Transform[] _buttonArray;
    [SerializeField] private AudioSource _trans;
    [SerializeField] private AudioSource _choose;
    private bool _moveA = false;
    private float _delay = 1f;
    private float constDelay = 1f;
    private bool _playChoose = true;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _moveA = true;
            _playChoose = true;
        }
        if (_moveA && _delay > 0)
        {
            _delay -= Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (_delay > 0)
            {
                for (int i = 0; i < _buttonArray.Length; i++)
                {
                    if (_buttonArray[i].position.y == transform.position.y && _moveA)
                    {
                        if (i < _buttonArray.Length - 1)
                        {
                            transform.position = new Vector3(transform.position.x, _buttonArray[i + 1].position.y, transform.position.z);
                            _moveA = false;
                        }
                        else
                        {
                            transform.position = new Vector3(transform.position.x, _buttonArray[0].position.y, transform.position.z);
                            _moveA = false;
                        }
                        _trans.Play();
                    }
                }
            }
            _delay = constDelay;
            _arrow.position = _point2.position;
        }
        if (_delay <= 0)
        {
            _moveA = false;
            if (_playChoose)
            {
                _choose.Play();
                _playChoose = false;
            }
        }


        if (_moveA)
        {
            _arrow.position = Vector3.Lerp(_point1.position, _point2.position, _delay);
        }
    }
}
