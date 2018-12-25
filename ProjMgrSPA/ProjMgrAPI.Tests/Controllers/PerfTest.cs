using NBench;
using System;


namespace ProjMgrAPI.Tests.Controllers
{
  
    public class PerfTest
    {
        [PerfBenchmark(NumberOfIterations = 10, RunMode = RunMode.Throughput,  
            
            TestMode = TestMode.Test, SkipWarmups = true)]
        [ElapsedTimeAssertion(MaxTimeMilliseconds = 5000)]
        public void Benchmark_Performance_ElapsedTime()
        {
            var userCtrlTest = new UserControllerTest();
            userCtrlTest.GetUsersTestMethod();
            userCtrlTest.GetUsers2TestMethod();

        }
    }
}
