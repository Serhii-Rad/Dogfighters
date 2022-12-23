using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using static UnityEngine.GraphicsBuffer;

public enum EnemyType
{
    Simple = 1, Medium, Hard, Insane, Missile
}


public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyType _enemyType;
    [SerializeField] private float _speed = 3f;
    [SerializeField] private Sprite _spriteAfterDeath;

    private GameObject _weapon;

    public float Speed => _speed * (float)_enemyType;

    private IEnumerator PerformActionForSeconds(Action action, float seconds = 3f) // does not work
    {
        // Perform the action here
        action.Invoke();

        // Wait for n seconds
        yield return new WaitForSeconds(seconds);
    }

    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            _weapon = transform.GetChild(i).gameObject;
            _weapon.SetActive(false);
        }
    }

    void Update()
    {
        Move();
    }

    
    private void Move()
    {
        switch (_enemyType)
        {
            case EnemyType.Simple:
                MoveForward();
                break;
            case EnemyType.Medium:
                //if (new System.Random().Next(1) == 0)
                //    MoveDiagonalLeft();
                //else
                //    MoveDiagonalRight();
                MoveDiagonalRight();
                break;
            case EnemyType.Hard:
                MoveZigZag();
                break;
           case EnemyType.Insane:
                MoveFlanking();
                break;
           case EnemyType.Missile:
                MoveToTarget();
                break;
        }
    }

    private void MoveForward() => transform.Translate(Vector2.up * _speed * Time.deltaTime);

    private void MoveDiagonalRight() => transform.Translate((Vector2.up + Vector2.right) * _speed * Time.deltaTime);

    private void MoveDiagonalLeft() => transform.Translate((Vector2.up + Vector2.left) * _speed * Time.deltaTime);

    private void MoveZigZag()
    {
        StartCoroutine(PerformActionForSeconds(MoveDiagonalLeft));
        StartCoroutine(PerformActionForSeconds(MoveDiagonalRight));

        //float x = _speed * Time.deltaTime * Mathf.Sin(30);
        //float y = _speed * Time.deltaTime * Mathf.Cos(30);
        //transform.position = new Vector2(x, y);
    }

    private void MoveFlanking()
    {

    }

    private void MoveToTarget()
    {
        var target = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(target.transform);
        MoveForward();
    }

    private void OnDestroy()
    {
        //GetComponent<SpriteRenderer>().sprite = _spriteAfterDeath;
        Debug.Log("BOOM!");
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnBecameVisible()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            _weapon = transform.GetChild(i).gameObject;
            _weapon.SetActive(true);
        }
    }
}
