using UnityEngine;

public class NeedParts : MonoBehaviour
{
    public bool IsDone = false;
    public string[] _namePartsArray;
    [SerializeField] private SpriteRenderer[] _parts;
    [SerializeField] private Sprite _empty;
    [SerializeField] private SpriteRenderer _thisZone;
    private int _numberOfDoneParts = 0;

    void Update()
    {
        for(int i = 0; i < _namePartsArray.Length; i++)
        {
            if (_namePartsArray[i] == "empty")
            {
                _parts[i].sprite = _empty;
                _numberOfDoneParts += 1;
            }
        }

        if(_numberOfDoneParts == _namePartsArray.Length)
        {
            IsDone = true;
            _thisZone.sprite = _empty;
        }
        else
        {
            _numberOfDoneParts = 0;
        }
    }
}
