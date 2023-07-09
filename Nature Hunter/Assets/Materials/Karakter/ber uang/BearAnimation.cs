using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BearAnimation : MonoBehaviour
{
    public Animator animator;

    private bool isWalking = false;
    private bool isRunning = false;
    private bool isAttacking = false;

    private void Start()
    {
        // Start the initial walking animation
        StartWalking();
    }

    private void Update()
    {
        // Update movement logic here if needed
    }

    private void StartWalking()
    {
        if (!isWalking)
        {
            isWalking = true;
            animator.SetBool("WalkForward", false);
            animator.SetBool("Run Forward", true);
            animator.SetBool("Attack1", false);
        }
    }

    private void StartRunning()
    {
        if (!isRunning)
        {
            isRunning = true;
            animator.SetBool("WalkForward", false);
            animator.SetBool("Run Forward", true);
            animator.SetBool("Attack1", false);
        }
    }

    private void StartAttacking()
    {
        if (!isAttacking)
        {
            isAttacking = true;
            animator.SetBool("WalkForward", false);
            animator.SetBool("Run Forward", false);
            animator.SetBool("Attack1", true);
        }
    }
}
