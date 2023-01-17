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
              cam.transform.position = new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y);
         }
     }
}