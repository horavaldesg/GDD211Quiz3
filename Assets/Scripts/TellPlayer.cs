using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TellPlayer : MonoBehaviour
{

    [SerializeField] private int Intake;
    [SerializeField] private int Karma;
    [SerializeField] private TextMeshProUGUI Stats;
    public TextMeshProUGUI playerMessage;

    public string Name;
    public int Calories;
    public int Karmas;
    public bool Alive;
    public string Message;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void WriteMessage(string words)
    {
        playerMessage.text = words;
    }

    public void UpdateStats(int cals, int karm)
    {
        Intake += cals;
        Karma += karm;
        Stats.SetText("Your caloric intake is " + Intake + " and your karma is " + Karma);
        if ((Intake < -30) || (Karma < -20))
        {
            Stats.text = "You Died!";
        }
    }
    public virtual void UseItem()

    {
        //Debug.Log(Calories);
        Debug.Log(Intake);
        //two lines below find a script called TellPlayer and call functions in it
        FindObjectOfType<TellPlayer>().WriteMessage(Message);
        FindObjectOfType<TellPlayer>().UpdateStats(Intake, Karma);

    }
}
