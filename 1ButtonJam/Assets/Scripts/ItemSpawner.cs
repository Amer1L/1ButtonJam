using UnityEngine;

public class ItemSpawner : MonoBehaviour
{   
    [SerializeField] private float _spawnDelay;
    [SerializeField] private GameObject[] _itemArray;

    private float _spawnDelayConst = 0;

    void Start()
    {
        _spawnDelayConst = _spawnDelay;
    }

    void Update()
    {
        if (StartAndFinish.IsPlay)
        {
            if (_spawnDelay > 0)
            {
                _spawnDelay -= Time.deltaTime;
            }
            if (_spawnDelay <= 0)
            {
                _spawnDelay = Random.Range(_spawnDelayConst - 0.1f, _spawnDelayConst + 0.2f);
                ChangeRandItem();
            }
        }
    }

    private void ChangeRandItem()
    {
        int rand = Random.Range(0, 5);
        for (int i = 0;  i < _itemArray.Length; i++)
        {
            if(i == rand)
            {
                GameObject item = Instantiate(_itemArray[i], transform);
                item.name = _itemArray[i].name;
            }
        }
    }
}
