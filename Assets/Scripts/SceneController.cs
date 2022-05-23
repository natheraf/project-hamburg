using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public const float offsetX = -1.5f;
    public int numberOfActiveDice = 1;

    [SerializeField] Dice originalDice;
    [SerializeField] Sprite[] facesOfDice;

    public Sprite[] getFacesOfDice()
    {
        return facesOfDice;
    }

    private List<Dice> diceList = new List<Dice>();

    public void addNewDice() {
        Vector3 originalPosition = originalDice.transform.position;
        // Create a new dice
        Dice newDice = Instantiate(originalDice) as Dice;
        // Set the face of the dice
        int id = Random.Range(0, facesOfDice.Length);
        newDice.SetFace(id , facesOfDice[id]);
        // Add the dice to the list
        diceList.Add(newDice);
        // Set the position of the dice
        newDice.transform.position = new Vector3(originalPosition.x + offsetX * numberOfActiveDice++, originalPosition.y, originalPosition.z);
    }

    // Start is called before the first frame update
    void Start()
    {
        int id = Random.Range(0, facesOfDice.Length);
        originalDice.SetFace(id, facesOfDice[id]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
