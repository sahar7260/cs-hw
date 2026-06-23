using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace matala7
{
    internal class TaskManager
    {
        Dictionary<int, Task> tasks = new Dictionary<int, Task>();
        public Task GetTask(int TaskId)
        {
            if (tasks.ContainsKey(TaskId))
            {
                return tasks[TaskId];

            }
            else return null;
        }
        Stack<Task> undoHistiry = new Stack<Task>();
        public void AddTask(Task newTask)
        {
            int taskId = newTask.TaskID;

            tasks.Add(taskId, newTask);
        }
        public void RemoveTask(int TaskId)
        {
            if (tasks.ContainsKey(TaskId))
            {
                Task taskToRemove = tasks[TaskId];
                undoHistiry.Push(taskToRemove);
                tasks.Remove(TaskId);
            }

        }
        public void UndoRemove() 
        {
            Task resstordTask = undoHistiry.Pop();
            tasks[resstordTask.TaskID] = resstordTask;
        }
        public void PrintAllSorted()
        {
           Task [] taskArray = new Task[tasks.Count];

            int index  = 0;
            foreach (var task in tasks.Values)
            {
                taskArray[index++] = task;
            }
            Array.Sort(taskArray);

            foreach (var task in taskArray)
            {
                Console.WriteLine($"task id: {task.TaskID}, description: {task.Description}, priority: {task.Priority}");

            }
        }
    }
}
