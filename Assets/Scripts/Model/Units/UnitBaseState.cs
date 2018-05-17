using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Unit Base State")]
public class UnitBaseState : ScriptableObject
{
    public float Speed;
    public float Health;
    public GameObject Model;
    public Sprite Icon;

    public List<AmmunitionSlot> Slots;

    [System.Serializable]
    public class AmmunitionSlot
    {
        public enum AmmunitionType
        {
            Helmet, 
            Hand,
            Foot,
            Body,
        }

        public AmmunitionType Type;
    }
}
