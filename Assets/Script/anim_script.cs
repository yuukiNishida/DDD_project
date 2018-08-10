using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_script : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
		
	}

	void OnCollisionEnter (Collision collision)
	{
		Animation anim = GetComponent<Animation> ();
        anim.Play();
    }

}