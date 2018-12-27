# ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project1_Performance
_27-12-2018 22:26:46_
### System Info
```ini
NBench=NBench, Version=1.2.2.0, Culture=neutral, PublicKeyToken=null
OS=Microsoft Windows NT 6.2.9200.0
ProcessorCount=3
CLR=4.0.30319.42000,IsMono=False,MaxGcGeneration=2
```

### NBench Settings
```ini
RunMode=Iterations, TestMode=Measurement
SkipWarmups=True
NumberOfIterations=2, MaximumRunTime=00:10:00
Concurrent=True
Tracing=True
```

## Data
-------------------

### Totals
|          Metric |           Units |             Max |         Average |             Min |          StdDev |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalBytesAllocated |           bytes |    60,01,952.00 |    56,92,388.00 |    53,82,824.00 |     4,37,789.61 |
|TotalCollections [Gen0] |     collections |           24.00 |           24.00 |           24.00 |            0.00 |
|TotalCollections [Gen1] |     collections |            3.00 |            2.50 |            2.00 |            0.71 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|    Elapsed Time |              ms |        2,513.00 |        2,197.00 |        1,881.00 |          446.89 |
|[Counter] projcounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Per-second Totals
|          Metric |       Units / s |         Max / s |     Average / s |         Min / s |      StdDev / s |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalBytesAllocated |           bytes |    31,90,312.77 |    26,66,010.11 |    21,41,707.45 |     7,41,475.93 |
|TotalCollections [Gen0] |     collections |           12.76 |           11.15 |            9.55 |            2.27 |
|TotalCollections [Gen1] |     collections |            1.19 |            1.13 |            1.06 |            0.09 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|    Elapsed Time |              ms |          999.87 |          999.85 |          999.84 |            0.02 |
|[Counter] projcounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Raw Data
#### TotalBytesAllocated
|           Run # |           bytes |       bytes / s |      ns / bytes |
|---------------- |---------------- |---------------- |---------------- |
|               1 |    60,01,952.00 |    31,90,312.77 |          313.45 |
|               2 |    53,82,824.00 |    21,41,707.45 |          466.92 |

#### TotalCollections [Gen0]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |           24.00 |           12.76 |  7,83,87,716.67 |
|               2 |           24.00 |            9.55 | 10,47,22,208.33 |

#### TotalCollections [Gen1]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            2.00 |            1.06 | 94,06,52,600.00 |
|               2 |            3.00 |            1.19 | 83,77,77,666.67 |

#### TotalCollections [Gen2]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |1,88,13,05,200.00 |
|               2 |            0.00 |            0.00 |2,51,33,33,000.00 |

#### Elapsed Time
|           Run # |              ms |          ms / s |         ns / ms |
|---------------- |---------------- |---------------- |---------------- |
|               1 |        1,881.00 |          999.84 |    10,00,162.25 |
|               2 |        2,513.00 |          999.87 |    10,00,132.51 |

#### [Counter] projcounter
|           Run # |      operations |  operations / s | ns / operations |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |1,88,13,05,200.00 |
|               2 |            0.00 |            0.00 |2,51,33,33,000.00 |


## Traces
[NBench][DEBUG][27-12-2018 22:26:39][Thread 0001] Beginning Warmups for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project1_Performance
[NBench][DEBUG][27-12-2018 22:26:39][Thread 0001] ----- BEGIN PRE-WARMUP -----
[NBench][INFO][27-12-2018 22:26:39][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project1_Performance
[NBench][INFO][27-12-2018 22:26:42][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project1_Performance
[NBench][INFO][27-12-2018 22:26:42][Thread 0001] Generating report for warmup 1 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project1_Performance
[NBench][DEBUG][27-12-2018 22:26:42][Thread 0001] ----- END PRE-WARMUP -----
[NBench][DEBUG][27-12-2018 22:26:42][Thread 0001] ----- SKIPPING WARMUPS -----
[NBench][INFO][27-12-2018 22:26:42][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project1_Performance
[NBench][INFO][27-12-2018 22:26:42][Thread 0001] Invoking ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project1_Performance
[NBench][INFO][27-12-2018 22:26:44][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project1_Performance
[NBench][INFO][27-12-2018 22:26:44][Thread 0001] Generating report for run 1 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project1_Performance
[NBench][INFO][27-12-2018 22:26:44][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project1_Performance
[NBench][INFO][27-12-2018 22:26:44][Thread 0001] Invoking ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project1_Performance
[NBench][INFO][27-12-2018 22:26:46][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project1_Performance
[NBench][INFO][27-12-2018 22:26:46][Thread 0001] Generating report for run 2 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project1_Performance


