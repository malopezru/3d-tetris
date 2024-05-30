using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Cell
{
    readonly Block parentBlock;
    Vector3Int position;
    GameObject gameObject;

    public GameObject GameObject { get => gameObject; set => gameObject = value; }
    public Vector3Int Position{ get => position; set { position = value; SetGameObjectPosition(); } }
    public Vector3Int AbsolutePosition { get => parentBlock.Position + position; }

    public void SetGameObjectPosition()
    {
        gameObject.transform.position = new Vector3(
            parentBlock.Position.x + position.x,
            parentBlock.Position.y + position.y,
            parentBlock.Position.z + position.z
        );
    }

    public Cell(Block parentBlock, Vector3Int position, Texture2D materialCell)
    {
        this.parentBlock = parentBlock;
        gameObject = Object.Instantiate(Resources.Load("Cell", typeof(GameObject))) as GameObject;
        gameObject.GetComponent<Renderer>().material.SetTexture("_MainTex", materialCell);
        Position = position;
    }
}
