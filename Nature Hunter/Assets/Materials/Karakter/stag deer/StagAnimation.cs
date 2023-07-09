using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StagAnimation : MonoBehaviour
{
    Animation Anim;

    private void Start()
    {
        Walk();
    }

    private void Awake()
    {
        Anim = GetComponent<Animation>();
    }

    public void Idle()
    {
        Anim.Play("idle2");
    }

    public void Walk()
    {
        Anim.Play("walk");
    }

    public void Run()
    {
        Anim.Play("run");
    }

    public void Hit()
    {
        Anim.Play("getHit");
    }

    public void Death()
    {
        Anim.Play("death");
    }

}
