using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Collider2D))]
public class ScoreItem : MonoBehaviour {
	
	public float m_score = 100f;
	
	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.transform.CompareTag("Player")) {
			col.SendMessage("AddScore", m_score, SendMessageOptions.DontRequireReceiver);
			Destroy(gameObject);
		}
	}
}
