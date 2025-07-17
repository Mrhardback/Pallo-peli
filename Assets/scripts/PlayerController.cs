using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour {
    public Vector3 jump;
    public float jumpforce = 2.0f;
    public bool isGrounded;

    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;  
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    public GameObject particlesystemObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0f, 2f, 0f);
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);

        particlesystemObject .SetActive(false);
        }
    private void OnCollisionStay() 
        {
        isGrounded = true;
    }
    void OnCollisionExit() {
        isGrounded = false;
    }
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {

            rb.AddForce(jump * jumpforce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnMove(InputValue movementValue) {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    void SetCountText() {
        countText.text = "Count: " + count.ToString();

        if (count >= 12) {
            winTextObject.SetActive(true);
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
            particlesystemObject .SetActive(true);
        }
    }
    void FixedUpdate() {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other) {

        if (other.gameObject.CompareTag("PickUp")) {
            other.gameObject.SetActive(false);

            count = count + 1;

            SetCountText();
        }

    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Enemy")) {
            // Destroy the current object
            Destroy(gameObject);
            // Update the winText to display "You Lose!"
            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!" + "      "+ "Press R to restart"; 


        }
    }
      
    }

