using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPayermove : MonoBehaviour
{
    public bool m_flg = true;
    private int  m_cnt = 0;

    // 速度
    public Vector2 SPEED = new Vector2(0.05f, 0.05f);

    //オブジェクトが衝突したとき
    void OnTriggerEnter2D(Collider2D hit)
    {
        //Debug.Log("衝突");
        if (hit.gameObject.tag == "enemy")
        {
            m_flg = false;
        }
    }
    
    // Update is called once per frame
    void Update()
    {

        //Debug.Log("cnt:" + m_cnt);
        if (m_flg == true)
        {
            // 移動処理
            Move();
        }
        else if(m_flg == false)
        {
            m_cnt++;
            if(m_cnt == 50)
            {
                //Debug.Log("player停止");
                m_flg = true;
                m_cnt = 0;
            }
        }
        
    }


    // 移動関数
    void Move()
    {
        // 現在位置をPositionに代入
        Vector2 pos = transform.position;
        // 左キーを押し続けていたら
        if (Input.GetKey("left"))
        {
            // 代入したPositionに対して加算減算を行う
            pos.x -= SPEED.x;
        }
        else if (Input.GetKey("right"))
        { // 右キーを押し続けていたら
          // 代入したPositionに対して加算減算を行う
            pos.x += SPEED.x;
        }
        else if (Input.GetKey("up"))
        { // 上キーを押し続けていたら
          // 代入したPositionに対して加算減算を行う
            pos.y += SPEED.y;
        }
        else if (Input.GetKey("down"))
        { // 下キーを押し続けていたら
          // 代入したPositionに対して加算減算を行う
            pos.y -= SPEED.y;
        }
        // 現在の位置に加算減算を行ったPositionを代入する
        transform.position = pos;
        //Debug.Log("px : " + pos.x + " :" + "py : " + pos.y);
    }

}