using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_item : MonoBehaviour {

    public string item = "item_id";

    public void SItem(int id)
    {
        int m_item_Id;
        int i;

        PlayerPrefs.SetInt(item,id);
         i = PlayerPrefs.GetInt(item);

        //Debug.Log(m_item_Id);
        //Debug.Log("i:"+i);
    }
}
