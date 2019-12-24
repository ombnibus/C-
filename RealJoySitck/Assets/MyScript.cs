using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    // Start is called before the first frame update


    protected Joystick joystick;
    protected Joybutton Joybutton;

    protected bool jump;
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        Joybutton = FindObjectOfType<Joybutton>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joystick.Horizontal * 100f + Input.GetAxis("Horizontal") * 100f, rigidbody.velocity.y, joystick.Vertical * 100f + Input.GetAxis("Vertical") * 100f);

        if(!jump && Joybutton.Pressed || Input.GetButton("Fire2"))
        {
            jump = true;
        }

        if(jump && !Joybutton.Pressed || Input.GetButton("Fire2"))
        {
            jump = false;
        }
    }
}
