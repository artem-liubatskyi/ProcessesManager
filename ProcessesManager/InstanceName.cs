using System.Linq;
using System.Diagnostics;

namespace ProcessesManager
{
    public static class InstanceName
    {
        public static string GetInstanceNameForProcessId(int processId, string processName)
        {
            PerformanceCounterCategory cat = new PerformanceCounterCategory("Process");
            string[] instances = cat.GetInstanceNames()
                    .Where(inst => inst.StartsWith(processName))
                    .ToArray();

            if (instances.Length == 0)
                return null;

            try
            {
                foreach (string instance in instances)
                {
                    PerformanceCounter cnt =
                        new PerformanceCounter("Process", "ID Process", instance, true);

                    if (cnt.RawValue == processId)
                    {
                        return instance;
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
        }
    }
}
