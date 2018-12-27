# ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task0_Performance
_27-12-2018 22:27:17_
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
|TotalBytesAllocated |           bytes |    67,14,272.00 |    39,70,964.00 |    12,27,656.00 |    38,79,623.38 |
|TotalCollections [Gen0] |     collections |           26.00 |           26.00 |           26.00 |            0.00 |
|TotalCollections [Gen1] |     collections |            4.00 |            2.50 |            1.00 |            2.12 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|    Elapsed Time |              ms |        2,358.00 |        1,995.00 |        1,632.00 |          513.36 |
|[Counter] projcounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Per-second Totals
|          Metric |       Units / s |         Max / s |     Average / s |         Min / s |      StdDev / s |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalBytesAllocated |           bytes |    41,14,513.16 |    23,17,581.66 |     5,20,650.16 |    25,41,244.90 |
|TotalCollections [Gen0] |     collections |           15.93 |           13.48 |           11.03 |            3.47 |
|TotalCollections [Gen1] |     collections |            2.45 |            1.44 |            0.42 |            1.43 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|    Elapsed Time |              ms |        1,000.09 |        1,000.06 |        1,000.03 |            0.04 |
|[Counter] projcounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Raw Data
#### TotalBytesAllocated
|           Run # |           bytes |       bytes / s |      ns / bytes |
|---------------- |---------------- |---------------- |---------------- |
|               1 |    67,14,272.00 |    41,14,513.16 |          243.04 |
|               2 |    12,27,656.00 |     5,20,650.16 |        1,920.68 |

#### TotalCollections [Gen0]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |           26.00 |           15.93 |  6,27,63,496.15 |
|               2 |           26.00 |           11.03 |  9,06,89,569.23 |

#### TotalCollections [Gen1]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            4.00 |            2.45 | 40,79,62,725.00 |
|               2 |            1.00 |            0.42 |2,35,79,28,800.00 |

#### TotalCollections [Gen2]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |1,63,18,50,900.00 |
|               2 |            0.00 |            0.00 |2,35,79,28,800.00 |

#### Elapsed Time
|           Run # |              ms |          ms / s |         ns / ms |
|---------------- |---------------- |---------------- |---------------- |
|               1 |        1,632.00 |        1,000.09 |     9,99,908.64 |
|               2 |        2,358.00 |        1,000.03 |     9,99,969.80 |

#### [Counter] projcounter
|           Run # |      operations |  operations / s | ns / operations |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |1,63,18,50,900.00 |
|               2 |            0.00 |            0.00 |2,35,79,28,800.00 |


## Traces
[NBench][DEBUG][27-12-2018 22:27:10][Thread 0001] Beginning Warmups for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task0_Performance
[NBench][DEBUG][27-12-2018 22:27:10][Thread 0001] ----- BEGIN PRE-WARMUP -----
[NBench][INFO][27-12-2018 22:27:10][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task0_Performance
[NBench][INFO][27-12-2018 22:27:13][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task0_Performance
[NBench][INFO][27-12-2018 22:27:13][Thread 0001] Generating report for warmup 1 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task0_Performance
[NBench][DEBUG][27-12-2018 22:27:13][Thread 0001] ----- END PRE-WARMUP -----
[NBench][DEBUG][27-12-2018 22:27:13][Thread 0001] ----- SKIPPING WARMUPS -----
[NBench][INFO][27-12-2018 22:27:13][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task0_Performance
[NBench][INFO][27-12-2018 22:27:13][Thread 0001] Invoking ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task0_Performance
[NBench][INFO][27-12-2018 22:27:15][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task0_Performance
[NBench][INFO][27-12-2018 22:27:15][Thread 0001] Generating report for run 1 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task0_Performance
[NBench][INFO][27-12-2018 22:27:15][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task0_Performance
[NBench][INFO][27-12-2018 22:27:15][Thread 0001] Invoking ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task0_Performance
[NBench][INFO][27-12-2018 22:27:17][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task0_Performance
[NBench][INFO][27-12-2018 22:27:17][Thread 0001] Generating report for run 2 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task0_Performance


