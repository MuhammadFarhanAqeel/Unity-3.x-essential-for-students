using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public static int charge = 0;
    public AudioClip collectSound;
    public Sprite[] hudCharge;
    public GameObject chargeHUDGUI;
    public Texture2D[] meterCharge;
    public Renderer meter;
	public Text textHints;

	// Matches
	bool haveMatches = false;
	public GameObject matchGUIprefab;
	GameObject matchGUI;
	public GameObject fire;
	private bool fireIsLit = false;
    void Start()
    {
        charge = 0;
    }


    void CellPickup()
    {
        AudioSource.PlayClipAtPoint(collectSound, transform.position);
        charge++;
        HUDon();
        chargeHUDGUI.GetComponent<Image>().sprite= hudCharge[charge];
        meter.material.mainTexture = meterCharge[charge]; 
        }

    void HUDon()
    {
        if (Inventory.charge > 0) 
        {
            chargeHUDGUI.SetActive(true);
        }
    }
	void MatchPickup(){
		haveMatches = true;
		AudioSource.PlayClipAtPoint(collectSound, transform.position);
		matchGUIprefab.GetComponent<Image> ().enabled = true;

	}

	void OnControllerColliderHit(ControllerColliderHit col){
		if(col.gameObject.name == "campfire"){

			Debug.Log("controller hit! ");
			if(haveMatches){
				LightFire(col.gameObject);

			}else if (!haveMatches && !fireIsLit){
				textHints.SendMessage("ShowHint","I could use this campfire to signal for help..if only I could light it..");
			}

		}
	}

	void LightFire(GameObject campfire){
		fire.GetComponent<ParticleSystem> ().Play (true);
		campfire.audio.Play ();
		Destroy (matchGUI);
		haveMatches = false;
		fireIsLit = true;
	}
	
}
