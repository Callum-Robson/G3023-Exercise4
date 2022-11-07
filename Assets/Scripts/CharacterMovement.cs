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
    [SerializeField]
    Canvas canvas;
    public Vector3 loadedLocation;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(setSaveButtonPlayer), .5f);
        canvas = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Canvas>();
        transform.position = new Vector3(LoadLocation.coords[0], LoadLocation.coords[1], LoadLocation.coords[2]);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (canvas.gameObject.activeSelf)
            {
                canvas.gameObject.SetActive(false);
            }
            else
            {
                canvas.gameObject.SetActive(true);
            }
        }
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 newPosition = transform.position + new Vector3(x * Time.deltaTime * (MoveSpeed / 3), y * Time.deltaTime * (MoveSpeed / 3));

        rigidBody.MovePosition(newPosition);
    }

    private void setSaveButtonPlayer()
    {
        saveButton = GameObject.FindGameObjectWithTag("SaveButton").GetComponent<SaveGameButton>();
        if (CompareTag("Player"))
        {
            saveButton.player = transform.gameObject;
        }
    }

}
