using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitTemplate : ScriptableObject
{
    public UnitBaseState BaseState;
    public UnitBaseState CurrentState
    {
        get
        {
            var result = BaseState;
            foreach (var item in Ammunitions.Values)
            {
                result = item.ProcessState(result);
            }
            return result;
        }
    }

    public IEnumerable<Ammunition> PlacedAmmunitions
    {
        get
        {
            return Ammunitions.Values;
        }
    }

    private Dictionary<UnitBaseState.AmmunitionSlot, Ammunition> Ammunitions = new Dictionary<UnitBaseState.AmmunitionSlot, Ammunition>();

    public void AddAmmuniotion(UnitBaseState.AmmunitionSlot slot, Ammunition ammunition)
    {
        if(slot.Type == ammunition.Type)
        {
            if (Ammunitions.ContainsKey(slot))
            {
                Ammunitions[slot] = ammunition;
            }
            else
            {
                Ammunitions.Add(slot, ammunition);
            }
        }
        else
        {
            throw new System.InvalidOperationException("Slot type not equals ammunition type");
        }
    }
}
