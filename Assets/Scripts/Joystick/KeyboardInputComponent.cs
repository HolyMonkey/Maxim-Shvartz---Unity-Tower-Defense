using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInputComponent : MonoBehaviour, IInputComponent {

    public Vector2 GetDirection()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            return Vector2.up;
        }
        return Vector2.zero;
    }
}
