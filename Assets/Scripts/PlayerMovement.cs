using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;


    private void Awake()
    {
      
    }




    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.position += new Vector3(0, speed, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -speed, 0);
        }

    }



}
