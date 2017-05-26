using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CTransition : MonoBehaviour {
    /*
    public float m_screenWidth  = Screen.width;
    public float m_screenHeight = Screen.height;
    public float m_width  = 160;
    */

    public float m_heigth_max;
    public float m_heigth_min;

    void Update() {
        trans();
    }

    void trans()
    {
        Vector2 m_playerPos = GameObject.Find("player").transform.position;

        //Debug.Log(m_playerPos);

        if (m_heigth_min > m_playerPos.y)
        {

            SceneManager.LoadScene("system");
            Debug.Log("Scene : system");

        }
        if (m_heigth_max <= m_playerPos.y)
        {

            SceneManager.LoadScene("taitle");
            Debug.Log("Scene : test");

        }
    }
}