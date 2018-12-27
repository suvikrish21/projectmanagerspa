using NBench;
using System;
using System.Threading.Tasks;
using System.Linq;
using NBench.Util;
using NBench.Metrics.Counters;
using System.Threading;

namespace ProjMgrAPI.Tests.Controllers
{
   
   
    


    public class PerfTest
    {

        public const int IterationCount = 2;
        public const int MaxTimeInSecs =  600000;

        static int _execution = 1;

        public const int RequestCount = 500;

        [PerfSetup]
        public void SetUp(BenchmarkContext ctx)
        {

          // var _counter = new Counter(new AtomicCounter(),
          //      new CounterMetricName("projcounter"));

          //// var  usercounter = ctx.GetCounter("usercounter");
          ////var _counter = ctx.GetCounter("TestCounter");

          //  Console.WriteLine(ctx);

              

        }




        //  usercounter.Increment();

        [PerfBenchmark(NumberOfIterations = IterationCount,
           RunMode = RunMode.Iterations,
            TestMode = TestMode.Measurement,
            RunTimeMilliseconds = MaxTimeInSecs,           
            SkipWarmups = true)]
        [MemoryMeasurement(MemoryMetric.TotalBytesAllocated)]
        [GcMeasurement(GcMetric.TotalCollections, GcGeneration.AllGc)]
        [TimingMeasurement()]
        [CounterMeasurement("projcounter")]
        public void Benchmark_Project0_Performance()
        {

            try
            {


               Parallel.For(0, RequestCount, tsk =>
               {
                   Interlocked.Increment(ref _execution);
                   Console.WriteLine("project0 => " + _execution);

                   var projCtrlTest = new ProjectControllerTest();


                   projCtrlTest.EditProjectTestMethod();
                   Log("EditProjectTestMethod");

                   projCtrlTest.GetProjects2TestMethod();
                   Log("GetProjects2TestMethod");


                   projCtrlTest.GetProjectTestMethod();
                   Log("GetProjectTestMethod");
               });
            }
            catch (Exception ex)
            {
                Console.WriteLine("**************************");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("**************************");

            }







        }


