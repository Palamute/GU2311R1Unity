using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EceptionsExample : MonoBehaviour
{

    public GameObject MutanPrefabs;
    // Start is called before the first frame update
    void Start()
    {
          
        try
        {
            Instantiate(MutanPrefabs, transform.position, transform.rotation);
        }
        catch (System.Exception ex)
        {

            Debug.Log(ex.Message);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
