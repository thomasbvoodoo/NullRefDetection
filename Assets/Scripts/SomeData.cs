﻿using UnityEngine;

[CreateAssetMenu(fileName = "some_data", menuName = "Data/Some")]
public class SomeData : ScriptableObject
{
    [SerializeField] private GameObject somePrefab = null;
}