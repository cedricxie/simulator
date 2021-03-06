/**
 * Copyright (c) 2018 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */


﻿using UnityEngine;

public class TrafficSpawnArea : FilterShape
{
    void Start()
    {
        var trafSpawner = FindObjectOfType<TrafSpawner>();
        if (trafSpawner != null)
        {
            trafSpawner.trafficSpawnArea = this;
        }
    }

    protected override void OnDrawGizmosSelected()
    {
        base.OnDrawGizmosSelected();
    }
}
