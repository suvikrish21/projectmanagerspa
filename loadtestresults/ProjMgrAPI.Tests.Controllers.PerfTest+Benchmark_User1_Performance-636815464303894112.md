# ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User1_Performance
_27-12-2018 22:27:10_
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
|TotalBytesAllocated |           bytes |  1,44,42,568.00 |  1,36,41,172.00 |  1,28,39,776.00 |    11,33,345.09 |
|TotalCollections [Gen0] |     collections |           40.00 |           40.00 |           40.00 |            0.00 |
|TotalCollections [Gen1] |     collections |            5.00 |            4.00 |            3.00 |            1.41 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|    Elapsed Time |              ms |        5,365.00 |        5,237.00 |        5,109.00 |          181.02 |
|[Counter] projcounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Per-second Totals
|          Metric |       Units / s |         Max / s |     Average / s |         Min / s |      StdDev / s |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalBytesAllocated |           bytes |    28,26,851.32 |    26,10,084.01 |    23,93,316.70 |     3,06,555.27 |
|TotalCollections [Gen0] |     collections |            7.83 |            7.64 |            7.46 |            0.26 |
|TotalCollections [Gen1] |     collections |            0.98 |            0.77 |            0.56 |            0.30 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|    Elapsed Time |              ms |        1,000.03 |        1,000.01 |          999.99 |            0.03 |
|[Counter] projcounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Raw Data
#### TotalBytesAllocated
|           Run # |           bytes |       bytes / s |      ns / bytes |
|---------------- |---------------- |---------------- |---------------- |
|               1 |  1,28,39,776.00 |    23,93,316.70 |          417.83 |
|               2 |  1,44,42,568.00 |    28,26,851.32 |          353.75 |

#### TotalCollections [Gen0]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |           40.00 |            7.46 | 13,41,21,155.00 |
|               2 |           40.00 |            7.83 | 12,77,26,632.50 |

#### TotalCollections [Gen1]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            3.00 |            0.56 |1,78,82,82,066.67 |
|               2 |            5.00 |            0.98 |1,02,18,13,060.00 |

#### TotalCollections [Gen2]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |5,36,48,46,200.00 |
|               2 |            0.00 |            0.00 |5,10,90,65,300.00 |

#### Elapsed Time
|           Run # |              ms |          ms / s |         ns / ms |
|---------------- |---------------- |---------------- |---------------- |
|               1 |        5,365.00 |        1,000.03 |     9,99,971.33 |
|               2 |        5,109.00 |          999.99 |    10,00,012.78 |

#### [Counter] projcounter
|           Run # |      operations |  operations / s | ns / operations |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |5,36,48,46,200.00 |
|               2 |            0.00 |            0.00 |5,10,90,65,300.00 |


## Traces
[NBench][DEBUG][27-12-2018 22:26:52][Thread 0001] Beginning Warmups for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User1_Performance
[NBench][DEBUG][27-12-2018 22:26:52][Thread 0001] ----- BEGIN PRE-WARMUP -----
[NBench][INFO][27-12-2018 22:26:52][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User1_Performance
[NBench][INFO][27-12-2018 22:26:59][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User1_Performance
[NBench][INFO][27-12-2018 22:26:59][Thread 0001] Generating report for warmup 1 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User1_Performance
[NBench][DEBUG][27-12-2018 22:26:59][Thread 0001] ----- END PRE-WARMUP -----
[NBench][DEBUG][27-12-2018 22:26:59][Thread 0001] ----- SKIPPING WARMUPS -----
[NBench][INFO][27-12-2018 22:26:59][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User1_Performance
[NBench][INFO][27-12-2018 22:26:59][Thread 0001] Invoking ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User1_Performance
[NBench][INFO][27-12-2018 22:27:05][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User1_Performance
[NBench][INFO][27-12-2018 22:27:05][Thread 0001] Generating report for run 1 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User1_Performance
[NBench][INFO][27-12-2018 22:27:05][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User1_Performance
[NBench][INFO][27-12-2018 22:27:05][Thread 0001] Invoking ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User1_Performance
[NBench][INFO][27-12-2018 22:27:10][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User1_Performance
[NBench][INFO][27-12-2018 22:27:10][Thread 0001] Generating report for run 2 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_User1_Performance


