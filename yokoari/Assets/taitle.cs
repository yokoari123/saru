using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class taitle : MonoBehaviour {

    public float m_heigth_max;
    public float m_heigth_min;

    public Player_item player_item;
    public int ii;
    public int aa;
    public int point;

    public item2 item2;

    public bool score_flg = false;


        void Start()
    {
        ii = 0;
        aa = 0;
    }

    void Update()
    {
        trans();

        //aa = item2.number;

        string id = player_item.item;
        ii = PlayerPrefs.GetInt(id);
        
        /*
        if(ii == aa)
        {
            FindObjectOfType<SCORE>().AddPoint(point);
        }
        */

        Debug.Log("ii : " + ii);
    }
    

    void trans()
    {
        Vector2 m_playerPos = GameObject.Find("player").transform.position;

        //Debug.Log(m_playerPos);

        /*
                if (m_heigth_min < m_playerPos.y)
                {

                    SceneManager.LoadScene("omise");

                }
        */

        if (m_heigth_min > m_playerPos.y)
        {

            SceneManager.LoadScene("system");

        }
    }
}
