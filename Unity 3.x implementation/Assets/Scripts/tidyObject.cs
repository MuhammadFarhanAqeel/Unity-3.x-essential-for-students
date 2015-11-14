using UnityEngine;
using System.Collections;

public class tidyObject : MonoBehaviour {

    public float removeTime = 3.0f;

    void Start () {
        Destroy(gameObject, removeTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
