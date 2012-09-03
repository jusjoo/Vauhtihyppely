using UnityEngine;
using System.Collections;

public class PixelArtImporter : MonoBehaviour {
	
	public Vector2 sizeInPixels;
	public Texture2D image;
	
	
	private float cubeSize = 0.1f;
	
	// Use this for initialization
	void Start () {
		
		for (int x=0; x < sizeInPixels.x; x++) {
			
			for (int y=0; y < sizeInPixels.y; y++)  {
				
				Color color = image.GetPixel(x, y);
                Debug.Log(color);
				
				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Sphere);
               
                cube.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);
                
                cube.transform.parent = this.transform;

                cube.renderer.material.color = color;

				cube.transform.position = new Vector3(this.transform.position.x + x*cubeSize, this.transform.position.y + y*cubeSize, 0);
                
				
			}
			
		}
		
	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
