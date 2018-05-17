using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

interface IEnemyFinder
{
    IEnumerable<GameObject> GetAllEnemies();
}
