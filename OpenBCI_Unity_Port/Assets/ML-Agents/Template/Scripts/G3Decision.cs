using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G3Decision : MonoBehaviour, Decision
{

    public float[] Decide(List<float> state, List<Camera> observation, float reward, bool done, float[] memory)
    {
		float[] action = new float[5];
		for (int i = 0; i < 5; i++) {
			action[i] = Random.Range(-1f, 1f);
		}
		return action;

    }

    public float[] MakeMemory(List<float> state, List<Camera> observation, float reward, bool done, float[] memory)
    {
        return new float[0];
		
    }
}
