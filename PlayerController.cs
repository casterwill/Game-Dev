using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variable
    private float speed = 10.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float verticalInput;

    //public  variable
    public Camera tpsCamera;
    public Camera fpsCamera;
    public KeyCode switchKey;
    public string inputID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //digunakan untuk mendapatkan input dari player
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalInput = Input.GetAxis("Vertical" + inputID);

        //Menjalankan mobil ke depan
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        
        //membelokkan mobil
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetKeyDown(switchKey))
        {
            tpsCamera.enabled = !tpsCamera.enabled;
            fpsCamera.enabled = !fpsCamera.enabled;
        }
    }
}
