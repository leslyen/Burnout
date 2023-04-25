using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    private int points, done;
    public Text TextBox, EndDetails;
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        points = 100;
        done = 0;

    }
    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Task"))
        {
            points = points - 20;
            done = done + 1;
            Debug.Log("Lost 20% of energy");
            TextBox.text = points.ToString() + "%";
            other.tag = "Done";
        }
        if(other.gameObject.CompareTag("Fun"))
        {
            points = points + 20;
            Debug.Log("Gained 20% of energy");
            TextBox.text = points.ToString() + "%";
            Debug.Log(points);
            other.tag = "Done";
        }
        if(done >= 5)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;

            switch(currentSceneName){
                case "Home":
                    SceneManager.LoadScene("School");
                    break;
                case "School":
                    SceneManager.LoadScene("Office");
                    break;
                case "Office":
                    SceneManager.LoadScene("end");
                    break;
            }
        }
        if(points < 0){

            string currentSceneName = SceneManager.GetActiveScene().name;

            switch(currentSceneName){
                case "Home":
                    EndDetails.text = "You crumbled under pressure, did not finish your tasks, and got so overwhelemed that you moved back with your parents.";
                    SceneManager.LoadScene("end");
                    break;
                case "School":
                    EndDetails.text = "It was all too much, you dropped out of school now you have a LOT more time with YOURSELF to think about what you will do with your life";
                    SceneManager.LoadScene("end");
                    break;
                case "Office":
                    EndDetails.text = "You were fired on the spot, no notice or warning, that bartending job is sounding pretty nice right now";
                    SceneManager.LoadScene("end");
                    break;
            }
        }

    }

}