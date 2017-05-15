using UnityEngine;
using System.Collections;

public class item : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D c)
    {

        // レイヤー名を取得
        string layerName = LayerMask.LayerToName(c.gameObject.layer);

        // レイヤー名がBullet (Player)以外の時は何も行わない
        if (layerName == "Player")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                // エネミーの削除
                Destroy(gameObject);
            }
        }
    }
}