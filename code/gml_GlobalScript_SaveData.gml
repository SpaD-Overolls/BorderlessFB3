/// PATCH

/// AFTER
if (arg0)
/// CODE
{
	switch(global.Settings[1][1])
	{
		case 0:
			window_set_showborder(true);
			window_set_fullscreen(false);
			window_set_size(640 * (global.Settings[1][0] + 1), 360 * (global.Settings[1][0] + 1));
			break;
		case 1:
			window_set_showborder(false);
			window_set_fullscreen(false);
			var _w = display_get_width();
			var _h = display_get_height();
			window_set_rectangle(0, 0, _w, _h);
			break;
		case 2:
			window_set_fullscreen(true);
			break;
	}
	
	window_center();
}

if (false) //cutting off vanilla code
/// END