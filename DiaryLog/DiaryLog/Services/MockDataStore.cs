using DiaryLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiaryLog.Services
{
    public class MockDataStore : IDataStore<TaskItem>
    {
        readonly List<TaskItem> task;

        public MockDataStore()
        {
            task = new List<TaskItem>()
            {
                new TaskItem { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new TaskItem { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new TaskItem { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new TaskItem { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new TaskItem { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new TaskItem { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
            };
        }

        public async Task<bool> AddItemAsync(TaskItem item)
        {
            task.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(TaskItem item)
        {
            var oldItem = task.Where((TaskItem arg) => arg.Id == item.Id).FirstOrDefault();
            task.Remove(oldItem);
            task.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = task.Where((TaskItem arg) => arg.Id == id).FirstOrDefault();
            task.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<TaskItem> GetItemAsync(string id)
        {
            return await Task.FromResult(task.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<TaskItem>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(task);
        }
    }
}