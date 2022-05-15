using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheck : MonoBehaviour
{
    public Transform player;
    public Transform box;
    private bool onBox;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            player.parent = box;
            /*buggy code that fixes sizing
            onBox = true;*/
        }
    }
    private void OnTriggerExit2D()
    {
        player.parent = null;
        //onBox = false;
    }

    /*private void Update()
    {
        if(onBox)
        {
            player.localScale = new Vector3(0.73f/2, 2.1f/2, player.localScale.z/2);
        }
    }*/
}
