using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public GameObject target;
    void Update()
    {
        transform.position = new Vector3(transform.position.x, target.transform.position.y, -10); 
    }
}
