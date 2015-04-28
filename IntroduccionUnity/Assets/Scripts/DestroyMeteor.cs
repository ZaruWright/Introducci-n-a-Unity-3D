using UnityEngine;
using System.Collections;

public class DestroyMeteor : MonoBehaviour {

	public float minHeight = 0.0f;

	void Update (){
		if (transform.position.y <= minHeight)
			Destroy (gameObject);
	}
}
