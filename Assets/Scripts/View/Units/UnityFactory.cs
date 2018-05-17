using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class UnityFactory
{
    public static GameObject CreateUnit(UnitTemplate template, Vector3 pos)
    {
        GameObject unit = GameObject.Instantiate(template.CurrentState.Model, pos, Quaternion.identity);
        unit.GetComponent<AmmunitionsPresenter>().Place(template.PlacedAmmunitions);
        return unit;
    }

}

