﻿/*
 * Copyright 2020 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : Log
 * Summary  : Represents a log stub
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2017
 * Modified : 2020
 */

using System;

namespace Scada.Log
{
    /// <summary>
    /// Represents a log stub.
    /// <para>Представляет заглушку журнала.</para>
    /// </summary>
    public class LogStub : ILog
    {
        /// <summary>
        /// Writes the message of the specified type to the log.
        /// </summary>
        public void WriteMessage(string text, LogMessageType messageType)
        {
        }

        /// <summary>
        /// Writes the informational message to the log.
        /// </summary>
        public void WriteInfo(string text, params object[] args)
        {
        }

        /// <summary>
        /// Writes the action to the log.
        /// </summary>
        public void WriteAction(string text, params object[] args)
        {
        }

        /// <summary>
        /// Writes the warning message to the log.
        /// </summary>
        public void WriteWarning(string text, params object[] args)
        {
        }

        /// <summary>
        /// Writes the error to the log.
        /// </summary>
        public void WriteError(string text, params object[] args)
        {
        }

        /// <summary>
        /// Writes the exception to the log.
        /// </summary>
        public void WriteException(Exception ex, string text = "", params object[] args)
        {
        }

        /// <summary>
        /// Writes the specified line to the log.
        /// </summary>
        public void WriteLine(string text = "")
        {
        }

        /// <summary>
        /// Writes a divider to the log.
        /// </summary>
        public void WriteBreak()
        {
        }
    }
}
