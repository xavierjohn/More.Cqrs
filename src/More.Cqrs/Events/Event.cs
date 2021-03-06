﻿// Copyright (c) Commonsense Software. All rights reserved.
// Licensed under the MIT license.

namespace More.Domain.Events
{
    using System;

    /// <summary>
    /// Represents the base implementation for an event.
    /// </summary>
    public abstract class Event : Event<Guid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        protected Event() { }
    }
}