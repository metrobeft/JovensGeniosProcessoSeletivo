using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    InputField input;
    InputField.SubmitEvent se;
    public Text output;
    
  private void Algoritimo (int quantidade)
{
	int i;
	for ( i = 0; i <= quantidade; i++ ) 
	{
		if (i%3==0&&i%5==0)
		{
		string currentText = output.text;
        string newText = currentText + "\n Jovens Genios" ;
        output.text = newText;
        input.text = "";
        input.ActivateInputField();
			
		} else if(i%5==0)
		{ 	  	  
		string currentText = output.text;
        string newText = currentText + "\n Genios" ;
        output.text = newText;
        input.text = "";
        input.ActivateInputField();
		} else if(i%3==0)
		{
   	  	string currentText = output.text;
        string newText = currentText + "\n Jovens" ;
        output.text = newText;
        input.text = "";
        input.ActivateInputField();
		}else{
        string myString = i.ToString();
        string currentText = output.text;
        string newText = currentText + "\n" + " " + myString;
        output.text = newText;
        input.text = "";
        input.ActivateInputField();
        }
	}
}

public void RestartConfirm()
    {
        string newText =  "Contador: \n";
        output.text = newText;
        input.text = "";
        input.ActivateInputField();
    }

    void Start()
    {
        input = gameObject.GetComponent<InputField>();    
        se = new InputField.SubmitEvent();
        se.AddListener(SubmitInput);
        input.onEndEdit = se;
    }

    private void SubmitInput(string arg0)
    {
        int x = int.Parse(arg0);
        Algoritimo(x);
        
    }

}
