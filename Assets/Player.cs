using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public float  kecepatan = 50f;
	private Rigidbody rb;
	private int point;
	public Text pointText;

	// Use this for initialization
	void Start () {
		rb =  GetComponent<Rigidbody>();
		point = 0;
		SetCountText ();

		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)){
			this.gameObject.GetComponent<Rigidbody> ().AddForce(Vector3.up * kecepatan);
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			this.gameObject.GetComponent<Rigidbody> ().AddForce(Vector3.left * kecepatan);
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			this.gameObject.GetComponent<Rigidbody> ().AddForce(Vector3.right * kecepatan);
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			this.gameObject.GetComponent<Rigidbody> ().AddForce(Vector3.back * kecepatan);
		}
		if (Input.GetKey(KeyCode.UpArrow)){
			this.gameObject.GetComponent<Rigidbody> ().AddForce(Vector3.back * -kecepatan);
		}
		

		//transform.Translate(kecepatan*Input.GetAxis("Horizontal") * Time.deltaTime,0.0f,kecepatan * Input.GetAxis("Vertical") * Time.deltaTime);
		
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("Enemy")){
			other.gameObject.SetActive (false);
			point = point + 1;
			SetCountText ();
		}
	}
	void SetCountText(){
		pointText.text = " Point : " +point.ToString ();
	}
}
