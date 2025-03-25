using UnityEngine;

public class EncapsulationStuff
{
    // is an open int
    public int openthing;
    // can only be acsessed within the class
    private int thing;
    // seen as private
    int thingUnspecified;
    // is able to be acsessed from the editor but not other classes
    [SerializeField]
    private int unityThing;
    //is able to be called from other classes
    public int encapsulatedThing { get; set; }

    // a get set
    private int encapsulatedThingBig;
    public int EncapsulatedThingBig
    {
        get
        {
            return this.encapsulatedThingBig;
        }
        set
        {
            this.encapsulatedThingBig = value;
        }
    }

    // this adds a restriction to the private in where the int value has to be less than 100
    private int encapsulatedThingBut;
    public int EncapsulatedThingBut
    {
        get
        {
            return this.encapsulatedThingBut;
        }
        set
        {
           
            if (value < 100)
                this.encapsulatedThingBut = value;
        }
    }
}

public class MoreEncapsulation
{
    // reference to the class above
    EncapsulationStuff encapsulationStuff;
    public void SetEncapsulatedThing()
    {
        // property can be set/got like a regular int
        encapsulationStuff.EncapsulatedThingBig = 1000;
        int value = encapsulationStuff.EncapsulatedThingBig;

        // this wouldn't assign, because the value exceeds 99
        encapsulationStuff.EncapsulatedThingBut = value;
    }
}
