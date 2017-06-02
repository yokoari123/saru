using UnityEngine;
using System.Collections;
public class item2 : MonoBehaviour
{
    public GameObject[] Train;
    public int number;

    //public GameObject item;
    //public CState cstate;



    void Start()
    {
        //item = GameObject.Find("Item");
        //cstate = item.GetComponent<CState>();

            number = Random.Range(0, Train.Length);

            Instantiate(Train[number], transform.position, transform.rotation);

            Debug.Log(number);
    }


}