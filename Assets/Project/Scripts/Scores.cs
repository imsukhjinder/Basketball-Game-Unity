using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour {
	public Player player;
	private static int count;
	public Text countText;
	public GameObject p;
	public float rstTimer = 5f;
	private static int countthrows = 10;
	public Text countTextthrow;

	// Use this for initialization
	void Start () {
		p.SetActive(false);
		
	}
	void OnTriggerEnter (Collider otherCollider) {
		if (otherCollider.GetComponent<Ball> () != null) {
			count = count + 5;	
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			countthrows =countthrows - 1;

		}
		if(countthrows <= 0){
			rstTimer -= Time.deltaTime;
			if (rstTimer <= 0) {
			p.SetActive(true);
			}
		}
		countTextthrow.text = "Throws :" + countthrows.ToString ();	
		countText.text = "Scores :" + count.ToString ();
			
	}

}
