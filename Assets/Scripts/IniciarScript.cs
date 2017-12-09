using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class IniciarScript : MonoBehaviour {


	void Start(){
		FlappyBirdScript.inGame = false;
	}

	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Return) || Input.touchCount == 2){
			PrincipalScript.pontos = 0;
			SceneManager.LoadScene ("GameScene");
		}
	}
}
