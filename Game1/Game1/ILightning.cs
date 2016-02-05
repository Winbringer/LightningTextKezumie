﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    // A common interface for LightningBolt and BranchLightning
    interface ILightning
    {
        bool IsComplete { get; }

        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
