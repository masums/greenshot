﻿#region Greenshot GNU General Public License

// Greenshot - a free and open source screenshot tool
// Copyright (C) 2007-2018 Thomas Braun, Jens Klingen, Robin Krom
// 
// For more information see: http://getgreenshot.org/
// The Greenshot project is hosted on GitHub https://github.com/greenshot/greenshot
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 1 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

#endregion

#region Usings

using System.ComponentModel;
using Dapplo.HttpExtensions.OAuth;
using Dapplo.Ini;
using Dapplo.InterfaceImpl.Extensions;
using Greenshot.Addons.Core.Enums;

#endregion

namespace Greenshot.Addon.Dropbox
{
	/// <summary>
	///     Description of ImgurConfiguration.
	/// </summary>
	[IniSection("Dropbox")]
	[Description("Greenshot Dropbox Plugin configuration")]
	public interface IDropboxConfiguration : IIniSection, IOAuth2Token, INotifyPropertyChanged, ITransactionalProperties
	{
		[Description("What file type to use for uploading")]
	    [DefaultValue(OutputFormats.png)]
		OutputFormats UploadFormat { get; set; }

		[Description("JPEG file save quality in %.")]
		[DefaultValue(80)]
		int UploadJpegQuality { get; set; }

		[Description("After upload send Dropbox link to clipboard.")]
		[DefaultValue(true)]
		bool AfterUploadLinkToClipBoard { get; set; }

	    /// <summary>
	    ///     Not stored, but read so people could theoretically specify their own consumer key.
	    /// </summary>
	    [IniPropertyBehavior(Write = false)]
	    [DefaultValue("@credentials_dropbox_consumer_key@")]
	    string ClientId { get; set; }

	    /// <summary>
	    ///     Not stored, but read so people could theoretically specify their own consumer secret.
	    /// </summary>
	    [IniPropertyBehavior(Write = false)]
	    [DefaultValue("@credentials_dropbox_consumer_secret@")]
	    string ClientSecret { get; set; }
    }
}