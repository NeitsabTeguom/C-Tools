private Dictionary<string, TimeSpan> times = new Dictionary<string, TimeSpan>();
private DateTime lastDT = new DateTime();
private void GetTimes(string partName = null)
{
    if (partName == null)
    {
        this.times.Clear();
        this.lastDT = DateTime.Now;
        return;
    }

    int cnt = this.times.Count + 1;
    string key = cnt.ToString() + "_" + partName;
    this.times.Add(key, DateTime.Now.Subtract(this.lastDT));
    this.lastDT = DateTime.Now;
}