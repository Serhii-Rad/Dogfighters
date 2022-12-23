using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovementWithForce : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Rigidbody2D _rigidBody;
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private GameObject _loseScreen;

    private bool _moveUp = false;
    private bool _moveDown = false;
    private bool _moveLeft = false;
    private bool _moveRight = false;
    private bool _turnRight = false;
    private bool _turnLeft = false;

    private Health _health;


    void Start()
    {
        _health = GetComponent<Health>();
    }

    void Update()
    {
        _moveUp = Input.GetKey(KeyCode.W);
        _moveDown = Input.GetKey(KeyCode.S);
        _moveRight = Input.GetKey(KeyCode.D);
        _moveLeft = Input.GetKey(KeyCode.A);
        _turnRight = Input.GetKey(KeyCode.RightArrow);
        _turnLeft = Input.GetKey(KeyCode.LeftArrow);
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

        if (_turnRight)
            TurnRight();
        else if (_turnLeft)
            TurnLeft();
    }

    private void Move(Vector2 direction)
    {
        _rigidBody.AddForce(direction * _speed, ForceMode2D.Force);
        
    }

    private void TurnRight() => _rigidBody.transform.Rotate(Vector3.back, _rotationSpeed);
    private void TurnLeft() => _rigidBody.transform.Rotate(Vector3.back, -_rotationSpeed);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"You crashed in enemy plane {collision.gameObject.name}");
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        else if (collision.CompareTag("EnemyBullet"))
        {
            Destroy(collision.gameObject);
            _health.DamagePlayer(10);
        }
        else if (collision.CompareTag("PlayerBullet"))
            return;
    }

    private void OnDestroy()
    {
        Time.timeScale = 0;
        _loseScreen.SetActive(true);
    }

}
