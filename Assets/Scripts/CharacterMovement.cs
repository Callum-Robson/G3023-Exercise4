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
    [SerializeField]
    Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(setSaveAndLoadPlayer), .5f);
        canvas = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Canvas>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 newPosition = transform.position + new Vector3(x * Time.deltaTime * (MoveSpeed / 3), y * Time.deltaTime * (MoveSpeed / 3));

        rigidBody.MovePosition(newPosition);

        if(Input.GetKeyDown(KeyCode.I))
        {
            if(canvas.gameObject.activeInHierarchy)
            {
                canvas.gameObject.SetActive(false);
            }
            else
            {
                canvas.gameObject.SetActive(true);
            }
        }
    }

    private void setSaveAndLoadPlayer()
    {
        saveButton = GameObject.FindGameObjectWithTag("SaveButton").GetComponent<SaveGameButton>();
        loadLocation = GameObject.FindGameObjectWithTag("LoadLocation").GetComponent<LoadLocation>();
        if (CompareTag("Player"))
        {
            saveButton.player = transform.gameObject;
            loadLocation.player = transform.gameObject;
        }
    }
}
