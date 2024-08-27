using UnityEngine;

public class playerCollision : MonoBehaviour{
    public playerMovement movement;
    
    void OnCollisionEnter (Collision CollisionInfo)
    {
        if(CollisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
