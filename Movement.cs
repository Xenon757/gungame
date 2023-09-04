using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController player;
    public float speed = 20;
    public float sensitivity = 10;
    Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
        camera = Camera.main;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    public void movement()
    { //movement of player
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        player.Move(Quaternion.Euler(new Vector3(0, transform.eulerAngles.y, 0)) * new Vector3(horizontal, 0, vertical) * Time.deltaTime * speed);
        float mouseX = Input.GetAxisRaw("Mouse X");
        float mouseY = Input.GetAxisRaw("Mouse Y");
        camera.transform.Rotate(new Vector3(-mouseY * sensitivity, 0, 0));
        transform.Rotate(new Vector3(0, mouseX * sensitivity, 0));
    }
}
