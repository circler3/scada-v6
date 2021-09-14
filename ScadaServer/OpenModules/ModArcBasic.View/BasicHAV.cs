﻿// Copyright (c) Rapid Software LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Scada.Forms;
using Scada.Server.Archives;
using Scada.Server.Config;

namespace Scada.Server.Modules.ModArcBasic.View
{
    /// <summary>
    /// Implements the historical data archive user interface.
    /// <para>Реализует пользовательский интерфейс архива исторических данных.</para>
    /// </summary>
    public class BasicHAV : ArchiveView
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public BasicHAV(ModuleView parentView, ArchiveConfig archiveConfig)
            : base(parentView, archiveConfig)
        {
            CanShowProperties = true;
        }

        /// <summary>
        /// Shows a modal dialog box for editing archive properties.
        /// </summary>
        public override bool ShowProperties()
        {
            ScadaUiUtils.ShowInfo("ShowProperties");
            return true;
        }
    }
}
