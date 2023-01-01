using UnityEngine;
 using System.Collections;
 
 public class Respawn : MonoBehaviour 
{
 
     public GameObject spawnPoint;
   
     void OnCollisionEnter2D(Collision2D other)
     {
         if (other.gameObject.tag == "Ground")
         {
              this.transform.position = spawnPoint.transform.position;
         }
     }
}