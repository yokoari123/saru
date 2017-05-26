using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_move : MonoBehaviour {

    public float SPEED;
    public float Speed_Random_min = 0.1f;
    public float Speed_Random_max = 0.3f;
    float y;

	void Start () {
        transform.rotation = Quaternion.Euler(0, 180, 0);// オブジェクトの向きを上下反転させる
        Debug.Log("a");
        SPEED = Random.Range(Speed_Random_min,Speed_Random_max);
    }

    void Update () {
        Vector3 pos = transform.position;

        if (pos.y <= -10)
        {
            Destroy(gameObject);//画面を出たら削除
        }
        transform.position += new Vector3(0, -SPEED, 0);
    }
}
