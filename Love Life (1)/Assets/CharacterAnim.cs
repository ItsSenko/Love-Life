using UnityEngine;


public class CharacterAnim : MonoBehaviour
{
   public Animator anim;
   public Transform target;
   public Transform model;
   
   void OnTriggerStay(Collider coliider)
   {
       if (Input.GetKeyDown(KeyCode.F))
       {
         anim.SetTrigger("greet trigger");
         model.transform.LookAt(target);
	   }
       else if (Input.GetKeyDown("joystick button 2"))
       {
         anim.SetTrigger("greet trigger");
         model.transform.LookAt(target);
	   }
   }
}
