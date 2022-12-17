using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MovingInLimitedArea : MonoBehaviour
{
    [SerializeField]
    private Transform _startPoint;
    [SerializeField]
    private Transform _endPoint;
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _duration;
    [SerializeField]
    private float _xMaxPosition;

    private float _timeCounter = 0f;
    private float _normilizedTime = 0f;

    void Start()
    {
        _target.position = _startPoint.position;
    }

    void Update()
    {
        MoveInLimitedArea();
    }

    private void MoveInLimitedArea()
    {
        if (_timeCounter >= _duration)
            return;
        _normilizedTime = _timeCounter / _duration;
        var newPosition = Vector2.Lerp(_target.position, _endPoint.position, _normilizedTime);
        newPosition.x = Mathf.Clamp(newPosition.x, 0, _xMaxPosition);
        _target.position = newPosition;
        _timeCounter += Time.deltaTime;
    }

    [ContextMenu("Move Again")]
    private void OneMoreTime()
    {
        _timeCounter = 0;
        _normilizedTime = 0;
        _target.position = _startPoint.position;
    }
}

