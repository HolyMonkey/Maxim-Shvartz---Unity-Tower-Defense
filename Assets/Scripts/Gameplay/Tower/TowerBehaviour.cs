using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBehaviour : MonoBehaviour {

    private ITowerState _state;

    private void Start()
    {
        //_sqrRadius = _radius * _radius;
        //_transform = GetComponent<Transform>();
    }

    private void Update ()
    {
        var newState = _state.Update();
        if(newState != null)
        {
            _state = newState;
        }
	}
}
