// This file has been autogenerated from parsing an Objective-C header file added in Xcode.
using System;
#if __UNIFIED__
using Foundation;
using UIKit;
#else
using MonoTouch.Foundation;
using MonoTouch.UIKit;
#endif
using Xamarin.Themes;
using ThemeSample.Model;

namespace ThemeSample {
	public partial class ThemeListCell : UITableViewCell {
		public ThemeListCell (IntPtr handle) : base (handle)
		{
		}

		internal void Init (Track track)
		{
			TrackLabel.Text = track.Name;
			ArtistLabel.Text = track.Artist;
			AlbumImageView.Image = track.Image;
			LengthLabel.Text = track.Length;

			TrackLabel.TextColor = ColorSwitcher.TintColor;
		}

		protected override void Dispose (bool disposing)
		{
			ReleaseDesignerOutlets ();
			base.Dispose (disposing);
		}
	}
}
