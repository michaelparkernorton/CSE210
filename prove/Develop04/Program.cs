using System;
using System.Text.Json;
Menu m = new();

bool active = true;
while (active) {
    m.ClearDisplay();
    m.DisplayMenu();
    m.ClearDisplay();
    Activity a = m.SelectActivity(m.Option);
    if (a != null) {
        a.StartActivity();
        m.ClearDisplay();
        a.RunActivity();
        a.EndActivity();
    }
    if (m.Option == 4) {
        active = false;
    }
}
