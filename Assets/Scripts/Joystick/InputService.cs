using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputService : MonoBehaviour {

    public KeyboardInputComponent KeyboardInputComponent;
    public MouseInputComponent MouseInputComponent;
    public JoystickInputComponent JoystickInputComponent;

	public IInputComponent GetInputComponent()
    {
#if UNITY_ANDROID
        return JoystickInputComponent;
#endif
#if UNITY_EDITOR || UNITY_STANDALONE
        return KeyboardInputComponent;
#endif
    }
}
