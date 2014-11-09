using UnityEngine;
using System.Collections;

public class changeAnimation : MonoBehaviour {
	protected Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) { 
						animator.SetBool ("isWalk", true);
				} else {
			animator.SetBool ("isWalk", false);
				}
	}
}
