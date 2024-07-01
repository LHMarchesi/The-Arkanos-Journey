using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMap : MonoBehaviour
{
    public float[] MapLevel1 = new float[]
{
        9.278f, 9.680f, 10.269f, 10.858f, 11.447f, 12.036f, 12.625f, 13.214f, 13.803f,
        14.392f, 14.981f, 15.570f, 16.159f, 16.748f, 17.337f, 17.926f, 18.515f, 19.104f,
        19.693f, 20.282f, 20.871f, 21.460f, 22.049f, 22.638f, 23.227f, 23.816f, 24.405f,
        24.994f, 25.583f, 26.172f, 36.761f, 27.350f, 27.939f, 28.528f, 29.117f, 29.706f,
        30.295f, 30.884f, 31.473f, 32.062f, 32.651f, 33.240f, 33.829f, 34.418f, 35.007f,
        35.596f, 36.185f, 36.774f, 37.363f, 37.952f, 38.541f, 39.130f, 39.719f, 40.308f,
        40.897f, 41.486f, 42.075f, 42.664f, 43.253f, 43.842f, 44.431f, 45.020f, 45.609f,
        46.198f, 46.787f, 47.376f, 47.965f, 48.554f, 49.143f, 49.732f, 50.321f, 50.910f,
        51.499f, 52.088f, 52.677f, 53.266f, 53.855f, 54.444f, 55.033f, 55.622f, 56.211f,
        56.800f, 57.389f, 57.978f, 58.567f, 59.156f, 59.745f, 60.334f, 60.923f, 61.512f,
        62.101f, 62.690f, 63.279f, 63.868f, 64.457f, 65.046f, 65.635f, 66.224f, 66.813f,
        67.402f, 67.991f, 68.580f, 69.169f, 69.758f, 70.347f, 70.936f, 71.525f, 72.114f,
        72.703f, 73.292f, 73.110f
};


    public float[] MapLevel2 = new float[]
   {
        15.99f, 16.63f, 17.00f, 17.97f, 18.16f, 19.07f, 19.40f, 19.80f, 20.03f, 20.21f,
      20.51f, 21.05f, 22.00f, 22.90f, 24.10f, 24.83f, 25.00f, 26.00f, 27.69f, 28.80f,
    29.49f, 30.00f, 30.94f, 31.95f, 32.75f, 32.95f, 33.60f, 34.64f, 35.60f, 36.00f,
    37.00f, 37.95f, 39.00f, 39.96f, 48.00f, 49.00f, 49.45f, 50.00f, 51.00f, 52.00f,
    52.81f, 53.50f, 54.00f, 55.00f, 56.00f, 57.00f, 58.00f, 58.34f, 59.00f, 60.00f,
    61.00f, 61.50f, 62.00f, 62.50f, 63.00f, 64.17f, 64.37f, 64.69f, 65.00f, 65.40f,
    65.68f, 66.00f, 66.70f, 68.00f, 69.00f, 69.60f, 70.20f, 70.69f, 71.37f, 71.68f,
    72.00f, 72.85f, 73.30f, 74.00f, 75.00f, 75.37f, 76.02f, 77.00f, 78.00f, 78.33f,
    78.66f, 79.00f
   };
    
    public float[] MapLevel3 = new float[]
   {

        0.3138289f, 2.066143f, 2.72479f, 4.556584f, 5.146188f, 5.462516f, 5.777485f, 6.091644f, 6.4915f, 6.659496f,
    7.102573f, 7.398131f, 7.735753f, 8.052613f, 8.347625f, 8.663639f, 8.979581f, 9.14952f, 9.6165f, 9.910502f,
    10.25055f, 10.56849f, 10.84464f, 11.15861f, 11.4976f, 11.68662f, 12.10872f, 12.42479f, 12.74086f, 13.06094f,
    13.356f, 13.71408f, 14.0299f, 14.21985f, 14.64038f, 14.9557f, 15.29218f, 15.58816f, 15.90527f, 16.20156f,
    16.54052f, 16.70869f, 17.17352f, 17.49202f, 17.7886f, 18.12681f, 18.44353f, 18.73855f, 19.07662f, 19.26759f,
    19.69267f, 20.00728f, 20.38751f, 20.66093f, 20.99858f, 21.27421f, 21.59557f, 21.7646f, 22.22974f, 22.52378f,
    22.86365f, 23.20059f, 23.51724f, 23.81251f, 24.12798f, 24.31918f, 24.70065f, 24.97448f, 25.3745f, 25.50131f,
    26.99851f, 27.19161f, 27.42348f, 27.67668f, 27.97155f, 28.0983f, 29.49012f, 29.70223f, 29.93462f, 30.2296f,
    30.5045f, 30.6525f, 32.06352f, 32.27553f, 32.55052f, 33.05553f, 33.60258f, 34.27532f, 34.46659f, 35.47729f,
    35.66734f, 37.03852f, 37.2075f, 37.48151f, 37.75731f, 38.054f, 38.225f, 39.57036f, 39.76064f, 40.11864f,
    40.56298f, 40.73161f, 40.87965f, 42.33064f, 42.52164f, 42.81747f, 43.13483f, 43.74635f, 44.38273f, 44.57377f,
    45.60701f, 45.88307f, 46.20091f, 46.51889f, 46.8776f, 47.04774f, 47.48959f, 47.78648f, 48.12752f, 48.44503f,
    48.74262f, 49.03854f, 49.375f, 49.56549f, 50.00954f, 50.3046f, 50.64352f, 50.96069f, 51.27813f, 51.57362f,
    51.91283f, 52.08273f, 52.54662f, 52.82159f, 53.18147f, 53.49747f, 53.79159f, 54.10817f, 54.44465f, 54.61575f,
    55.01764f, 55.37828f, 55.71388f, 56.05161f, 56.34761f, 56.64247f, 56.97959f, 57.14936f, 57.61462f, 57.89069f,
    58.22873f, 58.52464f, 58.88467f, 59.13731f, 59.496f, 59.68735f, 60.11087f, 60.42805f, 60.788f, 61.0639f,
    61.38071f, 61.69697f, 62.03529f, 62.205f, 62.6273f, 62.94785f, 63.28655f, 63.60231f, 63.91965f, 64.21661f,
    64.57454f, 64.72349f, 65.14532f, 65.43964f, 65.77802f, 65.96982f, 67.2978f, 67.5293f, 67.74129f, 67.99458f,
    68.37357f, 68.58425f, 69.91334f, 70.14452f, 70.41975f, 70.82049f, 71.03249f, 71.15952f, 72.42668f, 72.68059f,
    72.95651f, 73.44109f, 74.03297f, 74.68464f, 74.87447f, 75.92866f, 76.22385f, 77.48713f, 77.65617f, 77.93023f,
    78.2273f, 78.50204f, 78.65004f, 80.06223f, 80.27261f, 80.56635f, 80.98849f, 81.15642f, 81.30431f, 82.46461f,
    82.69656f, 82.88601f, 83.22459f, 83.583f, 84.17577f, 84.80874f, 84.97865f

   };
    
    public float[] MapLevel4 = new float[]
   {

   };




}
