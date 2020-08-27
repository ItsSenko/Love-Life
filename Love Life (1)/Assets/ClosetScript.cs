using UnityEngine;

public class ClosetScript : MonoBehaviour
{
    public bool isOpen;
    public Animator anin;
    void Start()
    {
     isOpen = false;
	}
    void OnTriggerStay(Collider collider)
    {
      if (Input.GetKeyDown(KeyCode.E) && (isOpen = false))
      {
        anin.SetBool("Closet_Open", true);
        isOpen = true;
	  }
      if (Input.GetKeyDown(KeyCode.E) && (isOpen = true))
      {
        anin.SetBool("Closet_Close", true);
        isOpen = false;
	  }

    }
}
