using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CItem : MonoBehaviour
{
    public int itemID;             //アイテムID


    public Player_item player_item;

    void OnTriggerEnter2D(Collider2D col)
    {

        // レイヤー名を取得
        string layerName = LayerMask.LayerToName(col.gameObject.layer);

        // レイヤー名がBullet (Player)以外の時は何も行わない
        if (layerName == "Player")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                player_item.SItem(itemID);
                Debug.Log("id : " + itemID);
                //アイテムを削除する
                Destroy(gameObject);
            }

        }
    }

}

