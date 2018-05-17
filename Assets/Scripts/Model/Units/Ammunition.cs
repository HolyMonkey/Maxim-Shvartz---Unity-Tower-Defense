using UnityEngine;

[CreateAssetMenu(menuName = "Ammunition")]
public class Ammunition : ScriptableObject
{
    public GameObject Model;

    public float SpeedMul;
    public float HealthMul;
    public UnitBaseState.AmmunitionSlot.AmmunitionType Type;

    public virtual UnitBaseState ProcessState(UnitBaseState state)
    {
        var result = ScriptableObject.Instantiate(state);

        result.Health *= HealthMul;
        result.Speed *= SpeedMul;
        
        return result;
    }
}
