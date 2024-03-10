using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private bool isCollider=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            GameManager.Instance.SetCoinCar();
            Destroy(collision.gameObject);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Finish"&&isCollider == false)
        {
            GameManager.Instance.SetLapscar();
            isCollider = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Invoke("Reset", 1);
    }
    private void Reset()
    {
        isCollider = false;
    }
}
