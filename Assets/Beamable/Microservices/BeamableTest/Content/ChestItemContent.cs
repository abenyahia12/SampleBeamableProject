using System;
using Beamable.Common.Content;
using Beamable.Common.Inventory;

namespace Beamable.Server.BeamableTest.Content
{
    [Serializable]
    [Agnostic]
    [ContentType("Chest")]
    public class ChestItemContent : ItemContent
    {
        public string chestName;
    }
}
