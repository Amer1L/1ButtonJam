using UnityEngine;

public class ButtonLoadScene : MonoBehaviour
{
    [SerializeField] private GameObject _OpenScene;
    [SerializeField] private GameObject _thisScene;
    [SerializeField] private Transform _arrow;
    private bool _moveA = false;
    private float _delay = 1f;
    private float constDelay = 1f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _moveA = true;
        }
        if (_moveA && _delay > 0)
        {
            _delay -= Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (_delay > 0)
            {
                _delay = constDelay;
                _moveA = false;
            }
        }
        if (_delay <= 0)
        {
            if (_arrow.position.y == transform.position.y)
            {
                _thisScene.SetActive(false);
                _OpenScene.SetActive(true);
                StartAndFinish.IsPlay = false;
            }
            _moveA = false;
            _delay = constDelay;
        }
    }
}
