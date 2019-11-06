using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Vector3 jumpDistance = new Vector3(0f, 0.9f, 0f);
	bool in_floor = false;
	public Renderer lol;

	void OnBecameInvisible(){
		Application.LoadLevel ("MainMenu");
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Jump ();
//		lol = GetComponent<Renderer> ();
//		print (lol.isVisible);
//		print (lol.name);
		//		if (lol.isVisible == false)
		//			Application.LoadLevel ("MainMenu");
	}

	void FixedUpdate(){

	}

	void Jump() {

		int pressNumber = 0;

		foreach (Touch touch in Input.touches) {
			if(touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled){
				pressNumber++;
			}
		}

		if (Input.GetMouseButton (0) || pressNumber > 0) {
			if (in_floor == true)
				transform.position += jumpDistance * Time.deltaTime;

			in_floor = false;
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (in_floor == false)
			in_floor = true;

		if (collision.gameObject.name == "LevelEnd")
			Application.LoadLevel ("MainMenu");
	}
}
