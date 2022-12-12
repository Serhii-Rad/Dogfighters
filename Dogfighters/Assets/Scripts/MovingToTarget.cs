using System.Collections;
using System.Collections.Generic;
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
        transform.position += directionVector * _speed * Time.deltaTime;
    }
}
