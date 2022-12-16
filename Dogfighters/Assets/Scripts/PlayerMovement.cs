using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Rigidbody2D _rigidBody;

    private bool _moveUp = false;
    private bool _moveDown = false;
    private bool _moveLeft = false;
    private bool _moveRight = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _moveUp = Input.GetKey(KeyCode.W);
        _moveDown= Input.GetKey(KeyCode.S);
        _moveRight= Input.GetKey(KeyCode.D);
        _moveLeft= Input.GetKey(KeyCode.A);
    }

    private void FixedUpdate()
    {
        if (_moveUp)
            Move(Vector2.up);
        else if (_moveDown)
            Move(Vector2.down);
        if (_moveRight)
            Move(Vector2.right);
        else if (_moveLeft)
            Move(Vector2.left);
    }

    private void Move(Vector2 direction)
    {
        _rigidBody.AddForce(direction * _speed, ForceMode2D.Force);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"You crashed in enemy plane {collision.gameObject.name}");
        Destroy(collision.gameObject);
    }
}
