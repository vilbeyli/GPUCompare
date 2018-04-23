using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPUCompare
{
	public class ArchitectureInfo
	{
		public string GenerationName;
		public int Litography;			// nm
		public long TransistorCount;
		public int DieSize;				// mm^2
		public string BusInterface;
	}
	public class CoreInfo
	{
		public struct CoreConfig
		{
			public int ShaderCoreCount;
			public int TextureMappingUnitCount;
			public int RenderOutputUnitCount;
			public CoreConfig(int c, int t, int r)
			{
				ShaderCoreCount = c;
				TextureMappingUnitCount = t;
				RenderOutputUnitCount = r;
			}
		}

		public CoreConfig Config;
		public int Clock;
		public int TurboClock;
	}
	
	public class MemoryInfo
	{
		public string BusType;
		public int BusWidth;	// -bits
		public long Size;
		public int Clock;		// MT/s
		public float Bandwidth;	// GB/s
	}

	public class Performance
	{
		public struct FillrateInfo
		{
			float PixelFill;	// GP/s
			float TextureFill;	// GT/s
			public FillrateInfo(float px, float tx) { PixelFill = px; TextureFill = tx; }
		}
		public struct ProcessingPowerInfo
		{
			public int Half, Single, Double;
			public ProcessingPowerInfo(int h, int s, int d) { Single = s; Half = h; Double = d; }
		}

		public FillrateInfo FillRate;
		public FillrateInfo FillRateTurbo;
		public ProcessingPowerInfo ProcessingPower;
		public ProcessingPowerInfo ProcessingPowerTurbo;
		public int TDP;
	}

	public class ManufactoringInfo
	{
		public string Brand;
		public string ModelName;
		public DateTime LaunchDate;
		public int ReleasePrice;
	}

	public class GPUEntry
	{
		public ManufactoringInfo Manufacturer;
		public ArchitectureInfo Architecture;
		public CoreInfo Core;
		public Performance Perf;
		public MemoryInfo Memory;
	}
}
