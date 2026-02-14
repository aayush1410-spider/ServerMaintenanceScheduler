# ServerMaintenanceScheduler
As a part of one of the technical rounds of the software company I have created this basic console application project which finds the largest set of compatible time intervals from given maintenance requests. as a part of solution I used a greedy approach by selecting intervals with earliest finish times.

# Maintenance Scheduler – Interval Compatibility

## Overview

This console application determines the maximum number of non-overlapping maintenance tasks that a single engineer can complete from a list of requested server maintenance windows.

The solution uses a greedy interval scheduling approach to ensure minimal downtime while maximizing task completion.

---

## Problem Statement

You are given a list of maintenance requests, each represented as a time interval `[start_time, end_time]`.
Since a maintenance engineer can work on only one server at a time, the goal is to compute the maximum number of non-overlapping tasks that can be performed sequentially.

## Solution Approach

The program applies a greedy strategy:

1. Sort maintenance intervals by their end time.
2. Select the earliest finishing task.
3. Continue selecting the next task that starts at or after the last selected task's end time.
4. Return the total number of compatible tasks.

This approach guarantees an optimal solution.
## Author

Submitted as part of a coding assessment.

