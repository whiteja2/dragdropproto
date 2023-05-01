using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject draggingUnit;
    public GameObject currentContainer;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void PlaceObject()
    {
        if (draggingUnit != null && currentContainer != null)
        {
            Instantiate(draggingUnit.GetComponent<UnitDrag>().card.unitGame, currentContainer.transform);
            currentContainer.GetComponent<UnitContainer>().isFull = true;
        }
    }
}
