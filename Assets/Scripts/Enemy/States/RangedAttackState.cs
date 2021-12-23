using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttackState : EnemyState
{
    [SerializeField] private float _attackForce;
    [SerializeField] private float _speed;
    [SerializeField] private float _attackDistance;
    [SerializeField] private float _attackDelay;
    [SerializeField] private Bullet _bullet;

    private Coroutine _coroutine;

    private void OnEnable()
    {
        _coroutine = StartCoroutine(Attack());
    }

    private IEnumerator Attack()
    {
        while (enabled)
        {
            Animator.SetTrigger("attack");
            transform.LookAt(Player.transform.position);
            Instantiate(_bullet, transform.position, Quaternion.identity);
            _bullet.transform.position = Vector3.MoveTowards(_bullet.transform.position, Player.transform.position, _speed * Time.fixedDeltaTime);

            if (Vector3.Distance(_bullet.transform.position, Player.transform.position) < _attackDistance)
            {
                Player.ApplyDamage(_attackForce);
                Destroy(gameObject);
            }
            yield return new WaitForSeconds(_attackDelay);
        }
    }
    private void OnDisable()
    {
        StopCoroutine(_coroutine);
    }
}
