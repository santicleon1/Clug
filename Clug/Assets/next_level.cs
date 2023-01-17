using UnityEngine;
 using System.Collections;
 
 public class next_level : MonoBehaviour
{
    public GameObject portal;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Portal")
        {
            this.transform.position = portal.transform.position;
        }
    }
}