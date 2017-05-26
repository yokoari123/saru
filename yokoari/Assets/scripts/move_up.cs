using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_up : MonoBehaviour
{

    public float m_enemy_Speed;               //落下速度
    public float m_speed_Random_min = 0.1f;   //落下速度のランダム最小値
    public float m_speed_Random_max = 0.3f;   //落下速度のランダム最大値
                                              //public float out_scen;
    private float m_spawn_X;
    public float m_spawn_Random_min = 0.0f;
    public float m_spawn_Random_max = 5.0f;

    void Start()
    {
        //transform.rotation = Quaternion.Euler(0, 180, 0);// オブジェクトの向きを上下反転させる
        //Debug.Log("a");
        m_enemy_Speed = Random.Range(m_speed_Random_min, m_speed_Random_max);
        m_spawn_X = Random.Range(m_spawn_Random_min, m_spawn_Random_max);
        Vector2 m_spawn_Pos = new Vector2(m_spawn_X, 0);
    }

    void Update()
    {
        Vector3 pos = transform.position;

        if (pos.y <= -10)
        {
            //Destroy(gameObject);//画面を出たら削除
        }
        transform.position += new Vector3(0, m_enemy_Speed, 0);
    }
}
