using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SaveObject : MonoBehaviour
{
    public GameObject _object;

    public void saveAsPrefab(GameObject objectToSave)
    {
        string path = AssetDatabase.GenerateUniqueAssetPath("Assets/Prefabs/" + objectToSave.name + ".prefab");

        PrefabUtility.SaveAsPrefabAssetAndConnect(objectToSave, path, InteractionMode.UserAction);
    }

}
