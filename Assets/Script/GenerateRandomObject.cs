using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRandomObject : MonoBehaviour
{
    public GameObject[] listObject;
    public Material[] listMaterial;

    public GameObject current;
    public Transform generatePosition;

    public SaveObject save;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void generateObject()
    {

        if (current)
        {
            Destroy(current);
        }



        int randomObject = Random.Range(0, listObject.Length);
        int randomMaterial = Random.Range(0, listMaterial.Length);

        current = Instantiate(listObject[randomObject], generatePosition.transform.position, Quaternion.identity);
        current.GetComponent<MeshRenderer>().material = listMaterial[randomMaterial];
        current.SetActive(true);

        save._object = current;
    }

    public void saveObject()
    {
        save.saveAsPrefab(current);
    }
}
