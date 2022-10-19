using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rigidBody;
    [SerializeField]
    [Range(0, 6)]
    private float MoveSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 newPosition = transform.position + new Vector3(x * Time.deltaTime * (MoveSpeed / 3), y * Time.deltaTime * (MoveSpeed / 3));

        rigidBody.MovePosition(newPosition);
    }
}
