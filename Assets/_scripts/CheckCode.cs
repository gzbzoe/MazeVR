using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckCode : MonoBehaviour {

    public GameObject Code_panel;
    public GameObject Hint_panel;
    public InputField codefield;
    public Button confirm_btn;
    public GameObject door_left;
    public GameObject door_right;
    public float timer;
	void Start () {
        //confirm_btn = Code_panel.transform.Find("Enter").GetComponent<Button>(); //按钮赋值
        //confirm_btn.onClick.AddListener(ConfirmButtonEvent); //委托 绑定事件
       // codefield.keyboardType = TouchScreenKeyboardType.NumberPad;
    }


    void Update() {
        if (Hint_panel.transform.GetChild(0).gameObject.activeInHierarchy)
        {
            if (timer++ > 50f)
            {
                Hint_panel.transform.GetChild(0).gameObject.SetActive(false);
                Hint_panel.SetActive(false);
                Code_panel.SetActive(false);
            }
        }
        if (Hint_panel.transform.GetChild(1).gameObject.activeInHierarchy)
        {
            if (timer++ > 50f)
            {
                Hint_panel.transform.GetChild(1).gameObject.SetActive(false);
                Hint_panel.SetActive(false);
                
            }
        }

    }
    public void ConfirmButtonEvent()
    {
        timer = 0;
       
        Hint_panel.SetActive(true);
        if (codefield.text == "1605117148")
        {
           
            Hint_panel.transform.GetChild(0).gameObject.SetActive(true);
            //Debug.Log(door_right);
            door_right.transform.Rotate(0, 90, 0);
            door_left.transform.Rotate(0, -90, 0);
            this.gameObject.SetActive(false);

        }
        else
        {
            Hint_panel.transform.GetChild(1).gameObject.SetActive(true);
           
        }
    }
}
