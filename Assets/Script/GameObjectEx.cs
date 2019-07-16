﻿using UnityEngine;

namespace Assets.Script
{
    public static class GameObjectEx
    {
        public static void DrawCircle(this GameObject container, float radius, float lineWidth, Color color)
        {
            var segments = 360;
            var line = container.AddComponent<LineRenderer>();
            line.useWorldSpace = false;
            line.startWidth = lineWidth;
            line.endWidth = lineWidth;
            line.material = new Material(Shader.Find("Sprites/Default"))
            {
                color = color 
            };
            line.positionCount = segments + 1;

            var pointCount = segments + 1; 
            var points = new Vector3[pointCount];

            for (int i = 0; i < pointCount; i++)
            {
                var rad = Mathf.Deg2Rad * (i * 360f / segments);
                points[i] = new Vector3(Mathf.Sin(rad) * radius, 0, Mathf.Cos(rad) * radius);
            }

            line.SetPositions(points);
        }
    }
}