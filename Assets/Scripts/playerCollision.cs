using UnityEngine;

public class playerCollision : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo) 
    {
            if(collisionInfo.collider.tag == "Obstacle")
            {
                Debug.Log("You Hit it!");
                movement.enabled = false;
            }
    }
}
