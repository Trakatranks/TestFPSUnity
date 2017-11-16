using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

    [SerializeField]
    [Range(0, 20)]
    protected float cameraSpeed = 10;

    [SerializeField]
    protected float lockUp = 85;
    [SerializeField]
    protected float lockDown = -85;

    // 
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update () {

        float lookV = Input.GetAxis("Mouse Y");
        float lookH = Input.GetAxis("Mouse X");

        transform.Rotate(Vector3.up, lookH, Space.World);
        transform.Rotate(Vector3.right, -lookV, Space.Self);

        if (Mathf.DeltaAngle(transform.rotation.eulerAngles.x, 0) > lockUp)
        {
            transform.rotation = Quaternion.Euler(-lockUp, transform.rotation.eulerAngles.y, 0);
        }
        if (Mathf.DeltaAngle(transform.rotation.eulerAngles.x, 0) < lockDown)
        {
            transform.rotation = Quaternion.Euler(-lockDown, transform.rotation.eulerAngles.y, 0);
        }

        //Changer des positions
        //transform.position = new Vector3(transform.position.x + speed * Time.deltaTime * lookH, transform.position.y + speed * Time.deltaTime * lookV, 0);
    }
    
}
