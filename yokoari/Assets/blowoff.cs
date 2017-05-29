using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blowoff : MonoBehaviour {

    public static int i=1;

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (i != 10)
        {
            gameObject.transform.localScale += new Vector3(0.05f,0.05f, 1);
            i++;
        }
	}
}
