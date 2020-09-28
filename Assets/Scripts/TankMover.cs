using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMover : MonoBehaviour
{
    private CharacterController cc;
    private TankData data;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        data = GetComponent<TankData>();
    }


    public void Move ( bool isForward )
    {
        if (isForward)
        {
            cc.SimpleMove(transform.forward * data.speed);
        }
        else
        {
            cc.SimpleMove(-transform.forward * data.speed);
        }
    }

    public void Rotate (bool isClockwise)
    {
        if (isClockwise)
        {
            transform.Rotate(new Vector3(0, data.rotateSpeed * Time.deltaTime, 0));
        }
        else
        {
            transform.Rotate(new Vector3(0, -data.rotateSpeed * Time.deltaTime, 0));
        }
    }
}
