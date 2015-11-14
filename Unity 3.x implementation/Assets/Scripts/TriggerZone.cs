﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TriggerZone : MonoBehaviour
{

    public AudioClip lockedSound;
    public GameObject textHints;
    public Light doorLight;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Inventory.charge == 4)
            {
                transform.FindChild("door").SendMessage("DoorCheck");
                if (GameObject.Find("PowerGUI"))
                {
                    Destroy(GameObject.Find("PowerGUI"));
                    doorLight.color = Color.green;
                }
            }
            else if (Inventory.charge > 0 && Inventory.charge < 4)
            {
                textHints.SendMessage("ShowHint", "This door won't budge.. guess it needs fully charging- maybe more power cells will help...");
                transform.FindChild("door").audio.PlayOneShot(lockedSound);
            }
            else
            {
                transform.FindChild("door").audio.PlayOneShot(lockedSound);
                col.gameObject.SendMessage("HUDon");
                textHints.SendMessage("ShowHint", "This door seems locked.. maybe that generator needs power...");
            }
        }
    }
    
}
