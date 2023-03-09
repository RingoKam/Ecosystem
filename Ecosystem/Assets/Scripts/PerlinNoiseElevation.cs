using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


/// <summary>
/// Use the noise values as the elevations of a landscape
/// </summary>
public class PerlinNoiseElevation : MonoBehaviour
{
    public int numberOfPixels = 50;
    public float elevationMax = 10;
    public float elevationMin = 0;
    public float PerlinNoiseStep = 0.01f;

    private float side;

    // Start is called before the first frame update
    void Start()
    {
        side = Mathf.Sqrt(numberOfPixels);
        var offset = side / 2;
        var index = 0;
        var maxColPerRow = Mathf.Round(side);
        var elevations = GenerateRandomElevations();

        for (int row = 0; row < maxColPerRow; row++)
        {
            for (int col = 0; col < maxColPerRow; col++)
            {
                //var rand = elevations[index];
                var rand = Mathf.PerlinNoise(col * PerlinNoiseStep, row * PerlinNoiseStep);

                var height = Remap(rand, 0, 1, elevationMin, elevationMax);

                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.name = $"{col},{row}";
                cube.transform.localScale = new Vector3(1, height, 1);
                cube.transform.position = new Vector3(-offset + col, 0, -offset + row);

                var mat = cube.GetComponent<Renderer>().material;
                mat.color = Color.Lerp(Color.green, Color.red, rand);

                index++;
            }
        };
    }

    float[] GenerateRandomElevations()
    {
        var elevationCollection = new float[numberOfPixels];

        for (int i = 0; i < numberOfPixels; i++)    
        {
            float x = i * PerlinNoiseStep;
            var rand = Mathf.PerlinNoise(x, 0);
            //elevationCollection[i] = Remap(rand, 0, 1, elevationMin, elevationMax);
            elevationCollection[i] = rand;
        }

        return elevationCollection;
    }

    float Remap(float value, float from1, float to1, float from2, float to2)
    {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;

    }
}
