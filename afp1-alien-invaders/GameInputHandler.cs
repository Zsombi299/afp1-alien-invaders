using System;
using System.Collections.Generic;
using System.Windows.Forms;

internal class GameInputHandler {
    private HashSet<Keys> pressedKeys = new HashSet<Keys>();

    public GameInputHandler(Control control) {
        control.KeyDown += (s, e) => pressedKeys.Add(e.KeyCode);
        control.KeyUp += (s, e) => pressedKeys.Remove(e.KeyCode);
        control.Focus();
    }

    public bool IsKeyPressed(Keys key) {
        return pressedKeys.Contains(key);
    }

    public (int xSpeed, int ySpeed, bool isShooting) Update() {
        if(IsKeyPressed(Keys.Up))                                                                               // fel gomb fel megy
           return (0, -1, false);
        if (IsKeyPressed(Keys.Down))                                                                            // le gomb le
           return (0, 1, false);       
        if (IsKeyPressed(Keys.Left))                                                                            // stb
           return (-1, 0, false);
        if (IsKeyPressed(Keys.Right))
           return (1, 0, false);
        if (IsKeyPressed(Keys.Space))                                                                           // space a lövés
           return (0, 0, true);
        return (0, 0, false);
    }
}