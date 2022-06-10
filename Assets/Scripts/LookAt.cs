using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject Player;
    public Joystick joystick;
    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position;
        CameraLook();
        
    }
    public void CameraLook()
    {
        if(joystick.Horizontal != 0 && joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(-(joystick.Vertical) * 30, (joystick.Horizontal) * 180, transform.rotation.z));
        }
    }
}
