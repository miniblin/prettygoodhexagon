using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    float duration = 5; // This will be your time in seconds.
    float smoothness = 0.02f; // This will determine the smoothness of the lerp. Smaller values are smoother. Really it's the time between updates.
  
	Color[] colours = {Color.blue,Color.cyan, Color.red,Color.green, Color.gray, Color.magenta, Color.yellow, Color.white};
    void Start()
    {
        StartCoroutine("LerpColor");
    }

    IEnumerator LerpColor()
    {
        float progress = 0; //This float will serve as the 3rd parameter of the lerp function.
        float increment = smoothness / duration; //The amount of change to apply.
		Color colorFrom = Color.black;
		Color colorTo = RandomColorFromList(colorFrom);
        while (enabled)
        {
			if(progress>=1){
				colorFrom = colorTo;
				colorTo= RandomColorFromList(colorFrom);
				progress=0;
			}
            Camera.main.backgroundColor = Color.Lerp(colorFrom,colorTo, progress);
            progress += increment;
            yield return new WaitForSeconds(smoothness);
        }
    }

	Color RandomColorFromList(Color current){
		List<Color> OtherColors = new List<Color>(colours);
		OtherColors.Remove(current);
		int index = Random.Range(0, OtherColors.Count);
		return OtherColors[index];
	}
}