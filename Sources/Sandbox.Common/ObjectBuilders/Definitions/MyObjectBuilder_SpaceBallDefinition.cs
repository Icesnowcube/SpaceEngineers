﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_SpaceBallDefinition : MyObjectBuilder_CubeBlockDefinition
    {
        [ProtoMember]
        public float MaxVirtualMass;
    }
}
