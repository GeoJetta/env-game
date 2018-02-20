using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {

	public int health;
	public Text healthText;
	float dSpeed;
	float lastPos;

	// Use this for initialization
	void Start () {
		health = 100;
		dSpeed = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if( health < 0 )
			SceneManager.LoadScene( SceneManager.GetActiveScene().name );
		healthText.text = "Health: " + health.ToString();

		dSpeed = gameObject.transform.position.y - lastPos;
		lastPos = gameObject.transform.position.y;
	}

	void OnCollisionStay( Collision iCol )
	{

		if (iCol.gameObject.CompareTag ("Enemy"))
			health -= 3;

	}

	void OnCollisionEnter( Collision iCol )
	{

		if (!iCol.gameObject.CompareTag("Enemy") && dSpeed < -0.2 )
			health -= 70;

	}
}
