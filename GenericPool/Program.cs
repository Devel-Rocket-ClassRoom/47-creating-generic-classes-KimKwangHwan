using System;

ObjectPool<Bullet> op = new ObjectPool<Bullet>(3);
Bullet b1 = op.Get();
Bullet b2 = op.Get();
Bullet b3 = op.Get();
b1.Fire(10, 20);
b2.Fire(30, 40);
b3.Fire(50, 60);
Console.WriteLine($"활성: {op.ActiveCount}, 비활성: {op.AvailableCount}");

Console.WriteLine("\n=== 풀 초과 시도 ===");
if (op.Get() == null)
{
    Console.WriteLine("풀이 가득 찼습니다!");
}

Console.WriteLine("\n=== 반납 후 재사용 ===");
op.Return(b1);
Console.WriteLine($"활성: {op.ActiveCount}, 비활성: {op.AvailableCount}");
Bullet b4 = op.Get();
b4.Fire(100, 200);
Console.WriteLine($"활성: {op.ActiveCount}, 비활성: {op.AvailableCount}");