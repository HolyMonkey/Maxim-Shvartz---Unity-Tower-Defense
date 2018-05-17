using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class AttackEnemy : ITowerState
{
    private GameObject enemy;

    public AttackEnemy(GameObject enemy)
    {
        this.enemy = enemy;
    }

    public ITowerState Update()
    {
        throw new NotImplementedException();
    }
}

