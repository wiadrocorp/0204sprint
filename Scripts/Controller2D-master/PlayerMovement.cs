using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    bool slash = false;
    bool shoot = false;

    //korutyna do szczelania z kuszy xdddd
    IEnumerator PrepareBolt()
    {
        runSpeed = 0;
        yield return new WaitForSeconds(0.7f);
        runSpeed = 40f;
    }
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        
        //machanie mieczem
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("lmb");

        }
        //strzelanie
        if (Input.GetMouseButtonDown(1))
        {
            StartCoroutine("PrepareBolt");
            animator.SetTrigger("rmb");
        }
        //skakanie
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        //kucanie
        if(Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if(Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    private void FixedUpdate()
    {
        // Move character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
