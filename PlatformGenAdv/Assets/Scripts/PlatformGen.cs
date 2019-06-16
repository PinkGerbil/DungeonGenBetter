using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGen : MonoBehaviour {

    public bool isTraversed;
    public GameObject roomBase;
    public GameObject previousRoom;
    public GameObject parentRooms;

    // Use this for initialization
    void Start () {
        this.gameObject.GetComponent<RoomData>(); 
	}
	
	// Update is called once per frame
	void Update () {
        if (!isTraversed)
        {
            RoomSpawnWKeys();
        }
	}

    public void RoomSpawnWKeys()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            spawnRoomUp();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            spawnRoomLeft();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            spawnRoomRight();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            spawnRoomDown();
        }
    }

    public void spawnRoomUp()
    {
        previousRoom = this.gameObject;

        //doesnt move
        int xPos = previousRoom.GetComponent<RoomData>().getXPos() + 0;
        //up on z so +1
        int zPos = previousRoom.GetComponent<RoomData>().getZPos() + 1;

        checkExistingRooms(xPos, zPos);

        GameObject instRoom;
        instRoom = Instantiate(roomBase);
        instRoom.name = ("room_" + xPos + "_0_" + zPos);
        instRoom.transform.parent = parentRooms.transform;
        instRoom.GetComponent<RoomData>().setXPos(xPos);
        instRoom.GetComponent<RoomData>().setZPos(zPos);

        instRoom.transform.position = new Vector3(xPos * 10, 0, zPos * 10);
        isTraversed = true;
    }

    public void spawnRoomLeft()
    {
        previousRoom = this.gameObject;

        //goes left one so - 1
        int xPos = previousRoom.GetComponent<RoomData>().getXPos() - 1;
        //doesnt move on z so 0
        int zPos = previousRoom.GetComponent<RoomData>().getZPos() + 0;

        checkExistingRooms(xPos, zPos);

        GameObject instRoom;
        instRoom = Instantiate(roomBase);
        instRoom.name = ("room_" + xPos + "_0_" + zPos);
        instRoom.transform.parent = parentRooms.transform;
        instRoom.GetComponent<RoomData>().setXPos(xPos);
        instRoom.GetComponent<RoomData>().setZPos(zPos);

        instRoom.transform.position = new Vector3(xPos * 10, 0, zPos * 10);
        isTraversed = true;
    }

    public void spawnRoomRight()
    {
        previousRoom = this.gameObject;

        //goes right one so + 1
        int xPos = previousRoom.GetComponent<RoomData>().getXPos() + 1;
        //doesnt move on z so 0
        int zPos = previousRoom.GetComponent<RoomData>().getZPos() + 0;

        checkExistingRooms(xPos, zPos);

        GameObject instRoom;
        instRoom = Instantiate(roomBase);
        instRoom.name = ("room_" + xPos + "_0_" + zPos);
        instRoom.transform.parent = parentRooms.transform;
        instRoom.GetComponent<RoomData>().setXPos(xPos);
        instRoom.GetComponent<RoomData>().setZPos(zPos);

        instRoom.transform.position = new Vector3(xPos * 10, 0, zPos * 10);
        isTraversed = true;
    }

    public void spawnRoomDown()
    {
        previousRoom = this.gameObject;

        //doesnt move
        int xPos = previousRoom.GetComponent<RoomData>().getXPos() + 0;
        //down on z so -1
        int zPos = previousRoom.GetComponent<RoomData>().getZPos() - 1;

        GameObject instRoom;
        instRoom = Instantiate(roomBase);
        instRoom.name = ("room_" + xPos + "_0_" + zPos);
        instRoom.transform.parent = parentRooms.transform;
        instRoom.GetComponent<RoomData>().setXPos(xPos);
        instRoom.GetComponent<RoomData>().setZPos(zPos);


        checkExistingRooms(xPos, zPos);

        print(parentRooms.GetComponentInChildren<RoomData>().getXPos());

        instRoom.transform.position = new Vector3(xPos * 10, 0, zPos * 10);
        isTraversed = true;
    }

    public void checkExistingRooms(int x, int z)
    {

        if (x == parentRooms.GetComponentInChildren<RoomData>().getXPos() && z == parentRooms.GetComponentInChildren<RoomData>().getZPos())
        {
            print("overlap");
        }
    }
}