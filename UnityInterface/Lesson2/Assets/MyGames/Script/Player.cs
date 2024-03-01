using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float health;
    private float fuel;
    private float capacity = 100;
    public int laps = 0;
    // Start is called before the first frame update
    void Start()
    {
        fuel = capacity;
        health = 100;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Damage")
        {
            health -= 5;
            Debug.Log(health);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "BarrelRed")
        {
            fuel += 25;
            if (fuel > 100) fuel = 100;
            Debug.Log(fuel);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "BarrelBlue")
        {
            fuel += 10;
            if (fuel > 100) fuel = 100;
            Debug.Log(fuel);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Box")
        {
            health += 30;
            if (health > 100) health = 100;
            Debug.Log(fuel);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "BoxFull")
        {
            health = 100;
            Debug.Log(fuel);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Finish")
        {
            laps += 1;
        }
        if (health < 0)
        {
            //SceneManager.LoadScene("Lesson6");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
