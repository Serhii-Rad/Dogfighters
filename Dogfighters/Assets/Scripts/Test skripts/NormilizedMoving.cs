using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class NormilizedMoving : MonoBehaviour
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
    private float _normilizedTime = 0f;

    void Start()
    {
        _target.position = _startPoint.position;
    }

    void Update()
    {
        MoveWithEqualSpeed();
    }

    
    private void MoveWithEqualSpeed()
    {
        if (_timeCounter >= _duration)
            return;
        _normilizedTime = _timeCounter / _duration;
        _target.position = Vector2.Lerp(_startPoint.position, _endPoint.position, _normilizedTime);
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
