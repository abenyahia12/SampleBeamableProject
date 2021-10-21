using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beamable.Common.Content;
using Beamable.Common.Inventory;
using System;
using Beamable;
[Agnostic]
[Serializable]
public class ChestLink : ContentLink<ChestItemContent> { }
[Agnostic]
[Serializable]
public class ChestRef : ContentRef<ChestItemContent> { }
[Agnostic]
[ContentType("Chest")]
public class ChestItemContent : ItemContent
{
    public string Name;

}
