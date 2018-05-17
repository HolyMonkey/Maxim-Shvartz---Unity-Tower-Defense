using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class FindEnemy : ITowerState
{
    private IEnemyFinder _finder;
    private float _radius = 2;
    private float _sqrRadius;
    private Transform _transform;

    public FindEnemy(IEnemyFinder finder, float radius, float sqrRadius, Transform transform)
    {
        _finder = finder;
        _radius = radius;
        _sqrRadius = sqrRadius;
        _transform = transform;
    }

    public ITowerState Update()
    {
        var enemies = _finder.GetAllEnemies();
        foreach (var enemy in enemies)
        {
            var enemyTransform = enemy.transform;
            var sqrDistanceToEnemy = (enemyTransform.position - _transform.position).sqrMagnitude;

            if (_sqrRadius > sqrDistanceToEnemy)
            {
                return new AttackEnemy(enemy);
            }
        }

        return null;
    }
}

