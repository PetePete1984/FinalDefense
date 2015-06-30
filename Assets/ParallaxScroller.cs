using UnityEngine;
using System.Collections;

public class ParallaxScroller : MonoBehaviour {

	public float unitsPerSecond = 0f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3 target = transform.position;
		if (transform.position.x <= 16) {
			float step = unitsPerSecond * Time.deltaTime;
			target.Set(target.x + 16, target.y, target.z);
			transform.position = Vector3.MoveTowards(transform.position, target, 	step);
		} else {
			transform.position = transform.position - new Vector3(32, 0, 0);
		}
	}
}
