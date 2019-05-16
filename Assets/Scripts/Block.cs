﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
    public Vector3Int Position { get; private set; }

    void Start() { }

    void Update() { }

    public static Block Create(Vector3Int position, GameObject prefab) {
        Vector3 pos = MapManager.GetWorldPos(position);
        GameObject go = Instantiate(prefab, pos, Quaternion.identity);
        Block block = go.AddComponent<Block>() as Block;
        return block;
    }

}
