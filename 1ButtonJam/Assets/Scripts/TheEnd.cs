using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnd : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject[] _setActiveFalse;
    [SerializeField] private NeedParts[] _partsArray;
    [SerializeField] private GameObject _sourceGO;

    void Update()
    {

        if (_partsArray[0].IsDone && _partsArray[1].IsDone && _partsArray[2].IsDone && _partsArray[3].IsDone && _partsArray[4].IsDone)
        {
            for (int i = 0; i < _setActiveFalse.Length; i++)
            {
                _setActiveFalse[i].SetActive(false);
            }
            _sourceGO.SetActive(true); ;
            animator.SetBool("TheEnd", true);
        }
    }

}
