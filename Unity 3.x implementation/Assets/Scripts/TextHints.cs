using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextHints : MonoBehaviour {

    private float timer = 0.0f;


	void Start () {
	
	}
	
	void Update () {
        if (GetComponent<Text>().enabled) 
        {
            timer += Time.deltaTime;
        } if (timer >= 2.0f) 
        {
            GetComponent<Text>().enabled = false;
            timer = 0.0f;
        }
	}

    public void ShowHint(string message)
    {
        GetComponent<Text>().text = message;
        if (!GetComponent<Text>().enabled)
        {
            GetComponent<Text>().enabled = true;
        }
    }
}
