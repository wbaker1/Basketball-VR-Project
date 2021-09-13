using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // Start is called before the first frame update

    //public float speed = 5.0f;
    //public float camPos = 0.0f;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided");


        //ContactPoint contact = collision.contacts[0];
        //Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        //Vector3 position = contact.point;


        // Get the color of Cube2 before it changes
        GameObject cube2 = GameObject.Find("Cube2");
        Color color2 = cube2.GetComponent<Renderer>().material.GetColor("_Color");

        if (collision.gameObject.name == "Cube1")
        {

            //Debug.Log("Cube2 was hit by something");
            //Color color1 = collision.gameObject.GetComponent<Renderer>().material.GetColor("_Color");
            //Debug.Log(color1);
            GetComponent<Renderer>().material.color = collision.gameObject.GetComponent<Renderer>().material.GetColor("_Color");

            GameObject cube1 = GameObject.Find("Cube1");
            cube1.GetComponent<Renderer>().material.color = color2;
            Debug.Log("Colors swapped");
            Destroy(cube2);
            GameObject cube3 = Instantiate(cube1, new Vector3(0, 3, 0), Quaternion.identity);
            cube3.name = "Cube3";
            Destroy(cube1);
        }
        //Do something unrelated to the colliding objects
        //but still triggered by the collision even

        Debug.Log("Cube2 color:" + cube2.GetComponent<Renderer>().material.GetColor("_Color"));

        //Debug.Log(position.x);
    }

}
