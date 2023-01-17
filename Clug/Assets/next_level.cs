using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next_level : MonoBehaviour
{
    public GameObject tpLvl2;
    public GameObject cam;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Portal")
        {
            this.transform.position = tpLvl2.transform.position;
            cam.transform.position = new Vector3(tpLvl2.transform.position.x, tpLvl2.transform.position.y);
        }
    }
}