using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoveCameraForward : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private Transform _stopPoint;

    void Start()
    {
        
    }

    void Update()
    {
        if (_stopPoint.position.y > transform.position.y)
            Move();
    }

    
    private void Move() => transform.Translate(Vector2.up * _speed * Time.deltaTime);
}
