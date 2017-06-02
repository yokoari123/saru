using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CState : MonoBehaviour {

    public bool item_state = false;

    void Awake()
    {
        if(item_state == false)DontDestroyOnLoad(transform.gameObject);
    }

    // Use this for initialization
    void Start () {
              
        if (item_state == false)
        {
            item_state = true;
        }
        else if (item_state == true)
        {
            item_state = false;
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
