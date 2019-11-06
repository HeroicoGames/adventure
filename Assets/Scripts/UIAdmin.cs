using UnityEngine;
using System.Collections;

public class UIAdmin : MonoBehaviour {

	public Animator startButton;
	public Animator optionsButton;
	public Animator optionsPanel;

	public void ChangeLevel(string scene_name) {
		Application.LoadLevel (scene_name);
	}

	public void HideButtons(bool hidden){
		startButton.SetBool ("hide", hidden);
		optionsButton.SetBool ("hide", hidden);
	}

	public void HideOptions(bool hidden){

		optionsPanel.enabled = true;
		optionsPanel.SetBool ("hide", hidden);

	}
}
