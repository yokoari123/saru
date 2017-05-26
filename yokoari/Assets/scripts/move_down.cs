using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_down : MonoBehaviour
{
    public CSpawn cspawn;

    private float m_enemy_Speed;                           //落下速度
    public float m_speed_Random_min;                       //落下速度のランダム最小値
    public float m_speed_Random_max;                       //落下速度のランダム最大値
                                                          
    public float m_spawn_Xrandom_min;                     //ランダムスポーンのx最小値
    public float m_spawn_Xrandom_max;                     //ランダムスポーンのx最大値

    public float m_spawn_Yrandom_min;                     //ランダムスポーンのy最小値
    public float m_spawn_Yrandom_max;                     //ランダムスポーンのy最大値

    //public float m_h = Screen.height;                      //シーンの高さ
    //public float m_w = Screen.width;                       //シーンの幅

    bool m_enemyflg  = true;
    float m_enemyCnt = 0;


    void OnTriggerEnter2D(Collider2D hit)
    {
        m_enemyflg = false;
    }

    void Start()
    {

    }

    void Update()
    {

        m_enemy_Speed = Random.Range(m_speed_Random_min, m_speed_Random_max);


        if (m_enemyflg == true)
        {
            transform.position += new Vector3(0, -m_enemy_Speed,0);
        }
        else if(m_enemyflg == false)
        {
            m_enemyCnt++;
            if(m_enemyCnt == 50)
            {
                m_enemyflg = true;
                m_enemyCnt = 0;
            }
        }

        if (transform.position.y <= -10)
        {
            Destroy(gameObject);
        }
    }

}
