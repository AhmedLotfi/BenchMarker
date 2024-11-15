using BenchmarkDotNet.Running;
using BenchMarker.___;

try
{
    Console.WriteLine("Benshmarks");

    BenchmarkDotNet.Reports.Summary summary = BenchmarkRunner.Run<__Enums>();
}
catch (Exception x)
{
    Console.WriteLine(x.Message);
}

