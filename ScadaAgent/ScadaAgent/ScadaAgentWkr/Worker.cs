/*
 * Copyright 2022 Rapid Software LLC
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
 * Module   : Agent Worker
 * Summary  : Implements the Agent service
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2021
 * Modified : 2021
 */

using Scada.Agent.Engine;

namespace Scada.Agent.Wkr
{
    /// <summary>
    /// Implements the Agent service.
    /// <para>��������� ������ ������.</para>
    /// </summary>
    public class Worker : BackgroundService
    {
        private const int TaskDelay = 1000;
        private readonly ILogger<Worker> logger;
        private readonly Manager manager;

        public Worker(ILogger<Worker> logger)
        {
            this.logger = logger;
            manager = new Manager();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.Register(() =>
            {
                manager.StopService();
                logger.LogInformation("Agent is stopped");
            });

            if (manager.StartService())
                logger.LogInformation("Agent is started successfully");
            else
                logger.LogError("Agent is started with errors");

            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(TaskDelay, stoppingToken);
            }
        }
    }
}
