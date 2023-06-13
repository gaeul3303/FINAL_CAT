using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestItem : MonoBehaviour
{
    Transform player;
    float discance = 5f;
    public GameObject itemSlot;
    string name;
    GameObject director;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player").transform;
        this.name = this.gameObject.name;
        this.director = GameObject.Find("Round01Director");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < discance
            && Input.GetMouseButtonDown(0))
        {
            this.itemSlot.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            //Destroy(this.gameObject);
            if(name == "Cube")
            {
                director.GetComponent<Round01Director>().setItem01();
                Debug.Log("item01");
                
            }
            else if(name == "Cube2")
            {
                director.GetComponent<Round01Director>().setItem02();
                Debug.Log("item0");
            }
        }
    }
}
