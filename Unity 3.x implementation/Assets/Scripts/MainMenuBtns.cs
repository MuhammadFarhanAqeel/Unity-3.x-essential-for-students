using UnityEngine;
using System.Collections;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]
public class MainMenuBtns : MonoBehaviour
{
    public string levelToLoad;
    public bool quitButton;
    public AudioClip beep;

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void Play_click() 
    {
        StartCoroutine(PlayCLick());
    }

    public void Instruction_click() 
    {

    }

    public void Quit_click() 
    {
        quitButton = true;
        StartCoroutine(QuitClick());
    }

    IEnumerator PlayCLick()
    {
        this.GetComponent<AudioSource>().PlayOneShot(beep);
        yield return new WaitForSeconds(0.35f);
        Application.LoadLevel(levelToLoad);
    }

    IEnumerator QuitClick()
    {
        audio.PlayOneShot(beep);
        yield return new WaitForSeconds(0.35f);
        if (quitButton)
        {
            Application.Quit();
            Debug.Log("This part works!");
        }
        else
        {
            Application.LoadLevel(levelToLoad);
        }
    }
}
