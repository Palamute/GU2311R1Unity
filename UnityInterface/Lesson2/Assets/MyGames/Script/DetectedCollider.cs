using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectedCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("bat dau va cham");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("va cham va giu yen vi tri");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("sau va cham va ket thuc");
    }
    */
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("bat dau va cham");
            Destroy(gameObject);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("va cham va giu yen vi tri");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("sau va cham va ket thuc");
        }
    }
}
