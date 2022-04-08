using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BendingAbility : MonoBehaviour
{
    [Tooltip("What type of bender will this character be?")]
    public enum BendType{ Earth, Water, Fire };
    public BendType bendType;
    public List<Bendable> bendable;
    public int currentBendable = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ///check to see if items are withing bend radius, if items are within radius can my class bend it? if yes than lift items and hover around player
        ///
        switch (bendType)
        {
            case BendType.Earth:
                if (Input.GetKey(KeyCode.F))
                {
                    Bend();
                    break;
                }
        }
    }
    void Bend()
    {
        //lifts nearby objects in the air if they are the element they can bend and hover near the player
    }
}
