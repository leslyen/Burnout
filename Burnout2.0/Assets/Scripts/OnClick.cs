using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{ 
    public Sprite task1, task2, task3, task4, task5, fun1, fun2, fun3, fun4, fun5;
    public GameObject popup;
    public Image comics;
    
    void Start()
    { 
        popup.SetActive(false);
    }

    void Update(){
    }

    void OnTriggerEnter(Collider other)
    {
        string action = other.gameObject.name;
        switch(action){
            case "table3 (4)":
                openpopup(task1);
                break;
            case "chair1 (18)":
                openpopup(task2);
                break;
            case "chair1 (40)":
                openpopup(task3);
                break;
            case "board":
                openpopup(task4);
                break;
            case "table3 (2)":
                openpopup(task5);
                break;
            case "rack1 (4)":
                openpopup(fun1);
                break;
            case "table2 (4)":
                openpopup(fun2);
                break;
            case "wall4":
                openpopup(fun3);
                break;
            case "rack (1)":
                openpopup(fun4);
                break;
            case "chair1 (34)":
                openpopup(fun5);
                break;
        }
    }
    public void openpopup(Sprite image){
        comics.sprite = image;
        popup.SetActive(true);
    }

    public void closepopup(){
        popup.SetActive(false);
    }
}