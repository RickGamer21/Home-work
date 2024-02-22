using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Здоровье NPC
    public int health = 5;

    //Уровень NPC
    public int level = 1;

    //Скорость NPC
    public float speed = 1.2f;

    Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print(health);
        Vector3 newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.x += speed * Time.deltaTime;
        transform.position = newPosition;
    }

}
