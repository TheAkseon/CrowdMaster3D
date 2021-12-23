using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttackTransition : EnemyTransition
{
    [SerializeField] private float _rangedDistance;

    private void Update()
    {
        if (Vector3.Distance(Player.transform.position, transform.position) < _rangedDistance)
        {
            NeedTransit = true;
        }
    }
}
