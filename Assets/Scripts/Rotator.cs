using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	public float speed = 1;
	void Update () 
	{
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime * speed);
	}
}