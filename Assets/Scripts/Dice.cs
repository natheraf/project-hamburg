using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    [SerializeField] SceneController sceneController;
    [SerializeField] Sprite[] facesOfDice;
    private int _id;
    public int id {
        get { return _id; }
    }

    public void SetRandomFace() {
        _id = Random.Range(0, facesOfDice.Length);
        Debug.Log("Generated with id: " + _id);
        GetComponent<SpriteRenderer>().sprite = facesOfDice[_id];
    }

    // On mouse down, roll the dice
    public void OnMouseUp() {
        SetRandomFace();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
