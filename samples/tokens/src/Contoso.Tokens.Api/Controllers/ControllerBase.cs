﻿namespace Contoso.Services.Controllers
{
    using System;
    using System.Diagnostics;
    using System.Web.OData;
    using static System.TimeSpan;

    public abstract class ControllerBase : ODataController, IHaveServiceLevelAgreement
    {
        protected ControllerBase() { }

        public TimeSpan Timeout { get; protected set; } =
#if DEBUG
            Debugger.IsAttached ? FromMinutes( 10d ) : FromSeconds( 2d );
#else
            FromSeconds( 2d );
#endif
    }
}