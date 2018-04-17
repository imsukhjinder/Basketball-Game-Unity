using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public Player player;
	public float resetTimer = 5f;
    public static int countshots = 10;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(countshots>1){
			if (player.holdingBall == false) {
			resetTimer -= Time.deltaTime;
			
			if (resetTimer <= 0) {
				SceneManager.LoadScene ("Game");
				countshots--;	
			}
		}
		}
	}
}
