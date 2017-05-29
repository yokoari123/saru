using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state_item : MonoBehaviour {

    public bool item_state = false;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

        if (item_state == false)
        {
            item_state = true;
        }
        else if (item_state == true)
        {
            item_state = false;
        }

    }

}
