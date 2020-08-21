using UnityEngine;

public class Anims : MonoBehaviour
{

    public Animator anim;
    public ThirdPersonMovement mv;


    // Update is called once per frame
    void Update()
    {
        if(mv.isMoving == true)
        {
            anim.SetBool("walk", true);

            if (mv.isRunning == true)
            {
                anim.SetBool("run", true);
	        }
            else
            {
                anim.SetBool("run", false);
            }
        }
        else
        {
            anim.SetBool("walk", false);
	    }
    }
}