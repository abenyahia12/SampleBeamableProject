using Beamable;
using Beamable.Common.Content;
using Beamable.Common.Inventory;
using System;
[Agnostic]
[Serializable]
public class LockSmithLink : ContentLink<LockSmith> { }
[Agnostic]
[Serializable]
public class LockSmithRef : ContentRef<LockSmith> { }
[Agnostic]
[ContentType("LockSmith")]
public class LockSmith : ItemContent
{
    [System.Serializable]
    public struct Content { public int gold; public int gems; public int locksmith; };
    public Content content;
}


