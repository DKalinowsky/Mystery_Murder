using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;

namespace GraDetektywistyczna
{
    class Animations
    {
        public static void FramesAnimation(string[] frames, int repeatCount, int delay)
        {
            CursorVisible = false;
            for (int i = 0; i < repeatCount; i++)
            {
                foreach (string frame in frames)
                {
                    SetCursorPosition(0, 0);
                    WriteLine(frame);
                    Thread.Sleep(delay);
                }
            }
        }
        public static void Animation(string text, int blinkCount, int onTime, int offTime)
        {
            CursorVisible = false;
            for (int i = 0; i < blinkCount; i++)
            {
                WriteLine(text);
                Thread.Sleep(onTime);
                SetCursorPosition(0, 0);
                Thread.Sleep(offTime);

            }
        }
        public static void TextAnimation(string text, int delay)
        {
            CursorVisible = false;
            for (int i = 0; i < text.Length; i++)
            {
                Write(text[i]);
                Thread.Sleep(delay);

                if (KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = ReadKey();
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Clear();
                        Write(text);
                        break;
                    }
                }
            }
        }
    }
}
