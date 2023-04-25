using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnClickHOME : MonoBehaviour
{
    public Sprite task1, task2, task3, task4, task5, fun1, fun2, fun3, fun4, fun5;
    public GameObject popup;
    public Image comics;

    void Start()
    {
        popup.SetActive(false);
    }

    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        string action = other.gameObject.name;
        switch (action)
        {
            case "cooker":
                openpopup(task1);
                break;
            case "door_003":
                openpopup(task2);
                break;
            case "duvet":
                openpopup(task3);
                break;
            case "Laptop":
                openpopup(task4);
                break;
            case "Bath":
                openpopup(task5);
                break;
            case "Armchair":
                openpopup(fun1);
                break;
            case "Tv_unit":
                openpopup(fun2);
                break;
            case "wall4":
                openpopup(fun3);
                break;
            case "Arcade":
                openpopup(fun4);
                break;
            case "sofa2":
                openpopup(fun5);
                break;
        }
    }
    public void openpopup(Sprite image)
    {
        comics.sprite = image;
        popup.SetActive(true);
    }

    public void closepopup()
    {
        popup.SetActive(false);
    }
}