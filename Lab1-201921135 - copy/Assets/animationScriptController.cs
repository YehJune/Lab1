using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationScriptController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);

    }

    // Update is called once per frame
    void Update()
    {
        bool isLockingDancing = animator.GetBool("isLockingDancing");
        bool isWaveDancing = animator.GetBool("isWaveDancing");
        bool lPressed = Input.GetKey("l");
        bool wPressed = Input.GetKey("w");

        if (!isLockingDancing && lPressed)
        {
            animator.SetBool("isLockingDancing", true);
        }
        if (isLockingDancing && !lPressed)
        {
            animator.SetBool("isLockingDancing", false);
        }
        if (!isWaveDancing && wPressed)
        {
            animator.SetBool("isWaveDancing", true);
        }
        if (isWaveDancing && !wPressed)
        {
            animator.SetBool("isWaveDancing", false);
        }
    }
}
