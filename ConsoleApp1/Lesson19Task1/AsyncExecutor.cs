using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19Task1
{
    internal class AsyncExecutor
    {
        public async Task ExecuteAsync(Action action, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            try
            {
                await Task.Run(action, cancellationToken);
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation is cancelled");
            }
        }
    }
}
