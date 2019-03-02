# wpf-responsiveness-samples

Some slightly different approaches to keep the app responsive with long running tasks

- __Synchronous__: the app freezes while processing the task;
- __Asynchronous async/await__: the app responds while processing the task.
- __Asynchronous async/await with callback__: the app responds while processing the task. A callback method is used to continue the process.
- __Asynchronous with task__: the app responds while processing the task. Without using the async/await, the process as to be continued on the main thread.
