using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    public float distance = 6;
    public float height = 5f;
    public float shouderOffset = 0;
    public bool switchSoulder = false;
    public float smoothtime = 0.25f;
    private Vector3 looktarget;
    private Vector3 lookTargetVelocity;
    private Vector3 currentVelocity;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void LateUpdate()
    {
        Vector3 target = player.position-player.transform.forward*distance;
        Vector3 vericalPosition = Vector3.up * height;
        Vector3 shoulderPosition = switchSoulder ? transform.right*-shouderOffset: transform.right*shouderOffset;
        transform.position = Vector3.SmoothDamp(transform.position, target + vericalPosition + shoulderPosition,ref currentVelocity, smoothtime);
        looktarget = Vector3.SmoothDamp(looktarget, player.position + vericalPosition + shoulderPosition, ref lookTargetVelocity, smoothtime);
        transform.LookAt(looktarget);
    }
}
