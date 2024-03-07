using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next_level2 : MonoBehaviour
{
    public GameObject tpLvl3;
    public GameObject cam;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Portal2")
        {
            this.transform.position = tpLvl3.transform.position;
            cam.transform.position = new Vector3(tpLvl3.transform.position.x, tpLvl3.transform.position.y);
        }
    }
}