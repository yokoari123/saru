using UnityEngine;
using System.Collections;

public class item : MonoBehaviour
{
    public int itemID;  //アイテムID

    public Player_item player_item;

    void OnTriggerEnter2D(Collider2D c)
    {

        // レイヤー名を取得
        string layerName = LayerMask.LayerToName(c.gameObject.layer);

        // レイヤー名がBullet (Player)以外の時は何も行わない
        if (layerName == "Player")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                player_item.SItem(itemID);
                
                // エネミーの削除
                Destroy(gameObject);

            }
        }
    }
}