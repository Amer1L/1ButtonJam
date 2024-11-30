using UnityEngine;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private Transform _finish;
    [SerializeField] private GameObject _thisWindow;
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
                _finish.Translate(45, 0, 0);
                _thisWindow.SetActive(false);
                StartAndFinish.IsPlay = true;
            }
            _delay = constDelay;
            _moveA = false;
        }
    }
}
