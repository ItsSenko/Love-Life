using UnityEngine;
using UnityEngine.SceneManagement;

public class playerhit : MonoBehaviour {
	
	public Movement movement;

	void OnCollisionEnter (Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Hurt")
		{
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene(9);
		}
	}
}		



