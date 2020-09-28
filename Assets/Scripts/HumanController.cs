using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController : MonoBehaviour
{
    public TankMover mover;

    public enum ControlType { WASD, ArrowKeys };
    public ControlType controlType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controlType == ControlType.WASD)
        {
            if (Input.GetKey(KeyCode.W))
            {
                //Move Foward (+)
                mover.Move(true);
            }
            if(Input.GetKey(KeyCode.A))
            {
                //Rotate Counterclockwise (-)
                mover.Rotate(false);
            }
            if(Input.GetKey(KeyCode.S))
            {
                //Move Backward (-)
                mover.Move(false);
            }
            if(Input.GetKey(KeyCode.D))
            {
                //Rotate Clockwise (+)
                mover.Rotate(true);
            }
        }

        if (controlType == ControlType.ArrowKeys)
        {

        }

    }
}
