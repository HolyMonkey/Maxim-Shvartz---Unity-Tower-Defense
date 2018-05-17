using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmunitionsPresenter : MonoBehaviour {

    public List<Slot> Slots = new List<Slot>();

    public void Place(IEnumerable<Ammunition> ammunitions)
    {
        foreach (var ammunition in ammunitions)
        {
            foreach (var slot in Slots)
            {
                if(slot.Type == ammunition.Type)
                {
                    Instantiate(ammunition.Model, slot.Point);
                }
            }
        }
    }
}

[System.Serializable]
public class Slot
{
    public UnitBaseState.AmmunitionSlot.AmmunitionType Type;
    public Transform Point;
}
