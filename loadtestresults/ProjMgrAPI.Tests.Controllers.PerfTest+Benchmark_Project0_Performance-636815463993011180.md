# ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project0_Performance
_27-12-2018 22:26:39_
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
|TotalBytesAllocated |           bytes |  1,02,35,792.00 |    90,31,540.00 |    78,27,288.00 |    17,03,069.51 |
|TotalCollections [Gen0] |     collections |           98.00 |           98.00 |           98.00 |            0.00 |
|TotalCollections [Gen1] |     collections |           48.00 |           46.50 |           45.00 |            2.12 |
|TotalCollections [Gen2] |     collections |            1.00 |            1.00 |            1.00 |            0.00 |
|    Elapsed Time |              ms |        7,998.00 |        7,532.50 |        7,067.00 |          658.32 |
|[Counter] projcounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Per-second Totals
|          Metric |       Units / s |         Max / s |     Average / s |         Min / s |      StdDev / s |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalBytesAllocated |           bytes |    14,48,378.38 |    12,13,516.45 |     9,78,654.51 |     3,32,144.93 |
|TotalCollections [Gen0] |     collections |           13.87 |           13.06 |           12.25 |            1.14 |
|TotalCollections [Gen1] |     collections |            6.79 |            6.21 |            5.63 |            0.82 |
|TotalCollections [Gen2] |     collections |            0.14 |            0.13 |            0.13 |            0.01 |
|    Elapsed Time |              ms |        1,000.00 |          999.99 |          999.99 |            0.01 |
|[Counter] projcounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Raw Data
#### TotalBytesAllocated
|           Run # |           bytes |       bytes / s |      ns / bytes |
|---------------- |---------------- |---------------- |---------------- |
|               1 |    78,27,288.00 |     9,78,654.51 |        1,021.81 |
|               2 |  1,02,35,792.00 |    14,48,378.38 |          690.43 |

#### TotalCollections [Gen0]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |           98.00 |           12.25 |  8,16,12,340.82 |
|               2 |           98.00 |           13.87 |  7,21,12,963.27 |

#### TotalCollections [Gen1]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |           45.00 |            5.63 | 17,77,33,542.22 |
|               2 |           48.00 |            6.79 | 14,72,30,633.33 |

#### TotalCollections [Gen2]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            1.00 |            0.13 |7,99,80,09,400.00 |
|               2 |            1.00 |            0.14 |7,06,70,70,400.00 |

#### Elapsed Time
|           Run # |              ms |          ms / s |         ns / ms |
|---------------- |---------------- |---------------- |---------------- |
|               1 |        7,998.00 |        1,000.00 |    10,00,001.18 |
|               2 |        7,067.00 |          999.99 |    10,00,009.96 |

#### [Counter] projcounter
|           Run # |      operations |  operations / s | ns / operations |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |7,99,80,09,400.00 |
|               2 |            0.00 |            0.00 |7,06,70,70,400.00 |


## Traces
[NBench][DEBUG][27-12-2018 22:26:01][Thread 0001] Beginning Warmups for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project0_Performance
[NBench][DEBUG][27-12-2018 22:26:01][Thread 0001] ----- BEGIN PRE-WARMUP -----
[NBench][INFO][27-12-2018 22:26:01][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project0_Performance
[NBench][INFO][27-12-2018 22:26:23][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project0_Performance
[NBench][INFO][27-12-2018 22:26:23][Thread 0001] Generating report for warmup 1 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project0_Performance
[NBench][DEBUG][27-12-2018 22:26:23][Thread 0001] ----- END PRE-WARMUP -----
[NBench][DEBUG][27-12-2018 22:26:23][Thread 0001] ----- SKIPPING WARMUPS -----
[NBench][INFO][27-12-2018 22:26:23][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project0_Performance
[NBench][INFO][27-12-2018 22:26:24][Thread 0001] Invoking ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project0_Performance
[NBench][INFO][27-12-2018 22:26:32][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project0_Performance
[NBench][INFO][27-12-2018 22:26:32][Thread 0001] Generating report for run 1 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project0_Performance
[NBench][INFO][27-12-2018 22:26:32][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project0_Performance
[NBench][INFO][27-12-2018 22:26:32][Thread 0001] Invoking ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project0_Performance
[NBench][INFO][27-12-2018 22:26:39][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project0_Performance
[NBench][INFO][27-12-2018 22:26:39][Thread 0001] Generating report for run 2 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Project0_Performance


