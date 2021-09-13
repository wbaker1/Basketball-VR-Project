using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateBall : MonoBehaviour
{
    // Start is called before the first frame update

    //public float speed = 5.0f;
    //public float camPos = 0.0f;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided");
        GameObject plane = GameObject.Find("Plane");
        GameObject cube3 = GameObject.Find("Cube3");
        //GameObject cube1 = GameObject.Find("Cube1");
        //GameObject cube2 = GameObject.Find("Cube2");

        if (collision.gameObject.name == "Plane")
        {
            Instantiate(cube3);
        }
    }

}