using System.Reactive.Linq;

Observable.Start(() => args[0])
    .SelectMany(x => x.Split("-"))
    .ToList()
    .Select(x => string.Join("/", x[2], x[0], x[1]))
    .Subscribe(x =>
    {
        Console.WriteLine(x);
    });