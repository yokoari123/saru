using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class omise : MonoBehaviour
{

    public float m_heigth_max;
    public float m_heigth_min;

    void Update()
    {
        trans();
    }

    void trans()
    {
        Vector2 m_playerPos = GameObject.Find("player").transform.position;

        //Debug.Log(m_playerPos);

        if (m_heigth_min > m_playerPos.y)
        {

            SceneManager.LoadScene("yokeru");

        }
        if (m_heigth_max <= m_playerPos.y)
        {

            SceneManager.LoadScene("taitle");

        }
    }
}
