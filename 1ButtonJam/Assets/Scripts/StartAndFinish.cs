using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAndFinish : MonoBehaviour
{
    [SerializeField] private Animator _playerAnimator;
    [SerializeField] private GameObject _destroyZone;
    public static bool IsPlay = false;

    private void Update()
    {
        _destroyZone.SetActive(!IsPlay);
        _playerAnimator.SetBool("IsMove", IsPlay);
    }
}
