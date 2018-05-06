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

		static public List<string> GetDefaultUIText()
		{
			return new List<string>(){ "", "Lithography: NA", "Transistors: NA  Die: NA", "Bus: NA" };
		}
		public List<string> GetUIText()
		{
			return new List<string>()
			{
				GenerationName,
				"Lithography: " + Litography.ToString() + "nm",
				"Transistors: " + (TransistorCount / 1e9).ToString() + "Bn  Die: " + DieSize.ToString() + "mm^2",
				"Bus: " + BusInterface
			};
		}
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

		public List<string> GetUIText()
		{
			return new List<string>()
			{
				"Shader Cores: " + Config.ShaderCoreCount,
				"Texture Mapping Units: " + Config.TextureMappingUnitCount,
				"Render Output Units: " + Config.RenderOutputUnitCount,
				"Clock: " + Clock + "  Turbo: " + TurboClock
			};
		}
		static public List<string> GetDefaultUIText()
		{
			return new List<string>()
			{
				"Shader Cores: NA",
				"Texture Mapping Units: NA",
				"Render Output Units: NA",
				"Clock: NA  Turbo: NA"
			};
		}
	}
	
	public class MemoryInfo
	{
		public string BusType;
		public int BusWidth;	// -bits
		public long Size;
		public int Clock;		// MT/s
		public float Bandwidth; // GB/s

		public List<string> GetUIText()
		{
			return new List<string>()
			{
				Size.ToString() + " GB",
				BusWidth.ToString() + "-bit " + BusType,
				"Bandwidth: " + Bandwidth.ToString() + " GB/s",
				"Clock: " + Clock.ToString() + " MHz"
			};
		}
		static public List<string> GetDefaultUIText()
		{
			return new List<string>()
			{
				"NA",
				"NA",
				"Bandwidth: NA",
				"Clock: NA"
			};
		}
	}

	public class Performance
	{
		public struct FillrateInfo
		{
			public float PixelFill;		// GP/s
			public float TextureFill;	// GT/s
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

		public List<string> GetUIText()
		{
			return new List<string>()
			{
				"H:" + ProcessingPower.Half.ToString() 
				+ " S:" + ProcessingPower.Single.ToString() 
				+ " D:" + ProcessingPower.Double.ToString(),

				"H:" + ProcessingPowerTurbo.Half.ToString()
				+ " S:" + ProcessingPowerTurbo.Single.ToString()
				+ " D:" + ProcessingPowerTurbo.Double.ToString(),

				"Pixel: " + FillRate.PixelFill.ToString() + " GP/s",
				"Texture: " + FillRate.TextureFill.ToString() + " GT/s",
				TDP.ToString() + " W"
			};
		}
		static public List<string> GetDefaultUIText()
		{
			return new List<string>()
			{
				"NA", "NA",
				"NA", "NA",
				"NA",
			};
		}
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
		public MemoryInfo Memory;
		public Performance Perf;
	}
}
