using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;

    void Start()
    {
    }

    void Update()
    {
        Move();
    }

    
    private void Move()
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
    }
}
