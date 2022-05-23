using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    [SerializeField] SceneController sceneController;

    private Sprite[] facesOfDice;
    private int _id;
    public int id {
        get { return _id; }
    }

    public void SetFace(int id, Sprite image) {
        Debug.Log("Generated with id: " + id);
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    // On mouse down, roll the dice
    public void OnMouseUp() {
        SetFace(Random.Range(0, facesOfDice.Length), facesOfDice[id]);
    }

    // Start is called before the first frame update
    void Start()
    {
        facesOfDice = sceneController.getFacesOfDice();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
