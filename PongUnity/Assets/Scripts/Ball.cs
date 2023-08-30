using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float movementSpeed;
    public Vector3 direction;
    public float maxXposition;

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBoundaries();
    }

    void Move()
    {
        transform.position += direction * movementSpeed * Time.deltaTime;
    }


    public void Bounce(Vector3 newDirection)
    {
        direction = newDirection;
    }


    public void CheckBoundaries()
    {
        if (transform.position.x > maxXposition)
        {
            Scoreboard.Instance.GivePointToP1();
            Destroy(gameObject);
        }
        else if (transform.position.x < -maxXposition)
        {
            Scoreboard.Instance.GivePointToP2();
            Destroy(gameObject);
        }
    }
}
