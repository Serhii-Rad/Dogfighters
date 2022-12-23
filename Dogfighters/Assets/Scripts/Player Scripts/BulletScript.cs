using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float _velocity = 10f;
    [SerializeField] private float _lifeTime = 4f;
    void Start()
    {
        Destroy(gameObject, _lifeTime);
    }

    void Update()
    {
        transform.Translate(Vector2.up * _velocity * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.CompareTag("CameraBorder"))
        {
            Destroy(gameObject);
        }
    }
}
