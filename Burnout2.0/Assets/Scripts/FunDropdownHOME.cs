using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FunDropdownHOME : MonoBehaviour
{

    public GameObject FunLight, FunSpot;
    // Start is called before the first frame update
    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();


        List<string> Fun = new List<string>();
        Fun.Add("Take a nap");
        Fun.Add("Watch TV");
        Fun.Add("Eat a snack");
        Fun.Add("Play video games");
        Fun.Add("Play drums");


        foreach (var item in Fun)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item});

        }

        ListsItemsSelected(dropdown);

        dropdown.onValueChanged.AddListener(delegate {ListsItemsSelected(dropdown); });
    }

    void ListsItemsSelected(Dropdown dropdown)
    {
        int index = dropdown.value;
        Debug.Log(index);
        switch (index)
        {
            case 0:
                FunLight.transform.position = new Vector3(-5.28f, 2.87f, 4.97f);
                FunSpot.transform.position = new Vector3(7.44f, 2.95f, 17.31f);
                break;
            case 1:
                FunLight.transform.position = new Vector3(3.85f, 2.4f, 6.29f);
                FunSpot.transform.position = new Vector3(2.479f, 0.880f, 7.934f);
                break;
            case 2:
                FunLight.transform. position = new Vector3(-3.56f, 2.4f, 6.1f);
                FunSpot.transform. position = new Vector3(-3.62f, 0.350f, 5.99f);
                break;
            case 3:
                FunLight.transform. position = new Vector3(-0.67f, 2.4f, -5.77f);
                FunSpot.transform. position = new Vector3(-0.734f, 0.335f, 5.865f);
                break;
            case 4:
                FunLight.transform. position = new Vector3(2.66f, 2.56f, -0.35f);
                FunSpot.transform. position = new Vector3(2.32f, -0.401f, -1.11f);
                break;
            default:
                FunLight.transform. position = new Vector3(16.62f, 2.95f, -3.53f);
                FunSpot.transform. position = new Vector3(7.44f, 2.95f, 17.31f);
                break;
        }
    }
    
}