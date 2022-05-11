using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeafScript : MonoBehaviour
{
    public GameObject startingPoint;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player.transform.position = startingPoint.transform.position;
        }   
    }
}
