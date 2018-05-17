using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class UnitManager
{
    private static List<GameObject> _enemies;

    public static void AddEnemy(GameObject enemy)
    {
        _enemies.Add(enemy);
    }

    public static IEnumerable<GameObject> GetAllEnemies()
    {
        return _enemies;
    }
}

