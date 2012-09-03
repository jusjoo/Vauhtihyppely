using UnityEngine;
using System.Collections;

public class PixelArtImporter : MonoBehaviour {
	
	public Vector2 sizeInPixels;
	public string imageURL;
	
	
	private float cubeSize = 0.1f;
	
	// Use this for initialization
	void Start () {
		
		WWW www = new WWW(imageURL);
		while (!www.isDone) {}
		Texture2D image = www.texture;
		
		for (int x=0; x < sizeInPixels.x; x++) {
			
			for (int y=0; y < sizeInPixels.y; y++)  {
				
				Color color = image.GetPixel(x,y);
				
				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				
				cube.transform.position = new Vector3(x*cubeSize, y*cubeSize, 0);
				
			}
			
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
