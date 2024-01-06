using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    
    void Update()
    {
        Vector3 lookdirection = (player.transform.position - transform.position).normalized;//normalized will help them to maintain an equal distance.
        enemyRb.AddForce(lookdirection * speed);
        
    }
}
