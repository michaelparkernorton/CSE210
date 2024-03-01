using System;
using System.Text.Json;

Menu m = new();

bool active = true;
while (active)
{
	m.DisplayMenu();
	Activity a = m.SelectActivity(m.Option);
	if (a != null)
	{
		a.StartActivity();
		a.RunActivity();
		a.EndActivity();
	}
	if (m.Option == 5)
	{
		active = false;
	}
}





