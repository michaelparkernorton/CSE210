
class Program {
    static void Main(string[] args) {
        DateOnly date = new DateOnly(2022, 11, 3);
        Activity[] activities = {
            new Running(date, 30, 3),
            new Bicycling(date, 30, 12),
            new Swimming(date, 20, 20)
        };

        foreach (var activity in activities) {
            activity.GetSummary();
        }
    }
}