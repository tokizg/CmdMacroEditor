using UnityEngine;

public interface IParser
{
    IExecutableSheet Parse(TextAsset Source);
}