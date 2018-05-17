using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    public int CurrentHealth;
    public abstract void ApplyDamage(int damage);
}


