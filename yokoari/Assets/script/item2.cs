using UnityEngine;
using System.Collections;
public class item2 : MonoBehaviour
{
    void Awake()
    {
        Object.DontDestroyOnLoad(transform.gameObject);
    }
    public GameObject[] Train;

    public int number;
    void Start()
    {
       
        number = Random.Range(0, Train.Length);
        Instantiate(Train[number], transform.position, transform.rotation);
    }
}