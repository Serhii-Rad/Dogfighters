using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    [SerializeField] private float _velocity = 5f;
    [SerializeField] private float _lifeTime = 7f;

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
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("CameraBorder"))
            Destroy(gameObject);
    }
}
