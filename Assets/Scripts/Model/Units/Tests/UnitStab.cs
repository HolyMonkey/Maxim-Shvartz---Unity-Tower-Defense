using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UnitStab : Unit
{
    public bool IsDamageApply;

    public override void ApplyDamage(int damage)
    {
        IsDamageApply = true;
    }
}

