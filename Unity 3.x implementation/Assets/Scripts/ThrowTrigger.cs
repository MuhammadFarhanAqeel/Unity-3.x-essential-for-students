using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ThrowTrigger : MonoBehaviour {

    public GameObject crosshair; 
    public Text textHints;
    void OnTriggerEnter(Collider col) 
    {
        if (col.gameObject.tag == "Player") 
        {
           crosshair.GetComponent<SpriteRenderer>().enabled= true;
            CocunutThrower.canThrow = true;
            if(!CoconutWin.haveWon){
                textHints.SendMessage("ShowHint", "\n\n\n\n\n There's a power cell attached to this game, \n maybe I'll win it if I can knock down all the targets...");
}
        }
    }
    void OnTriggerExit(Collider col) 
    {
        if (col.gameObject.tag == "Player") 
        {
            crosshair.GetComponent<SpriteRenderer>().enabled = false;
            CocunutThrower.canThrow = false;
        }
    }
}
