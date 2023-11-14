using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nps : MonoBehaviour
{
    public int health = 10;
    public int lvl = 1;
    public int speed = 11000000;
    private Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        // ананс
        health += lvl;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;

        
    }
}
