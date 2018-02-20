using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lava : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter( Collider yo )
	{

		if( yo.gameObject.CompareTag( "Player" ) )
			SceneManager.LoadScene( SceneManager.GetActiveScene().name );
		Debug.Log("Collision Detected "+yo.gameObject.name);

	}
}
