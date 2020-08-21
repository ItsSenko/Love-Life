using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedRoomDoor : MonoBehaviour
{
	private void OnTriggerStay(Collider collider)
	{
		if(Input.GetKeyDown("e"))
		{
			Debug.Log("School");
		}
	}



}