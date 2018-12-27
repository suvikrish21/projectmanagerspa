# ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task1_Performance
_27-12-2018 22:32:26_
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
|TotalBytesAllocated |           bytes | 33,80,30,712.00 | 26,15,12,456.00 | 18,49,94,200.00 | 10,82,13,155.40 |
|TotalCollections [Gen0] |     collections |        1,358.00 |        1,356.50 |        1,355.00 |            2.12 |
|TotalCollections [Gen1] |     collections |          495.00 |          493.00 |          491.00 |            2.83 |
|TotalCollections [Gen2] |     collections |           33.00 |           30.50 |           28.00 |            3.54 |
|    Elapsed Time |              ms |     1,04,211.00 |     1,03,387.50 |     1,02,564.00 |        1,164.60 |
|[Counter] projcounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Per-second Totals
|          Metric |       Units / s |         Max / s |     Average / s |         Min / s |      StdDev / s |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalBytesAllocated |           bytes |    32,43,738.11 |    25,23,716.16 |    18,03,694.21 |    10,18,264.81 |
|TotalCollections [Gen0] |     collections |           13.24 |           13.12 |           13.00 |            0.17 |
|TotalCollections [Gen1] |     collections |            4.83 |            4.77 |            4.71 |            0.08 |
|TotalCollections [Gen2] |     collections |            0.32 |            0.30 |            0.27 |            0.04 |
|    Elapsed Time |              ms |        1,000.01 |        1,000.00 |        1,000.00 |            0.01 |
|[Counter] projcounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Raw Data
#### TotalBytesAllocated
|           Run # |           bytes |       bytes / s |      ns / bytes |
|---------------- |---------------- |---------------- |---------------- |
|               1 | 33,80,30,712.00 |    32,43,738.11 |          308.29 |
|               2 | 18,49,94,200.00 |    18,03,694.21 |          554.42 |

#### TotalCollections [Gen0]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |        1,355.00 |           13.00 |  7,69,07,922.88 |
|               2 |        1,358.00 |           13.24 |  7,55,25,817.08 |

#### TotalCollections [Gen1]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |          491.00 |            4.71 | 21,22,40,805.50 |
|               2 |          495.00 |            4.83 | 20,72,00,120.40 |

#### TotalCollections [Gen2]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |           28.00 |            0.27 |3,72,17,94,125.00 |
|               2 |           33.00 |            0.32 |3,10,80,01,806.06 |

#### Elapsed Time
|           Run # |              ms |          ms / s |         ns / ms |
|---------------- |---------------- |---------------- |---------------- |
|               1 |     1,04,211.00 |        1,000.01 |     9,99,992.66 |
|               2 |     1,02,564.00 |        1,000.00 |    10,00,000.58 |

#### [Counter] projcounter
|           Run # |      operations |  operations / s | ns / operations |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |1,04,21,02,35,500.00 |
|               2 |            0.00 |            0.00 |1,02,56,40,59,600.00 |


## Traces
[NBench][DEBUG][27-12-2018 22:27:17][Thread 0001] Beginning Warmups for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task1_Performance
[NBench][DEBUG][27-12-2018 22:27:17][Thread 0001] ----- BEGIN PRE-WARMUP -----
[NBench][INFO][27-12-2018 22:27:17][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task1_Performance
[NBench][INFO][27-12-2018 22:28:58][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task1_Performance
[NBench][INFO][27-12-2018 22:28:58][Thread 0001] Generating report for warmup 1 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task1_Performance
[NBench][DEBUG][27-12-2018 22:28:58][Thread 0001] ----- END PRE-WARMUP -----
[NBench][DEBUG][27-12-2018 22:28:58][Thread 0001] ----- SKIPPING WARMUPS -----
[NBench][INFO][27-12-2018 22:28:58][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task1_Performance
[NBench][INFO][27-12-2018 22:28:58][Thread 0001] Invoking ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task1_Performance
[NBench][INFO][27-12-2018 22:30:43][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task1_Performance
[NBench][INFO][27-12-2018 22:30:43][Thread 0001] Generating report for run 1 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task1_Performance
[NBench][INFO][27-12-2018 22:30:43][Thread 0001] Invoking setup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task1_Performance
[NBench][INFO][27-12-2018 22:30:44][Thread 0001] Invoking ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task1_Performance
[NBench][INFO][27-12-2018 22:32:26][Thread 0001] Invoking cleanup for ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task1_Performance
[NBench][INFO][27-12-2018 22:32:26][Thread 0001] Generating report for run 2 of ProjMgrAPI.Tests.Controllers.PerfTest+Benchmark_Task1_Performance


