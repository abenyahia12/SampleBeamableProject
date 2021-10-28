using System;
using Beamable.Common.Content;
using Beamable.Common.Inventory;

namespace Beamable.Server.BeamableTest.Content
{
    [Serializable]
    [Agnostic]
    [ContentType("Hero")]
    public class HeroItem : ItemContent
    {
        public string heroName;
    }
}
