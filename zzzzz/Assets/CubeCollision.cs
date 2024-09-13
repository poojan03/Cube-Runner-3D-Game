using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    
    public CubeCode movement;
   
void OnCollisionEnter (Collision collisionInfo)

{
    if (collisionInfo.collider.tag == "Breaker")
    {
         movement.enabled = false;
         FindObjectOfType<GameManager>().EndGame();
    }
}
}