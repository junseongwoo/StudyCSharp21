using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SideTaskApp
{
    class Program
    {
        class SideTask
        {
            int Count { get; set; }

            public SideTask(int count)
            {
                this.Count = count;
            }
            public void CountDown()
            {
                try
                {
                    while (Count > 0)
                    {
                        Console.WriteLine($"{Count} 남음");
                        Count--;
                        Thread.Sleep(10);
                    }
                    Console.WriteLine($"Count : {Count}");
                }
                catch(ThreadAbortException ex)
                {
                    Console.WriteLine($"스레드 임의종료 예외발생 : {ex.Message}");
                    Thread.ResetAbort();                }
                catch (Exception ex)
                {
                    Console.WriteLine($"스레드 예외발생 {ex.Message} ");
                }
                
            }
        }
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread th = new Thread(task.CountDown);
            th.IsBackground = false; // 이 스레드가 종료되기 전까지는 프로세스가 끝나지 않음
            // true인 경우, 백그라운드 스레가 돌고있는 상태에도 메인스레드가 끝나면 모두 끝남
            SideTask task2 = new SideTask(200);
            Thread th2 = new Thread(task2.CountDown); // 기본값 IsBackground false 

            Console.WriteLine("스레드 시작!");
            th.Start();
            th2.Start();

            Thread.Sleep(1000); // 1초

            Console.WriteLine("임의 종료!");
            th.Abort();

            Console.WriteLine("종료 대기");
            th.Join();
            th2.Join();

            Console.WriteLine("스레드 종료!");
        }
    }
}
