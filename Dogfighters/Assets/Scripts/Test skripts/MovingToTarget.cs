using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using UnityEngine;

public class MovingToTarget : MonoBehaviour
{
    [SerializeField]
    private GameObject _target;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _rotationSpeed;
    [SerializeField]
    private float _epsDistance;

    private bool _isHit = false;

    void Start()
    {
    }

    void Update()
    {
        if (!_isHit)
            FolowTheTarget();
    }


    private void FolowTheTarget()
    {
        var distance = Vector2.Distance(transform.position, _target.transform.position);
        if (distance <= _epsDistance)
        {
            Debug.Log("BOOM!");
            _isHit = true;
            Destroy(gameObject);
            return;
        }
        var directionVector = _target.transform.position - transform.position;
        directionVector.Normalize();
        //if (directionVector != ) // make that missile should alwasys move forward in its local coordinates, and manage direction only by rotation method 
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(directionVector.y - transform.position.y, directionVector.x - transform.position.x) * Mathf.Rad2Deg/* - 90*/);
        transform.position += directionVector * _speed * Time.deltaTime;

    }
}
