using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public InputService InputService;
    private IInputComponent Input;

    private void Start()
    {
        Input = InputService.GetInputComponent();
    }
}
