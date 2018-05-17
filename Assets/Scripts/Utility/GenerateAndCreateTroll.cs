using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateAndCreateTroll : MonoBehaviour {

    public UnitBaseState Unit;
    public Ammunition Ammunition;
    public Text StateText;

	void Start ()
    {
        UnitTemplate template = ScriptableObject.CreateInstance<UnitTemplate>();
        template.BaseState = Unit;
        template.AddAmmuniotion(Unit.Slots[0], Ammunition); //добавить аммуницию к подходящему слоту
        //через этот метод добавить шлем и перчатки

        UnityFactory.CreateUnit(template, Vector3.zero);

        StateText.text = string.Format("Speed - {0}\nHealth - {1}", template.CurrentState.Speed, template.CurrentState.Health);
    }
}
