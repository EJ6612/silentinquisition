using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speedIn; //value from UE

    private Rigidbody body;
    public Camera playerCamera;

    public Transform tiles;

    float rotationX = 0;
    float rotationY = 0;
    float lookSensitivityX = 1;
    float lookSensitivityY = 1;
    public float lookSpeed;
    public Button up;
    public Button down;
    public Button right;
    public Button left;

    //n.long1520@gmail.com

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void UseArrowButton(Button button)
    {
        if (button == up)
            transform.Translate(0, 0, speedIn * Time.deltaTime);

        if (button == left)
            transform.Translate(-speedIn * Time.deltaTime, 0, 0);

        if (button == down)
            transform.Translate(0, 0, -speedIn * Time.deltaTime);

        if (button == right)
            transform.Translate(speedIn * Time.deltaTime, 0, 0);//using speed
    }

    void Update()
    {    

        Transform camT = playerCamera.transform;
        Vector2 input = new Vector2(Input.GetAxis("Mouse Y") * -1, Input.GetAxis("Mouse X"));      

        if (input != Vector2.zero && Time.timeScale > 0)//when not paused and when mouse is moving
        {
            rotationY = rotationY + input.y * lookSensitivityX * lookSpeed;
            rotationX = Mathf.Clamp(rotationX + input.x * lookSensitivityY * lookSpeed, -90, 90);

            camT.localEulerAngles = new Vector3(rotationX, 0, camT.localEulerAngles.z);

            transform.localEulerAngles = new Vector3(0, rotationY);
        }
        if (Time.timeScale > 0) //when not paused
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////              
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) //right
            {
                transform.Translate(speedIn * Time.deltaTime, 0, 0);//using speed
                UseArrowButton(right);
            }
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) //backwards
            {
                transform.Translate(0, 0, -speedIn * Time.deltaTime);
                UseArrowButton(down);
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) //left
            {
                transform.Translate(-speedIn * Time.deltaTime, 0, 0);
                UseArrowButton(left);
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) //forward
            {
                transform.Translate(0, 0, speedIn * Time.deltaTime);
                UseArrowButton(up);
            }
            else
            {
                transform.Translate(0, 0, 0); //stop
            }
        }
    }
}