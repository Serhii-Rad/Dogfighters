using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.Pool;
using Transform = UnityEngine.Transform;

namespace Assets.Scripts
{
    public class Weapon : MonoBehaviour
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
            if (Input.GetKey(KeyCode.Space) && _timeSinceLastShot >= _fireDelay)
            {
                _timeSinceLastShot = 0.0f;
                Shoot(_atackType);
            }
        }

        private void Shoot(AtackType atackType)
        {
            if (atackType == AtackType.OneShoot)
            {
                AudioManager.Instance.PlaySFX(SFX_Type.Shoot);
                Instantiate(_bullet, transform.position, transform.rotation);
            }
            else if (atackType == AtackType.DoubleShoot)
                Instantiate(_bullet, transform.position, transform.rotation); // to do
            else if (atackType == AtackType.TripleShoot)
                Instantiate(_bullet, transform.position, transform.rotation); // to do
        }
    }

    public enum AtackType
    {
        OneShoot, DoubleShoot, TripleShoot
    }
}
