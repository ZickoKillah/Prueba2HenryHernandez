using System.Collections;
using UnityEngine;

public class StunEnemy : MonoBehaviour
{
    private Collider2D enemyCollider;

   void OnTriggerEnter2D(Collider2D other)
    {
        PlayerPhysics player = other.GetComponent<PlayerPhysics>();
        if (player != null)
        {
            player.Stun();

        }
    }
}
   
        
        


