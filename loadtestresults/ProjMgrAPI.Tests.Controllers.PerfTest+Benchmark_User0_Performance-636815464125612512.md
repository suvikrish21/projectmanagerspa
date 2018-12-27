# ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User0_Performance
_27-12-2018 22:26:52_
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
|TotalBytesAllocated |           bytes |    66,10,640.00 |    61,98,936.00 |    57,87,232.00 |     5,82,237.38 |
|TotalCollections [Gen0] |     collections |           24.00 |           24.00 |           24.00 |            0.00 |
|TotalCollections [Gen1] |     collections |            3.00 |            1.50 |            0.00 |            2.12 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|    Elapsed Time |              ms |        1,874.00 |        1,831.50 |        1,789.00 |           60.10 |
|[Counter] projcounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Per-second Totals
|          Metric |       Units / s |         Max / s |     Average / s |         Min / s |      StdDev / s |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalBytesAllocated |           bytes |    35,26,363.77 |    33,80,500.01 |    32,34,636.26 |     2,06,282.50 |
|TotalCollections [Gen0] |     collections |           13.41 |           13.11 |           12.80 |            0.43 |
|TotalCollections [Gen1] |     collections |            1.68 |            0.84 |            0.00 |            1.19 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|    Elapsed Time |              ms |          999.92 |          999.79 |          999.66 |            0.18 |
|[Counter] projcounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Raw Data
#### TotalBytesAllocated
|           Run # |           bytes |       bytes / s |      ns / bytes |
|---------------- |---------------- |---------------- |---------------- |
|               1 |    66,10,640.00 |    35,26,363.77 |          283.58 |
|               2 |    57,87,232.00 |    32,34,636.26 |          309.15 |

#### TotalCollections [Gen0]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |           24.00 |           12.80 |  7,81,09,733.33 |
|               2 |           24.00 |           13.41 |  7,45,47,691.67 |

#### TotalCollections [Gen1]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |1,87,46,33,600.00 |
|               2 |            3.00 |            1.68 | 59,63,81,533.33 |

#### TotalCollections [Gen2]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |1,87,46,33,600.00 |
|               2 |            0.00 |            0.00 |1,78,91,44,600.00 |

#### Elapsed Time
|           Run # |              ms |          ms / s |         ns / ms |
|---------------- |---------------- |---------------- |---------------- |
|               1 |        1,874.00 |          999.66 |    10,00,338.10 |
|               2 |        1,789.00 |          999.92 |    10,00,080.83 |

#### [Counter] projcounter
|           Run # |      operations |  operations / s | ns / operations |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |1,87,46,33,600.00 |
|               2 |            0.00 |            0.00 |1,78,91,44,600.00 |


## Traces
[NBench][DEBUG][27-12-2018 22:26:46][Thread 0001] Beginning Warmups for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User0_Performance
[NBench][DEBUG][27-12-2018 22:26:46][Thread 0001] ----- BEGIN PRE-WARMUP -----
[NBench][INFO][27-12-2018 22:26:46][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User0_Performance
[NBench][INFO][27-12-2018 22:26:48][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User0_Performance
[NBench][INFO][27-12-2018 22:26:48][Thread 0001] Generating report for warmup 1 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User0_Performance
[NBench][DEBUG][27-12-2018 22:26:48][Thread 0001] ----- END PRE-WARMUP -----
[NBench][DEBUG][27-12-2018 22:26:48][Thread 0001] ----- SKIPPING WARMUPS -----
[NBench][INFO][27-12-2018 22:26:48][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User0_Performance
[NBench][INFO][27-12-2018 22:26:48][Thread 0001] Invoking ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User0_Performance
[NBench][INFO][27-12-2018 22:26:50][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User0_Performance
[NBench][INFO][27-12-2018 22:26:50][Thread 0001] Generating report for run 1 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User0_Performance
[NBench][INFO][27-12-2018 22:26:50][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User0_Performance
[NBench][INFO][27-12-2018 22:26:50][Thread 0001] Invoking ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User0_Performance
[NBench][INFO][27-12-2018 22:26:52][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User0_Performance
[NBench][INFO][27-12-2018 22:26:52][Thread 0001] Generating report for run 2 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User0_Performance


