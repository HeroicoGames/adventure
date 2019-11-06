using UnityEngine;
using System.Collections;

public class Foreground : MonoBehaviour {

	public Vector3 velocity = new Vector3(-3f, 0f, 0f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += velocity * Time.deltaTime;
	}
}
