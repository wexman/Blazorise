﻿using System;

namespace Blazorise
{
    /// <summary>
    /// Defines the placement of a tab items.
    /// </summary>
    public enum TabPosition
    {
        /// <summary>
        /// Top side.
        /// </summary>
        Top,

        /// <summary>
        /// Bottom side.
        /// </summary>
        Bottom,

        /// <summary>
        /// Left side.
        /// </summary>
        [Obsolete( "This parameter will soon be deprecated. Use Start instead." )]
        Left,

        /// <summary>
        /// Right side.
        /// </summary>
        [Obsolete( "This parameter will soon be deprecated. Use End instead." )]
        Right,

        /// <summary>
        /// Start side.
        /// </summary>
        Start,

        /// <summary>
        /// End side.
        /// </summary>
        End,
    }
}