        [PerfBenchmark(NumberOfIterations = IterationCount,
         RunMode = RunMode.Iterations,
            TestMode = TestMode.Measurement,
          RunTimeMilliseconds = MaxTimeInSecs,
          SkipWarmups = true)]
        [MemoryMeasurement(MemoryMetric.TotalBytesAllocated)]
        [GcMeasurement(GcMetric.TotalCollections, GcGeneration.AllGc)]
        [TimingMeasurement()]
        [CounterMeasurement("projcounter")]
        public void Benchmark_Project1_Performance()
        {

            try
            {

                Parallel.For(0, RequestCount, tsk =>
                {

                    Interlocked.Increment(ref _execution);
                    Console.WriteLine("project1 => " + _execution);

                    var projCtrlTest = new ProjectControllerTest();
                    projCtrlTest.AddProjectTestMethod();
                    Log("AddProjectTestMethod");



                    projCtrlTest.DeleteProjectTestMethod();
                    Log("DeleteProjectTestMethod");
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine("**************************");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("**************************");

            }







        }


        [PerfBenchmark(NumberOfIterations = IterationCount,
         RunMode = RunMode.Iterations,
            TestMode = TestMode.Measurement,
        RunTimeMilliseconds = MaxTimeInSecs,
        SkipWarmups = true)]
        [MemoryMeasurement(MemoryMetric.TotalBytesAllocated)]
        [GcMeasurement(GcMetric.TotalCollections, GcGeneration.AllGc)]
        [TimingMeasurement()]
        [CounterMeasurement("projcounter")]
        public void Benchmark_User0_Performance()
        {




            try
            {

                Parallel.For(0, RequestCount, tsk =>
                {

                    var userCtrlTest = new UserControllerTest();



                    userCtrlTest.AddUserTestMethod();
                    Log("AddUserTestMethod");



                    userCtrlTest.DeleteUserTestMethod();
                    Log("DeleteUserTestMethod");

                });


            }
            catch (Exception ex)
            {
                Console.WriteLine("**************************");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("**************************");

            }



        }

        [PerfBenchmark(NumberOfIterations = IterationCount,
         RunMode = RunMode.Iterations,
            TestMode = TestMode.Measurement,
        RunTimeMilliseconds = MaxTimeInSecs,
        SkipWarmups = true)]
        [MemoryMeasurement(MemoryMetric.TotalBytesAllocated)]
        [GcMeasurement(GcMetric.TotalCollections, GcGeneration.AllGc)]
        [TimingMeasurement()]
        [CounterMeasurement("projcounter")]
        public void Benchmark_User1_Performance()
        {




            try
            {

                Parallel.For(0, RequestCount, tsk =>
                {

                    var userCtrlTest = new UserControllerTest();



                    userCtrlTest.GetUsersTestMethod();
                    Log("GetUsersTestMethod");




                    userCtrlTest.EditUserTestMethod();
                    Log("EditUserTestMethod");



                    userCtrlTest.GetUserTestMethod();
                    Log("GetUserTestMethod");

                });


            }
            catch (Exception ex)
            {
                Console.WriteLine("**************************");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("**************************");

            }



        }


        //[PerfBenchmark(NumberOfIterations = 100,
        //  RunMode = RunMode.Throughput,
        //  TestMode = TestMode.Test,

        //   RunTimeMilliseconds = 2 * 60 * 1000,
        //  SkipWarmups = true)]
        //[MemoryMeasurement(MemoryMetric.TotalBytesAllocated)]
        //[GcMeasurement(GcMetric.TotalCollections, GcGeneration.AllGc)]
        //[TimingMeasurement()]
        //[CounterMeasurement("projcounter")]
        //public void Benchmark_User2_Performance()
        //{




        //    try
        //    {
        //        var userCtrlTest = new UserControllerTest();

        //        //userCtrlTest.AddUser2TestMethod();
        //        //Log("AddUser2TestMethod");

        //        userCtrlTest.AddUserTestMethod();
        //        Log("AddUserTestMethod");

        //        userCtrlTest.GetUsersTestMethod();
        //        Log("GetUsersTestMethod");



        //        userCtrlTest.EditUserTestMethod();
        //        Log("EditUserTestMethod");

        //        //userCtrlTest.EditUserTestMethod2();
        //        //Log("EditUserTestMethod2");

        //        userCtrlTest.GetUserTestMethod();
        //        Log("GetUserTestMethod");

        //        userCtrlTest.DeleteUserTestMethod();
        //        Log("DeleteUserTestMethod");

        //        userCtrlTest.GetUsers2TestMethod();
        //        Log("GetUsers2TestMethod");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("**************************");
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine(ex.StackTrace);
        //        Console.WriteLine("**************************");

        //    }



        //}





        [PerfBenchmark(NumberOfIterations = IterationCount,
               RunMode = RunMode.Iterations,
            TestMode = TestMode.Measurement,
                RunTimeMilliseconds = MaxTimeInSecs,
                SkipWarmups = true)]
        [MemoryMeasurement(MemoryMetric.TotalBytesAllocated)]
        [GcMeasurement(GcMetric.TotalCollections, GcGeneration.AllGc)]
        [TimingMeasurement()]
        [CounterMeasurement("projcounter")]
        public void Benchmark_Task0_Performance()
        {



            try
            {
                Parallel.For(0, RequestCount, tsk =>
                {

                    var tskCtrlTest = new TaskControllerTest();
                    tskCtrlTest.AddTaskTestMethod1();
                    Log("AddTaskTestMethod1");



                    tskCtrlTest.DeleteTaskTestMethod();
                    Log("DeleteTaskTestMethod");

                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("**************************");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("**************************");

            }


            //  projcounter.Increment();


        }


        [PerfBenchmark(NumberOfIterations = IterationCount,
          RunMode = RunMode.Iterations,
            TestMode = TestMode.Measurement,
         RunTimeMilliseconds = MaxTimeInSecs,
         SkipWarmups = true)]
        [MemoryMeasurement(MemoryMetric.TotalBytesAllocated)]
        [GcMeasurement(GcMetric.TotalCollections, GcGeneration.AllGc)]
        [TimingMeasurement()]
        [CounterMeasurement("projcounter")]
        public void Benchmark_Task1_Performance()
        {



            try
            {

                Parallel.For(0, RequestCount, tsk =>
                {

                    var tskCtrlTest = new TaskControllerTest();


                    tskCtrlTest.EditTaskTestMethod();
                    Log("EditTaskTestMethod");


                    tskCtrlTest.GetTasksTestMethod();
                    Log("GetTasksTestMethod");


                    tskCtrlTest.GetTaskTestMethod();
                    Log("GetTaskTestMethod");
                });


            }
            catch (Exception ex)
            {
                Console.WriteLine("**************************");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("**************************");

            }


            //  projcounter.Increment();


        }
        //[PerfBenchmark(NumberOfIterations = 100,
        //  RunMode = RunMode.Throughput,
        //  TestMode = TestMode.Test,
        //      RunTimeMilliseconds = 2 * 60 * 1000,
        //  SkipWarmups = true)]
        //[MemoryMeasurement(MemoryMetric.TotalBytesAllocated)]
        //[GcMeasurement(GcMetric.TotalCollections, GcGeneration.AllGc)]
        //[TimingMeasurement()]
        //[CounterMeasurement("projcounter")]
        //public void Benchmark_Task2_Performance()
        //{



        //    try
        //    {
        //        var tskCtrlTest = new TaskControllerTest();
        //        tskCtrlTest.AddTaskTestMethod1();
        //        Log("AddTaskTestMethod1");

        //        //tskCtrlTest.AddTaskTestMethod1();
        //        //Log("AddTaskTestMethod1");

        //        //tskCtrlTest.AddTaskTestMethod2();
        //        //Log("AddTaskTestMethod2");

        //        tskCtrlTest.EditTaskTestMethod();
        //        Log("EditTaskTestMethod");

        //        tskCtrlTest.GetTasksTestMethod();
        //        Log("GetTasksTestMethod");

        //        tskCtrlTest.GetTaskTestMethod();
        //        Log("GetTaskTestMethod");

        //        tskCtrlTest.DeleteTaskTestMethod();
        //        Log("DeleteTaskTestMethod");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("**************************");
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine(ex.StackTrace);
        //        Console.WriteLine("**************************");

        //    }


        //    //  projcounter.Increment();


        //}


        public void Log(string message)
        {
            //Console.WriteLine(DateTime.Now + " " + message);
        }
    }
}
