using UnityEngine;
using System.Collections;

public class lightUp : MonoBehaviour {
	public Material lightUpMaterial;
	public GameObject gameLogic;
	private Material defaultMaterial;


	// Use this for initialization
	void Start () {
		defaultMaterial = this.GetComponent<MeshRenderer> ().material; //Save our initial material as the default
		//this.GetComponentInChildren<ParticleSystem>().enableEmission = false; //Start without emitting particles

		//gameLogic = GameObject.Find ("GameLogic");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void patternLightUp(float duration) { //The lightup behavior when displaying the pattern
		StartCoroutine(lightFor(duration));
	}


	public void gazeLightUp() {
		this.GetComponent<MeshRenderer>().material = lightUpMaterial; //Assign the hover material
		//this.GetComponentInChildren<ParticleSystem>().enableEmission = true; //Turn on particle emmission
		//this.GetComponent<GvrAudioSource>().Play();

		//gameLogic.GetComponent<gameLogic>().playerSelection(this.gameObject);


	}
	public void playerSelection() {
		gameLogic.GetComponent<GameLogic>().playerSelection(this.gameObject);
		this.GetComponent<GvrAudioSource>().Play();
	}
	public void aestheticReset() {
		this.GetComponent<MeshRenderer>().material = defaultMaterial; //Revert to the default material
		//this.GetComponentInChildren<ParticleSystem>().enableEmission = false; //Turn off particle emission
	}

	public void patternLightUp() { //Lightup behavior when the pattern shows.
		this.GetComponent<MeshRenderer>().material = lightUpMaterial; //Assign the hover material
		//this.GetComponentInChildren<ParticleSystem>().enableEmission = true; //Turn on particle emmission
		this.GetComponent<GvrAudioSource> ().Play (); //Play the audio attached
	}


	IEnumerator lightFor(float duration) { //Light us up for a duration.  Used during the pattern display
		patternLightUp ();
		yield return new WaitForSeconds(duration-.1f);
		aestheticReset ();
	}
}
