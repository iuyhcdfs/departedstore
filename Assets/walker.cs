using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class walker : MonoBehaviour
{
    public Transform player;
    public JoyconDemo joycon;
    public UnityEngine.AI.NavMeshAgent agent;
    public float speed;
    int frame;
    // Start is called before the first frame update
    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "katana"){
        if(frame > 10){
        joycon.Vibe();
        }
        Destroy(gameObject);
        }
    }
    void Start()
    {
        agent.destination = player.transform.position;
        frame = 0;
        if(joycon == null){
            Debug.Log("no joycon");
            Debug.Break();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        frame++;
        transform.LookAt(player);
        agent.destination = player.transform.position;
        //this.transform.position += this.transform.forward * speed;
    }
}
