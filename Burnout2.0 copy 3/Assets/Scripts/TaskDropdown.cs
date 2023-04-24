using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskDropdown : MonoBehaviour
{

    public Text TextBox;
    // Start is called before the first frame update
    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();

        List<string> Tasks = new List<string>();
        Tasks.Add("Do Homework");
        Tasks.Add("Take your math test");
        Tasks.Add("Go to lecture");
        Tasks.Add("Class presentation");
        Tasks.Add("Extra credit");
        Tasks.Add("Work on group project");
        Tasks.Add("Talk to advisor");

        foreach (var item in Tasks)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item});

        }

        ListsItemsSelected(dropdown);

        dropdown.onValueChanged.AddListener(delegate {ListsItemsSelected(dropdown); });
    }

    void ListsItemsSelected(Dropdown dropdown)
    {
        int index = dropdown.value;

        TextBox.text = dropdown.options[index].text;
    }
    
}