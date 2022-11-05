using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rigidBody;
    [SerializeField]
    [Range(0, 6)]
    private float MoveSpeed = 2;
    private SaveGameButton saveButton;
    private LoadLocation loadLocation;

    // Start is called before the first frame update
    void Start()
    {
        saveButton = GameObject.FindGameObjectWithTag("SaveButton").GetComponent<SaveGameButton>();
        loadLocation = GameObject.FindGameObjectWithTag("LoadLocation").GetComponent<LoadLocation>();
        if (CompareTag("Player"))
        {
            saveButton.player = transform.gameObject;
            loadLocation.player = transform.gameObject;
        }
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
