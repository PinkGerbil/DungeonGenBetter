using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomData : MonoBehaviour {

    public int xPos;
    public int zPos;

    public void setXPos(int x)
    {
        xPos = x;
    }

    public void setZPos(int z)
    {
        zPos = z;
    }

    public int getXPos()
    {
        return xPos;
    }

    public int getZPos()
    {
        return zPos;
    }
}
