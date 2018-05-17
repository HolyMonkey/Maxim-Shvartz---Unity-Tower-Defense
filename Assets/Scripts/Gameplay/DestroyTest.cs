using Assets.Scripts.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTest : MonoBehaviour {

    public List<GameObject> GO;

	void Start ()
    {
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GO.RemoveAll((x) => x.Equals(null));
            foreach (var item in GO)
            {
                if (!item.Equals(null))
                {
                    Debug.Log(item.name);
                }
                
            }
        }
	}
}
