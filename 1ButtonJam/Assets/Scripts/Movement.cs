using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _BGtransform;
    private float _BGsize;
    private float _BGpos;

    void Start()
    {
        _BGtransform = GetComponent<Transform>();
        _BGsize = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        _BGpos += _speed * Time.deltaTime;
        _BGpos = Mathf.Repeat(_BGpos, _BGsize);
        _BGtransform.position = new Vector3(_BGpos, 0, 5);
    }
}
