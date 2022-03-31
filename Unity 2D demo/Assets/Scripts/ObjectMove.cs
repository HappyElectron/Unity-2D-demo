using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector2 target1;
    [SerializeField] private Vector2 target2;
    [SerializeField] private Vector2 position;
    [SerializeField] private bool isAtTarget1;

    private void Start()
    {
        position = gameObject.transform.position;
        speed = speed/10;
        speed = speed * Time.deltaTime;
    }

    void Update()
    {
        if(transform.position.x == target1.x && transform.position.y == target1.y)
        {
            isAtTarget1 = true;
        }
        if(transform.position.x == target2.x && transform.position.y == target2.y)
        {
            isAtTarget1 = false;
        }
        if(isAtTarget1)
        {
            transform.position = Vector2.MoveTowards(transform.position, target2, speed);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, target1, speed);
        }

    }
}
