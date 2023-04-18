using Newtonsoft.Json;
using Serilize;
using System.Diagnostics;

const int sycleCount = 1000;


var f = new F().Get();
var timer = new Stopwatch();

timer.Start();
for (var i = 0; i < sycleCount; i++) {
    var csv = MyConverter.SerializeObject(f);
    var obj = MyConverter.DeserializeObject<F>(csv);
}
timer.Stop();
var firstTime = timer.ElapsedMilliseconds;
Console.WriteLine($"MyConverter time:{firstTime} ms {MyConverter.SerializeObject(f)}");


timer.Start();
for (var i = 0; i < sycleCount; i++) {
    var json = JsonConvert.SerializeObject(f);
    var obj = JsonConvert.DeserializeObject<F>(json);
}
timer.Stop();
var secondTime = timer.ElapsedMilliseconds;
Console.WriteLine($"json time:{secondTime} ms {JsonConvert.SerializeObject(f)}");

if (firstTime > secondTime)
    Console.WriteLine($"json is {firstTime - secondTime} ms faster than MyConvertor");
else
    Console.WriteLine($"MyConvertor is {secondTime - firstTime} ms  faster than json");