using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreDestroy : MonoBehaviour
{
    public Material mat1;
    public Material matInstance;
    public float alpha = 1;
    public float alphaDecreaseSpeed = 1;
    public bool shouldContinue = false;
    public GameObject Ore;
    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();
      
        matInstance = new Material(mat1);
        meshRenderer.materials[0] = matInstance;
        matInstance = meshRenderer.materials[0];
    }

    // Update is called once per frame
    void Update()
    {

        if (shouldContinue)
        {
            //Debug.Log("ORE CHANGE");
            alpha -= alphaDecreaseSpeed * Time.deltaTime;
            ChangeAlpha(matInstance, alpha);


        }

        if (alpha <= 0)
        {
            shouldContinue = false;
            Destroy(Ore);

        }
    }
    void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);

        //This replaces the old color with the new more transparent color every frame
    }
   


}
