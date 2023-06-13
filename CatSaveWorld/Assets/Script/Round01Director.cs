using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round01Director : MonoBehaviour
{
    bool item01;
    bool item02;
    // Start is called before the first frame update
    void Start()
    {

        item01 = false;
        item02 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (item01 == true && item02 == true)
        {
            //
            Debug.Log("Round01 clear");
            // mpc active
        }
    }

    public void setItem01()
    {
        item01 = true;
    }

    public void setItem02()
    {
        item02 = true;
    }
}
