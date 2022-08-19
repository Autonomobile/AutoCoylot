using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Env : MonoBehaviour {
    public static Env Instance;

    [Header("Virtual Env Settings")]
    public bool generateWalls = true;
    public bool randomizeLights = true;
    public bool generateChairs = false;

    [Header("Light Settings")]
    public Color lowLerpColor = Color.yellow;
    public Color highLerpColor = Color.white;
    public float maxLightAngle = 30.0f;
    public float lowLerpIntensity = 0.5f;
    public float highLerpIntensity = 1.5f;

    public float materialColorProbability = 0.5f;
    public float laneAppearProbability = 0.7f;

    [Header("Synthetic Labels Generation Parameters")]
    public float RandomDist = 0.2f;
    public float timeLookahead = 0.5f;
    public float maxAngle = 25.0f;
    public float minSpeed = 1.0f;
    public float maxSpeed = 2.0f;
    public float speed = 1.0f;

    [Header("Zone Parameters")]
    public float pointsEvery = 0.25f;
    public float distAverage = 1f;
    public float distBrakeLookahead = 1.0f;
    public float turnTh = 15f;
    public bool doDrawTurns = true;
    public float[] lookupZone = { 0.4f, 0.3f, 0.2f };

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    public void Init() {
        Debug.Log("Env Init");
    }
}
