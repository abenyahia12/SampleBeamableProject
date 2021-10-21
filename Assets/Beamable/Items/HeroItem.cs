using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beamable.Common.Content;
using Beamable.Common.Inventory;
using System;
using Beamable;

[Agnostic]
[Serializable]
public class HeroLink : ContentLink<HeroItem> { }
[Agnostic]
[Serializable]
public class HeroRef : ContentRef<HeroItem> { }
[Agnostic]
[ContentType("Hero")]
public class HeroItem : ItemContent
{
    public string Name;
}
