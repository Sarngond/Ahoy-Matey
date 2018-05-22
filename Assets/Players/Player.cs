using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {

	public float moveSpeed = 10f;

	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer) {
			return;
		}

		Move ();
	}

	void Move () {
		float h = CrossPlatformInputManager.GetAxis ("Horizontal");
		float v = CrossPlatformInputManager.GetAxis ("Vertical");

		transform.Translate (new Vector3 (h, 0, v) * Time.deltaTime * moveSpeed);

	}
}
