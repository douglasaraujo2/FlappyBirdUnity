using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoScript : MonoBehaviour
{

	public float velocidade;
	public float alturaInicial, alturaFinal;
	public float limiteX;


	void Update ()
	{
		if (FlappyBirdScript.inGame) {

			//Move o cano
			transform.Translate (Vector2.left * velocidade * Time.deltaTime);

			//Verifica o limite e retorna o cano
			if (transform.position.x <= limiteX) {
				transform.position = new Vector2 (limiteX * -1, Random.Range (alturaInicial, alturaFinal));

			}
		}


	}
}
