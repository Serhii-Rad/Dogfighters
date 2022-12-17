using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MovingWithReducingSpeed : MonoBehaviour
{
    [SerializeField]
    private Transform _startPoint;
    [SerializeField]
    private Transform _endPoint;
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _duration;

    private float _timeCounter = 0f;

    void Start()
    {
        _target.position = _startPoint.position;
    }

    void Update()
    {
        MoveWithReducingSpeed();
    }

    private void MoveWithReducingSpeed()
    {
        if (_timeCounter >= _duration)
            return;
        _target.position = Vector2.Lerp(_target.position, _endPoint.position, Time.deltaTime);
        _timeCounter += Time.deltaTime;
    }


    [ContextMenu("Move Again")]
    private void OneMoreTime()
    {
        _timeCounter = 0;
        _target.position = _startPoint.position;
    }
}
