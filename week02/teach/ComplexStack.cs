using System.Diagnostics;

public static class ComplexStack {
    public static void Run()
    {
        Trace.Assert(DoSomethingComplicated("(a==3 or (b==5 and c== 6))"));
        Console.WriteLine("Test 1 Passed");
        Trace.Assert(!DoSomethingComplicated("(students]i].Grade > 80 and students[i].Grade < 90)"));
        Console.WriteLine("Test 2 Passed");
        Trace.Assert(!DoSomethingComplicated("(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing))"));
        Console.WriteLine("Test 3 Passed");
    }
    public static bool DoSomethingComplicated(string line) {
        var stack = new Stack<char>();
        foreach (var item in line) {
            if (item is '(' or '[' or '{') {
                stack.Push(item);
            }
            else if (item is ')') {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
            else if (item is ']') {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}') {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}