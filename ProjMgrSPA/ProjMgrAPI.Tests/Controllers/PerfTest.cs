using NBench;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace ProjMgrAPI.Tests.Controllers
{
  
    public class PerfTest
    {

        private int parallelrequest = 2;
        private Counter usercounter;
        private Counter projcounter;
        
        [PerfSetup]
        public void SetUp(BenchmarkContext ctx)
        {
            

            // usercounter = ctx.GetCounter("usercounter");
            //  projcounter = ctx.GetCounter("projcounter");


        }

        [PerfBenchmark(NumberOfIterations = 1, RunMode = RunMode.Throughput,  
                
            TestMode = TestMode.Test, RunTimeMilliseconds = 6000, SkipWarmups = true)]
        [MemoryMeasurement(MemoryMetric.TotalBytesAllocated)]
        [GcMeasurement(GcMetric.TotalCollections, GcGeneration.AllGc)]
        [TimingMeasurement()]
        [CounterMeasurement("usercounter")]
        public void Benchmark_User_Performance()
        {
            Parallel.For(0, parallelrequest, tsk => 
            {
                try
                {
                    var userCtrlTest = new UserControllerTest();

                    userCtrlTest.AddUser2TestMethod();
                    userCtrlTest.AddUserTestMethod();

                    userCtrlTest.GetUsersTestMethod();
                    userCtrlTest.GetUsers2TestMethod();
                    userCtrlTest.EditUserTestMethod();
                    userCtrlTest.EditUserTestMethod2();


                    userCtrlTest.GetUserTestMethod();
                    userCtrlTest.DeleteUserTestMethod();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("**************************");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine("**************************");

                }

            });

          //  usercounter.Increment();

        }



        [PerfBenchmark(NumberOfIterations = 1, RunMode = RunMode.Throughput,

            TestMode = TestMode.Test, RunTimeMilliseconds = 6000, SkipWarmups = true)]
        [MemoryMeasurement(MemoryMetric.TotalBytesAllocated)]
        [GcMeasurement(GcMetric.TotalCollections, GcGeneration.AllGc)]
        [TimingMeasurement()]
        [CounterMeasurement("projcounter")]
        public void Benchmark_Project_Performance()
        {
            Parallel.For(0, parallelrequest, tsk =>
            {
                try
                {
                    var projCtrlTest = new ProjectControllerTest();
                    projCtrlTest.AddProjectTestMethod();
                    projCtrlTest.AddProjectTestMethod1();
                    projCtrlTest.AddProjectTestMethod2();
                    projCtrlTest.EditProjectTestMethod();
                    projCtrlTest.GetProjects2TestMethod();
                    projCtrlTest.GetProjectsTestMethod();
                    projCtrlTest.GetProjectTestMethod();
                    projCtrlTest.DeleteProjectTestMethod();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("**************************");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine("**************************");

                }
               

            });

          //  projcounter.Increment();


        }



        [PerfBenchmark(NumberOfIterations = 1, RunMode = RunMode.Throughput,

            TestMode = TestMode.Test, RunTimeMilliseconds = 6000, SkipWarmups = true)]
        [MemoryMeasurement(MemoryMetric.TotalBytesAllocated)]
        [GcMeasurement(GcMetric.TotalCollections, GcGeneration.AllGc)]
        [TimingMeasurement()]
        [CounterMeasurement("tskcounter")]
        public void Benchmark_Task_Performance()
        {
            Parallel.For(0, parallelrequest, tsk =>
            {
                try
                {
                    var tskCtrlTest = new TaskControllerTest();
                    tskCtrlTest.AddTaskTestMethod();
                    tskCtrlTest.AddTaskTestMethod1();
                    tskCtrlTest.AddTaskTestMethod2();
                    tskCtrlTest.EditTaskTestMethod();
                    tskCtrlTest.GetTasksTestMethod();
                    tskCtrlTest.GetTaskTestMethod();
                    tskCtrlTest.DeleteTaskTestMethod();
                 
                }
                catch (Exception ex)
                {
                    Console.WriteLine("**************************");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine("**************************");

                }


            });

            //  projcounter.Increment();


        }
    }
}
