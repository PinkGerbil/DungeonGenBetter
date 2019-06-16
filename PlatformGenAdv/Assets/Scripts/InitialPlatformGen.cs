using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialPlatformGen : MonoBehaviour {

    public GameObject roomStart;
    public bool traversed; 

    /// <summary>
    /// Update is called once per frame
    /// </summary>
	void Update () {
        if (!traversed)
        {
            GameObject instRoom;
            instRoom = Instantiate(roomStart);
            instRoom.GetComponent<RoomData>().setXPos(0);
            instRoom.GetComponent<RoomData>().setZPos(0);
            int xPos = instRoom.GetComponent<RoomData>().getXPos();
            int zPos = instRoom.GetComponent<RoomData>().getZPos();

            instRoom.AddComponent<PlatformGen>();
            //update later to prefab rooms
            instRoom.GetComponent<PlatformGen>().roomBase = roomStart;

            instRoom.transform.position = new Vector3(xPos, 0, zPos);

            traversed = true;
        }
    }
}
