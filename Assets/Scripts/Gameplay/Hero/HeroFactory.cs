using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroFactory
{
	public void CreateHero(GameObject heroPrefab, Vector3 position, GroundGesture gesture)
    {
        GameObject heroObject = GameObject.Instantiate(heroPrefab, position, Quaternion.identity);
        gesture.OnTap += (pos) =>
        {
            heroObject.GetComponent<Hero>().MoveTo(pos);
        };
    }
}
