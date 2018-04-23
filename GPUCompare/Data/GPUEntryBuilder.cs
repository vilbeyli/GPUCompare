using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPUCompare
{
	public enum GPUBrand
	{
		AMD,
		NVIDIA,
		INTEL
	}

	static class GPUEntryBuilder
	{
		public static GPUEntry GenerateTestEntry(GPUBrand brand)
		{
			GPUEntry entry = null;
			switch (brand)
			{
				case GPUBrand.AMD:		entry = GenerateAMDEntry(); break;
				case GPUBrand.NVIDIA:	entry = GenerateNVIDIAEntry(); break;
				case GPUBrand.INTEL:	entry = GenerateINTELEntry(); break;
				default:				entry = new GPUEntry(); break;
			}
			return entry;
		}


		private static GPUEntry GenerateAMDEntry()
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
		private static GPUEntry GenerateNVIDIAEntry()
		{
			return new GPUEntry()
			{
				Manufacturer = new ManufactoringInfo()
				{
					Brand = "NVidia",
					ModelName = "GeForce GTX 1080 Ti",
					LaunchDate = new DateTime(2017, 3, 10),
					ReleasePrice = 699
				},
				Architecture = new ArchitectureInfo()
				{
					GenerationName = "GP102-350-K1-A1",
					Litography = 16,
					TransistorCount = (long)12e9,
					DieSize = 471,
					BusInterface = "PCI-Express 3.0 x 16"
				},
				Core = new CoreInfo()
				{
					Config = new CoreInfo.CoreConfig(3584, 224, 88),
					Clock = 1480,
					TurboClock = 1582
				},
				Perf = new Performance()
				{
					FillRate = new Performance.FillrateInfo(130.2f, 331.5f),
					FillRateTurbo = new Performance.FillrateInfo(130.2f, 331.5f),
					ProcessingPower = new Performance.ProcessingPowerInfo(166, 10609, 332),
					ProcessingPowerTurbo = new Performance.ProcessingPowerInfo(177, 11340, 354),
					TDP = 250
				},
				Memory = new MemoryInfo()
				{
					BusType = "GDDR5X",
					BusWidth = 352,
					Size = 11,
					Clock = 11000,
					Bandwidth = 484.0f
				}
			};
		}
		private static GPUEntry GenerateINTELEntry()
		{
			return new GPUEntry()
			{
				Manufacturer = new ManufactoringInfo()
				{
					Brand = "Intel",
					ModelName = "HD Graphics 6000",
					LaunchDate = new DateTime(2015, 1, 1),
					ReleasePrice = 0
				},
				Architecture = null,
				Core = new CoreInfo()
				{
					Config = new CoreInfo.CoreConfig(384, 48, 6),
					Clock = 300,
					TurboClock = 950
				},
				Perf = null,
				Memory = null
			};
		}
	}
}
