using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using FastEnumUtility;

namespace BenchMarker.___
{
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp30)]
    [SimpleJob(RuntimeMoniker.NativeAot70)]
    [SimpleJob(RuntimeMoniker.Mono)]
    [RPlotExporter]
    public class __Enums
    {
        [Benchmark(Baseline = true)]
        public void ConvertStatusDef()
        {
            string _ = TrxStatus.Pendin.ToString();
        }

        [Benchmark()]
        public void ConvertStatusFastEnum()
        {
            string _ = TrxStatus.Pendin.FastToString();
        }

        [Benchmark()]
        public void ConvertStatusNameOf()
        {
            string _ = nameof(TrxStatus.Pendin);
        }
    }

    public enum TrxStatus
    {
        Pendin = 1,
        Completed,
        Rejected
    }
}
