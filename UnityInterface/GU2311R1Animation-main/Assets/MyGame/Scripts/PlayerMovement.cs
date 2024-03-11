using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] float horizontalSpeed = 100f;
   [SerializeField] float verticalSpeed = 10f;
    private Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
            float h = horizontalSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
            float v = verticalSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
            transform.Translate(0, 0, v);
            transform.Rotate(0, h, 0);
            _anim.SetFloat("IsRun", Mathf.Abs(v));
    }
}
