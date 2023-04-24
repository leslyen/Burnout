using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskPoints : MonoBehaviour
{
    public GameObject Task1, Task2, Task3, Task4, Task5, Player;
    private int points;
    // Start is called before the first frame update
    void Start()
    {
        points = 100;
        var dropdown = transform.GetComponent<Dropdown>();

    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Task"))
        {
            points = points - 20;
            Debug.Log("LOst 20% of energy");
            Debug.Log(points);
        }
    }
}
