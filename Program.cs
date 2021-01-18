using System;
using StackExchange.Redis;

namespace MyNamespace
{
    
    class Program
    {
        public static void Main(string[] args){
            Console.WriteLine("Amankan, siap");
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("127.0.0.1:8080");
            IDatabase db = redis.GetDatabase();
        }
    
    }
}