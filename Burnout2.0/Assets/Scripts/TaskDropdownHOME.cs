using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskDropdownHOME : MonoBehaviour
{
    public GameObject TaskLight, TaskSpot;
    // Start is called before the first frame update
    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();

        List<string> Tasks = new List<string>();
        Tasks.Add("Meal prep");
        Tasks.Add("Do laundry");
        Tasks.Add("Make bed");
        Tasks.Add("Finish homework");
        Tasks.Add("Take a shower");

        foreach (var item in Tasks)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });

        }

        ListsItemsSelected(dropdown);

        dropdown.onValueChanged.AddListener(delegate { ListsItemsSelected(dropdown); });
    }

    void ListsItemsSelected(Dropdown dropdown)
    {
        int index = dropdown.value;
        Debug.Log(index);
        switch (index)
        {
            case 0:
                TaskLight.transform.position = new Vector3(-5.28f, 2.87f, 4.97f);
                TaskSpot.transform.position = new Vector3(-5.885f, 0.331f, 4.963f);
                break;
            case 1:
                TaskLight.transform.position = new Vector3(-6.06f, 3.85f, -1.23f);
                TaskSpot.transform.position = new Vector3(-5.033f, -0.083f, -0.646f);
                break;
            case 2:
                TaskLight.transform.position = new Vector3(5.65f, 4.1f, -3.49f);
                TaskSpot.transform.position = new Vector3(-0.363f, 0.116f, -0.00f);
                break;
            case 3:
                TaskLight.transform.position = new Vector3(-0.59f, 2.4f, -3.47f);
                TaskSpot.transform.position = new Vector3(-0.18f, 100.27f, -3.87f);
                break;
            case 4:
                TaskLight.transform.position = new Vector3(-5.24f, 6.97f, -6.19f);
                TaskSpot.transform.position = new Vector3(-4.934f, 1.487f, -5.188f);
                break;
            default:
                TaskLight.transform.position = new Vector3(16.62f, 2.95f, -3.53f);
                TaskSpot.transform.position = new Vector3(7.44f, 2.95f, 17.31f);
                break;
        }
    }

}