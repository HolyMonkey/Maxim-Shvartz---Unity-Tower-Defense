using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroView : MonoBehaviour {

    public Hero Hero;
    public Animator Animator;

    public void Start()
    {
        Hero.OnRun += Run;
    }

    public void Idle()
    {
        Animator.Play("Idle");
    }

    public void Run()
    {

    }

    public void Attack()
    {

    }
}
