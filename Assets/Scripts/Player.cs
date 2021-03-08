using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    private int Intake;
    private int Karma;
    private TextMeshProUGUI Stats;
    public TextMeshProUGUI playerMessage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
        //two lines below find a script called TellPlayer and call functions in it
        FindObjectOfType<TellPlayer>().WriteMessage("");
        FindObjectOfType<TellPlayer>().UpdateStats(0, 0);

    }
}
