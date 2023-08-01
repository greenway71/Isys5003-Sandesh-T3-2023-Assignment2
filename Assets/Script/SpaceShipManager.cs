using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipManager : MonoBehaviour
{
    
    
    public GameObject Spaceship;
    public float value;
    public Vector3 sizeChange;

   public void MoveLeft()
{
    value = value - 0.1f;
    Spaceship.transform.position = new Vector3(value, 0, 0);
}

public void MoveRight()
{
    value = value + 0.1f;
    Spaceship.transform.position = new Vector3(value, 0, 0);
}

public void MoveUp()
{
    value = value + 0.1f;
    Spaceship.transform.position = new Vector3(0, value, 0);
}

public void MoveDown()
{
    value = value - 0.1f;
    Spaceship.transform.position = new Vector3(0, value, 0);
}

public void RotateLeft()
{
    Spaceship.transform.Rotate(20f, 0f, 0f);
}


public void RotateRight()
{
    Spaceship.transform.Rotate(0f, 20f, 0f);
}

public void Grow()
{
    Spaceship.transform.localScale = Spaceship.transform.localScale + sizeChange;
}


public void Shrink()
{
    Spaceship.transform.localScale = Spaceship.transform.localScale - sizeChange;
}

public void ResetSpaceship()
{
    Spaceship.transform.position = new Vector3(0,0,0);
    Spaceship.transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
    Spaceship.transform.localScale = new Vector3(1,1,1);
    

}



}
