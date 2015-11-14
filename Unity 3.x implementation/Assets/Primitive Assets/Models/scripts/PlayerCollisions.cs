using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {
	bool doorIsOpen = false;
	float doorTimer = 0.0f;
	public float doorOpenTime = 3.0f;
	public AudioClip doorOpenSound;
	public AudioClip doorShutSound;

	// Use this for initialization
	void Start () {
	
	}
	void OnControllerColliderHit (ControllerColliderHit hit){
	if (hit.gameObject.tag == "playerDoor" && doorIsOpen == false) {
			OpenDoor(hit.gameObject);
		}
	
	
	}
	void OpenDoor (GameObject door){
		doorIsOpen = true;
		door.audio.PlayOneShot (doorOpenSound);

	}

	
	
	// Update is called once per frame
	void Update () {
	
	}
}
