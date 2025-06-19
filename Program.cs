using System.Drawing;
using System.Runtime.InteropServices;

const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
const uint MOUSEEVENTF_LEFTUP = 0x0004;

const int VK_ENTER = 0x0D;
const int VK_ESCAPE = 0x1B;

Console.WriteLine("===> Autoclicker started! ✨");
Console.WriteLine("===> Controls:");
Console.WriteLine("    - ENTER: confirm current action");
Console.WriteLine("    - ESC: exit program\n");

while (true)
{

    Console.WriteLine("===> Hover over the FLOWER and press ENTER...");
    WaitForKey(VK_ENTER);
    GetCursorPos(out Point flowerPos);
    Console.WriteLine($"Flower position saved: {flowerPos.X}, {flowerPos.Y}");

    Console.WriteLine("\n===> Now hover over the ZOMBIE EVENT and press ENTER...");
    WaitForKey(VK_ENTER);
    GetCursorPos(out Point zombiePos);
    Console.WriteLine($"Zombie event position saved: {zombiePos.X}, {zombiePos.Y}");

    Console.WriteLine("\n===> Press ENTER to start clicking cycle...");
    WaitForKey(VK_ENTER);

    Console.WriteLine("\n===> Starting in 3 seconds...");
    Thread.Sleep(3000);

    for (int i = 0; i < 4; i++)
    {
        SetCursorPos(zombiePos.X, zombiePos.Y);
        Click();
        Thread.Sleep(50);

        SetCursorPos(flowerPos.X, flowerPos.Y);
        Click();
        Thread.Sleep(50);
    }

    Console.WriteLine("\n✅ Cycle complete! ✨ Preparing next cycle...");
}

[DllImport("user32.dll")]
static extern bool SetCursorPos(int x, int y);

[DllImport("user32.dll")]
static extern bool GetCursorPos(out Point lpPoint);

[DllImport("user32.dll")]
static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

[DllImport("user32.dll")]
static extern short GetAsyncKeyState(int vKey);

static void Click()
{
    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, UIntPtr.Zero);
    Thread.Sleep(10);
    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, UIntPtr.Zero);
}

static void WaitForKey(int vKey)
{
    while (true)
    {
        Thread.Sleep(50); // CPU schonen
        if ((GetAsyncKeyState(vKey) & 0x8000) != 0)
        {
            break;
        }

        if ((GetAsyncKeyState(VK_ESCAPE) & 0x8000) != 0)
        {
            Console.WriteLine("\n🚪 ESC pressed! Exiting program.");
            Environment.Exit(0);
        }
    }
}