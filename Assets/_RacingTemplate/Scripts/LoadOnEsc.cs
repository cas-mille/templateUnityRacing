using UnityEngine;
using System.Collections;

public class LoadOnEsc : MonoBehaviour {

	public int level;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update() {
		if (Input.GetKey(KeyCode.Escape))
			Application.LoadLevel(level);
	}
}
