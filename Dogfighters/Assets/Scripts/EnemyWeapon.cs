using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyWeapon : MonoBehaviour
    {
        [SerializeField] private GameObject _bullet;
        [SerializeField] private AtackType _atackType = AtackType.OneShoot;
        [SerializeField] private float _fireDelay = 0.5f;

        private float _timeSinceLastShot = 0.0f;

        private void Start()
        {
        }

        private void Update()
        {
            _timeSinceLastShot += Time.deltaTime;
            if (_timeSinceLastShot >= _fireDelay)
            {
                _timeSinceLastShot = 0.0f;
                Shoot(_atackType);
            }
        }

        private void Shoot(AtackType atackType)
        {
            if (atackType == AtackType.OneShoot)
                Instantiate(_bullet, transform.position, transform.rotation);
            else if (atackType == AtackType.DoubleShoot)
                Instantiate(_bullet, transform.position, transform.rotation); // to do
            else if (atackType == AtackType.TripleShoot)
                Instantiate(_bullet, transform.position, transform.rotation); // to do
        }
    }
}
