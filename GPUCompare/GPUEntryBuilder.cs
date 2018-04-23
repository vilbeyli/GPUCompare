using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPUCompare
{
	static class GPUEntryBuilder
	{
		public static GPUEntry GenerateTestEntry()
		{
			return new GPUEntry()
			{
				Manufacturer = new ManufactoringInfo()
				{
					Brand = "AMD",
					ModelName = "Radeon RX Vega 64 LC",
					LaunchDate = new DateTime(2017, 8, 14),
					ReleasePrice = 699
				},
				Architecture = new ArchitectureInfo()
				{
					GenerationName = "GCN 5th gen",
					Litography = 14,
					TransistorCount = (long)125e9,
					DieSize = 486,
					BusInterface = "PCI-Express 3.0 x 16"
				},
				Core = new CoreInfo()
				{
					Config = new CoreInfo.CoreConfig(3584, 224, 64),
					Clock = 1406,
					TurboClock = 1677
				},
				Perf = new Performance()
				{
					FillRate = new Performance.FillrateInfo(359.0f, 90.0f),
					FillRateTurbo = new Performance.FillrateInfo(429.3f, 107.3f),
					ProcessingPower = new Performance.ProcessingPowerInfo(23036, 11518, 720),
					ProcessingPowerTurbo = new Performance.ProcessingPowerInfo(27476, 13738, 859),
					TDP = 345
				},
				Memory = new MemoryInfo()
				{
					BusType = "HMB2",
					BusWidth = 2048,
					Size = 8,
					Clock = 1890,
					Bandwidth = 483.8f
				}
			};
		}


	}
}
