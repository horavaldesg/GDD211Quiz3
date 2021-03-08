using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : TellPlayer
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void UseItem()
    {
        base.UseItem();
        Debug.Log("Put things here");

    }
    private void OnMouseDown()
    {
        UseItem();
    }
}
